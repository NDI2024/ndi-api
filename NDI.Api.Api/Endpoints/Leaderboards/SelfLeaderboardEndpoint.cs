using FastEndpoints;
using NDI.Api.Domain;
using NDI.Api.Domain.Entities.Identity;
using NDI.Api.Domain.Enums;
using NDI.Api.Domain.Repositories;

namespace NDI.Api.Api.Endpoints.Users.Leaderboards;

public class SelfLeaderboardRequest
{
    public int? Max { get; set; }
}

public class SelfLeaderboardEndpoint : Endpoint<SelfLeaderboardRequest,List<SelfLeaderboardModel>>
{
    private readonly IAuthService _authService;
    private readonly IScoresRepository _scoresRepository;
    public SelfLeaderboardEndpoint(IAuthService authService, IScoresRepository scoresRepository)
    {
        _authService = authService;
        _scoresRepository = scoresRepository;
    }
    
    public override void Configure()
    {
        Get("/leaderboard/me");
        Roles(UserRoleEnum.User.ToString());
    }
    
    public override async Task HandleAsync(SelfLeaderboardRequest req, CancellationToken ct)
    {
        CurrentUser currentUser = await _authService.CurrentUserAsync();
        var scores = await _scoresRepository.GetByUserIdAsync(currentUser.Id);
        scores = scores.OrderByDescending(x => x.Points).ToList();
        if (req.Max != null)
        {
            scores = scores.Take(req.Max.Value).ToList();
        }
        
        List<SelfLeaderboardModel> models = scores.Select(x => new SelfLeaderboardModel
        {
            Username = x.User!.Username,
            Points = x.Points,
            Rank = scores.IndexOf(x) + 1
        }).ToList();
        
        await SendAsync(models, cancellation: ct);
    }
    
}

public class SelfLeaderboardModel
{
    public string? Username { get; set; }
    public decimal? Points { get; set; }
    public int? Rank { get; set; }
}