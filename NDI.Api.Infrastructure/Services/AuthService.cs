using Microsoft.AspNetCore.Http;
using NDI.Api.Domain;
using NDI.Api.Domain.Entities.Identity;
using NDI.Api.Infrastructure.Extensions;

namespace NDI.Api.Infrastructure.Services;

public class AuthService : IAuthService
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    
    public AuthService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }
    
    public Task<CurrentUser> CurrentUserAsync()
    {
        CurrentUser currentUser = _httpContextAccessor.HttpContext.GetCurrentUser();

        return Task.FromResult(currentUser);
    }
}