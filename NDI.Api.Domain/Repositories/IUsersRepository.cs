using NDI.Api.Domain.Entities;

namespace NDI.Api.Domain.Repositories;

public interface IUsersRepository
{

    Task  Create(User entity);
 
    Task<User?> GetFullById(Guid id);
   
    Task<User?> GetByUsernameOrEmail(string? username, string? email);
}