using FastEndpoints;
using NDI.Api.Domain;
using NDI.Api.Domain.Entities;
using NDI.Api.Domain.Entities.Identity;
using NDI.Api.Domain.Enums;
using NDI.Api.Domain.Repositories;

namespace NDI.Api.Api.Endpoints.Users.Scores;

public class AddScoreRequest
{
    public decimal? Time { get; set; }
    public int? NbError { get; set; }
}

public class AddScoreEndpoint : Endpoint<AddScoreRequest>
{
    private readonly IAuthService _authService;
    private readonly IUsersRepository _usersRepository;
    private readonly IScoresRepository _scoresRepository;
    public AddScoreEndpoint(IAuthService authService, IUsersRepository usersRepository, IScoresRepository scoresRepository)
    {
        _authService = authService;
        _usersRepository = usersRepository;
        _scoresRepository = scoresRepository;
    }
    
    public override void Configure()
    {
        Post("/scores");
        Roles(UserRoleEnum.User.ToString());
    }
    
    public override async Task HandleAsync(AddScoreRequest req, CancellationToken ct)
    {
        CurrentUser currentUser = await _authService.CurrentUserAsync();
        User? user = await _usersRepository.GetFullById(currentUser.Id);

        if (user == null)
        {
            ThrowError("Utilisateur introuvable !");
        }
        
        decimal coef = 0.1m;
        Score score = new Score
        {
            User = user,
            Time = req.Time,
            NbError = req.NbError,
            Points =  (decimal)  (1.0 / (1.0 + Math.Exp(decimal.ToDouble(-coef * (1/ req.Time.Value - req.NbError).Value)))) * 100
        };
        await _scoresRepository.AddAsync(score);
    }
    
}

