using NDI.Api.Domain.Entities.Interfaces;

namespace NDI.Api.Domain.Entities;

public class Information : Entity
{
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public string? Link { get; set; }
}