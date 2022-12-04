using NoteTonRu.Api.Domain.Entities;

namespace NoteTonRu.Api.Domain.Repositories;

public interface IUsersRepository
{
    Task CreateAsync(User entity, CancellationToken token = default);
}