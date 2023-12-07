﻿using System.Security.Claims;
 using FastEndpoints;
using FastEndpoints.Security;
 using Microsoft.Extensions.Options;
using NDI.Api.Api.Options;
using NDI.Api.Domain.Entities;
 using NDI.Api.Domain.Enums;
 using NDI.Api.Domain.Repositories;
using NDI.Api.Domain.Services;

namespace NDI.Api.Api.Endpoints.Users;

public class LoginUserEndpoint : Endpoint<LoginUserRequest, string>
{
    private readonly IUsersRepository _usersRepository;
    private readonly TokenOptions _tokenOptions; 

    public override void Configure()
    {
        AllowAnonymous();
        Post("/users/login");
    }
    
    
    public LoginUserEndpoint(IUsersRepository usersRepository, IOptions<TokenOptions> tokenOptions)
    {
        _usersRepository = usersRepository;
        _tokenOptions = tokenOptions.Value;
    }


    public override async Task HandleAsync(LoginUserRequest request, CancellationToken cancellationToken)
    {
        if (string.IsNullOrWhiteSpace(request.Username))
        {
            throw new Exception("Username is mandatory");
        }
        
        if (string.IsNullOrWhiteSpace(request.Password))
        {
            throw new Exception("Password is mandatory");
        }
        
        User? user = await _usersRepository.GetByUsernameOrEmail(request.Username, request.Username);
        if (user == null)
        {
            throw new Exception("User not found");
        }

        var hashedPassword = HashService.Hash(request.Password);
        if (hashedPassword != user.Password)
        {
            throw new Exception("Invalid password");
        }
        
        var jwtToken = JWTBearer.CreateToken(
            signingKey: _tokenOptions.TokenSigningKey,
            expireAt: DateTime.UtcNow.AddDays(1),
            claims: new[] {(ClaimsCodes.Username, user.Username), (ClaimsCodes.Id, user.Id.ToString()), (ClaimsCodes.Email, user.Email)},
            roles: new[] {user.Role.ToString()});

        await SendAsync(jwtToken, cancellation: cancellationToken);
    }
}


public class LoginUserRequest
{
   
    public string? Username { get; set; }

    public string? Password { get; set; }
}