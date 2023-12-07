using NDI.Api.Domain.Entities.Interfaces;

namespace NDI.Api.Domain.Entities;

public class Score : Entity
{
    public decimal? Points { get; set; }
    public decimal? Time { get; set; }
    public int? NbError {get; set;}
    public User? User { get; set; }
}