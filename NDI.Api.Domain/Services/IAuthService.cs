using NDI.Api.Domain.Entities.Identity;

namespace NDI.Api.Domain;

public interface IAuthService
{
    public Task<CurrentUser> CurrentUserAsync();
}