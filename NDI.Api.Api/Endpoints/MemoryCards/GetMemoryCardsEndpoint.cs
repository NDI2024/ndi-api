using FastEndpoints;
using NDI.Api.Domain.Entities;
using NDI.Api.Domain.Enums;
using NDI.Api.Domain.Repositories;

namespace NDI.Api.Api.Endpoints.Users.MemoryCards;

public class GetMemoryCardsRequest
{
    public int PairNumber { get; set; }
}

public class GetMemoryCardsEndpoint : Endpoint<GetMemoryCardsRequest,List<GetMemoryCardsModel>>
{
    private readonly IMemoryCardsRepository _memoryCardsRepository;
        
        
    public GetMemoryCardsEndpoint(IMemoryCardsRepository memoryCardsRepository)
    {
        _memoryCardsRepository = memoryCardsRepository;
    }
    
    
    public override void Configure()
    {
        Get("/memorycards/{pairNumber}");
        Roles(UserRoleEnum.User.ToString());
    }

    public override async Task HandleAsync(GetMemoryCardsRequest req, CancellationToken ct)
    {
       List<MemoryCard> memoryCards = await _memoryCardsRepository.GetAllAsync();

       memoryCards = memoryCards.OrderBy(x => Guid.NewGuid()).Take(req.PairNumber).ToList();
       
       List<GetMemoryCardsModel> models = new List<GetMemoryCardsModel>();

       foreach (var memorycard in memoryCards)
       {
          var randomInt = new Random().Next(0, memorycard.Informations!.Count); 
          models.Add(new GetMemoryCardsModel()
          {
              Title = memorycard.Title,
              ImagePath = memorycard.ImagePath,
              ShortDescription = memorycard.Informations![randomInt].ShortDescription,
              Description = memorycard.Informations![randomInt].LongDescription,
              Link = memorycard.Informations![randomInt].Link
          });
       }

       await SendAsync(models, cancellation: ct);

    }
}


public class GetMemoryCardsModel
{
    public string? Title { get; set; }
    public string? ImagePath { get; set; }
    public string? ShortDescription { get; set; }
    public string? Description { get; set; }
    public string? Link { get; set; }
}