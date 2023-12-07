using FastEndpoints;
using NDI.Api.Domain.Repositories;

namespace NDI.Api.Api.Endpoints.Users.Leaderboards;

public class GetLeaderboardRequest
{
    public int? Max { get; set; }
}

public class LeaderboardEndpoint : Endpoint<GetLeaderboardRequest,List<GetLeaderboardModel>>
{
    private readonly IScoresRepository _scoresRepository;
    
    public LeaderboardEndpoint(IScoresRepository scoresRepository)
    {
        _scoresRepository = scoresRepository;
    }
    
    public override void Configure()
    {
        Get("/leaderboard");
        AllowAnonymous();
    }

    public override async Task HandleAsync(GetLeaderboardRequest req, CancellationToken ct)
    {
        var scores = await _scoresRepository.GetAllAsync();
        scores = scores.OrderByDescending(x => x.Points).ToList();
        if (req.Max != null)
        {
            scores = scores.Take(req.Max.Value).ToList();
        }
        
        List<GetLeaderboardModel> models = scores.Select(x => new GetLeaderboardModel
        {
            Username = x.User!.Username,
            Points = x.Points,
            Rank = scores.IndexOf(x) + 1
        }).ToList();
        
        await SendAsync(models, cancellation: ct);
    }
}
public class GetLeaderboardModel
{
    public string? Username { get; set; }
    public decimal? Points { get; set; }
    public int? Rank { get; set; }
}