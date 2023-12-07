using NDI.Api.Domain.Enums;

namespace NDI.Api.Domain.Entities.Identity;

public class CurrentUser
{
    public CurrentUser(Guid id, string username, string email, UserRoleEnum role)
    {
        Id = id;
        Username = username;
        Email = email;
        Role = role;
    }

    public Guid Id { get; set; }
    public string Username { get; set; } = null!;
    public string Email { get; set; } = null!;
    public UserRoleEnum Role { get; set; }
}