using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NDI.Api.Domain.Entities.Interfaces;

namespace NDI.Api.Domain.Entities;

public class Information : Entity
{
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        [NotMapped]
        public List<string>? Link { get; set; }

        public string LinkString
        {
                get { return string.Join(",", Link); }
                set { Link = value.Split(',').ToList(); }
        }

        public Guid MemoryCardId { get; set; }

}