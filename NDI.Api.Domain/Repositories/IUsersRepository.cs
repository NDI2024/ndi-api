using NDI.Api.Domain.Entities;

namespace NDI.Api.Domain.Repositories;

public interface IUsersRepository
{
    Task CreateAsync(User entity, CancellationToken token = default);
}