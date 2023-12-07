using System.Net.Mail;
using System.Text.RegularExpressions;
using FastEndpoints;
using NDI.Api.Domain.Entities;
using NDI.Api.Domain.Repositories;
using NDI.Api.Domain.Services;

namespace NDI.Api.Api.Endpoints.Users;

public class RegisterUserEndpoint : Endpoint<RegisterUserRequest, bool>
{
    private readonly IUsersRepository _usersRepository;

    private const int MinUsernameLength = 5;
    private const int MaxUsernameLength = 20;
    private const string UsernameRegex = @"^[a-zA-Z0-9_]+$";
    
    // Password requirements
    private static readonly Regex PasswordHasNumberRegex = new(@"[0-9]+");
    private static readonly Regex PasswordHasUpperCharRegex = new(@"[A-Z]+");
    private static readonly Regex PasswordHasLowerCharRegex = new(@"[a-z]+");
    private static readonly Regex PasswordHasSpecialCharRegex = new(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
    private static readonly Regex PasswordLengthRegex = new(@".{8,20}");

    public override void Configure()
    {
        AllowAnonymous();
        Post( "/users/register");
    }
    
    
    public RegisterUserEndpoint(IUsersRepository usersRepository)
    {
        _usersRepository = usersRepository;
    }
    
    public override async Task HandleAsync(RegisterUserRequest request, CancellationToken cancellationToken)
    {

        if (string.IsNullOrWhiteSpace(request.Username))
        {
            ThrowError("Username is mandatory");
        }
        
        if (request.Username.Length is < MinUsernameLength or > MaxUsernameLength 
            || !Regex.IsMatch(request.Username, UsernameRegex))
        {
            ThrowError("Invalid username");
        }
        
        if (string.IsNullOrWhiteSpace(request.Email))
        {
            ThrowError("Email is mandatory");
        }
        
        try
        {
            MailAddress mailAddress = new(request.Email);
            if (mailAddress.Address != request.Email)
            {
                ThrowError("Invalid email");
            }
        }
        catch (FormatException)
        {
            ThrowError("Invalid email");
        }
        
        if (string.IsNullOrWhiteSpace(request.Password))
        {
            ThrowError("Password is mandatory");
        }
        
        if (!PasswordLengthRegex.IsMatch(request.Password) 
            || !PasswordHasNumberRegex.IsMatch(request.Password) 
            || !PasswordHasUpperCharRegex.IsMatch(request.Password) 
            || !PasswordHasLowerCharRegex.IsMatch(request.Password) 
            || !PasswordHasSpecialCharRegex.IsMatch(request.Password))
        {
            ThrowError("Invalid password");
        }
        
        User? existingUser = await _usersRepository.GetByUsernameOrEmail(request.Username, request.Email);
        if (existingUser != null)
        {
            ThrowError("User already exists");
        }

        var hashedPassword = HashService.Hash(request.Password);
        User user = new()
        {
            Username = request.Username,
            Password = hashedPassword,
            Email = request.Email
        };
        
        await _usersRepository.Create(user);
        await SendAsync(true, cancellation: cancellationToken);
    }
}

public class RegisterUserRequest
{
    public string? Username { get; set; }
    public string? Password { get; set; }
    public string? Email { get; set; }
}