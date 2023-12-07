using FastEndpoints;
using NDI.Api.Domain;
using NDI.Api.Domain.Entities.Identity;

namespace NDI.Api.Api.Endpoints.Users;

public class MeEndpoint : EndpointWithoutRequest<GetMeResponse>
{
    private readonly IAuthService _authService;

    public MeEndpoint(IAuthService authService) => _authService = authService;

    public override void Configure()
    {
        Verbs(Http.GET);
        Routes("/me");
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        CurrentUser user = await _authService.CurrentUserAsync();

        var response = new GetMeResponse
        {
            Username = user.Username,
            Email = user.Email,
            Role = user.Role.ToString(),
            Id = user.Id
        };

        await SendAsync(response, cancellation: ct);
    }
}

public class GetMeResponse
{
    public Guid Id { get; set; }
    public string Username { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string Role { get; set; } = default!;
}