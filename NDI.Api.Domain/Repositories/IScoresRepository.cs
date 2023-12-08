using NDI.Api.Domain.Entities;

namespace NDI.Api.Domain.Repositories;

public interface IScoresRepository
{
    public Task AddAsync(Score score);
    public Task<List<Score>> GetAllAsync();
    public Task<List<Score>> GetByUserIdAsync(Guid userId);
}