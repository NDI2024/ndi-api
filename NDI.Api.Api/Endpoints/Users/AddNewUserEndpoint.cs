using FastEndpoints;
using NDI.Api.Domain.Entities;
using NDI.Api.Domain.Repositories;

namespace NDI.Api.Api.Endpoints.Users;

public class NewUserRequest
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}

public class AddNewUserEndpoint : Endpoint<NewUserRequest,bool>
{
    private readonly IUsersRepository _usersRepository;
    public AddNewUserEndpoint(IUsersRepository usersRepository)
    {
        _usersRepository = usersRepository;
    }
    
    public override void Configure()
    {
        Post("/users");
        AllowAnonymous();
    }

    public override async Task HandleAsync(NewUserRequest req, CancellationToken ct)
    {
        User user = new User
        {
            Username = req.Username,
            Email = req.Email,
            Password = req.Password
        };
        await _usersRepository.CreateAsync(user, ct);
        SendAsync(true, cancellation: ct);
    }

    
}