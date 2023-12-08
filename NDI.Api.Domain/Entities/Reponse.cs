using NDI.Api.Domain.Entities.Interfaces;

namespace NDI.Api.Domain.Entities;

public class Reponse : Entity
{
    public string? Text { get; set; }
    public bool IsCorrect { get; set; } = false;
    public Question? Question { get; set; }
    public Guid? QuestionId { get; set; }    
}