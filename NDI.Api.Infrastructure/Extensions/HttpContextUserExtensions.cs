using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using NDI.Api.Domain.Entities.Identity;
using NDI.Api.Domain.Enums;

namespace NDI.Api.Infrastructure.Extensions;

public static class HttpContextUserExtensions
{
    public static string GetUserId(this HttpContext context) => context.User.Claims.FirstOrDefault(x => x.Type == ClaimsCodes.Id)?.Value ?? string.Empty;
    public static string GetUserName(this HttpContext context) => context.User.Claims.FirstOrDefault(x => x.Type == ClaimsCodes.Username)?.Value ?? string.Empty;
    public static string GetEmail(this HttpContext context) => context.User.Claims.FirstOrDefault(x => x.Type == ClaimsCodes.Email)?.Value ?? string.Empty;
    public static string GetRole(this HttpContext context) => context.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Role)?.Value ?? string.Empty;
    
    public static CurrentUser GetCurrentUser(this HttpContext context)
    {
        string username = context.GetUserName();
        Guid id = Guid.Parse(context.GetUserId());
        string email = context.GetEmail();
        string role = context.GetEmail();



        return new CurrentUser(id, username, email, role switch
        {
            "Admin" => UserRoleEnum.Admin,
            "User" => UserRoleEnum.User,
            _ => throw new Exception("Invalid role")
        });
    }
}