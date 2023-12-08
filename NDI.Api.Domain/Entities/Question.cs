using NDI.Api.Domain.Entities.Interfaces;

namespace NDI.Api.Domain.Entities;

public class Question : Entity
{
    public string? Text { get; set; }
    public List<Reponse>? Reponses { get; set; } 
}