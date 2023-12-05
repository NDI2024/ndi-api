using NDI.Api.Domain.Entities.Interfaces;
using NDI.Api.Domain.Enums;

namespace NDI.Api.Domain.Entities;

public class User : Entity
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    
    public UserRoleEnum Role { get; set; }
}