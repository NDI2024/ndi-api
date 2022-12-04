using NoteTonRu.Api.Domain.Entities.Interfaces;

namespace NoteTonRu.Api.Domain.Entities;

public class User : Entity
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}