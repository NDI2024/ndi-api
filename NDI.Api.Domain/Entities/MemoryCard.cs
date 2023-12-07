using NDI.Api.Domain.Entities.Interfaces;

namespace NDI.Api.Domain.Entities;

public class MemoryCard : Entity
{
    public string? Title { get; set; }
    public string? ImagePath { get; set; }
    public List<Information>? Informations { get; set; }
}