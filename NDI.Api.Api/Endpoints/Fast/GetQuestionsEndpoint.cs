using FastEndpoints;
using NDI.Api.Domain.Entities;
using NDI.Api.Domain.Enums;
using NDI.Api.Domain.Repositories;
using NDI.Api.Domain.Services;

namespace NDI.Api.Api.Endpoints.Users.Fast;

public class GetQuestionsRequest
{
    public int? NbQuestions { get; set; }
}

public class GetQuestionsEndpoint : Endpoint<GetQuestionsRequest,List<GetQuestionsResponse>>
{
    private readonly IQuestionsRepository _questionsRepository;
    private readonly IGPTService _gptService;
    
    public GetQuestionsEndpoint(IQuestionsRepository questionsRepository, IGPTService gptService)
    {
        _questionsRepository = questionsRepository;
        _gptService = gptService;
    }

    public override void Configure()
    {
        Get("/question/{NbQuestions}");
        Roles(UserRoleEnum.User.ToString());
    }

    public override async Task HandleAsync(GetQuestionsRequest req, CancellationToken ct)
    {
        var questions = await _questionsRepository.ListQuestionsAsync();
        questions = questions.OrderBy(x => Guid.NewGuid()).Take(req.NbQuestions ?? 1).ToList();

        List<GetQuestionsResponse> models = questions.Select(x => new GetQuestionsResponse
        {
            Id = x.Id,
            QuestionLabel = x.Text,
            Reponses = x.Reponses?.Select(r => new ReponseModel
            {
                Id = r.Id,
                ReponseLabel = r.Text,
                IsCorrect = r.IsCorrect
            }).Where(x => x.IsCorrect ?? false).ToList()
        }).ToList();
        
        //Add false informations from chatgpt
        foreach (var model in models)
        {
            var reponse = _gptService.Ask($"A l'aide de la question suivante : {model.QuestionLabel}, donne moi une mauvaise réponse (la bonne réponse est {model.Reponses?.FirstOrDefault()?.ReponseLabel})");
            model.Reponses?.Add(new ReponseModel
            {
                Id = Guid.NewGuid(),
                ReponseLabel = reponse,
                IsCorrect = false
            });
        }
        
        await SendAsync(models, cancellation: ct);
    }
}

public class GetQuestionsResponse
{
    public Guid Id { get; set; }
    public string? QuestionLabel { get; set; }
    public List<ReponseModel>? Reponses { get; set; }
}

public class ReponseModel
{
    public Guid Id { get; set; }
    public string? ReponseLabel { get; set; }
    public bool? IsCorrect { get; set; }
}
