using NDI.Api.Domain.Entities;

namespace NDI.Api.Domain.Repositories;

public interface IMemoryCardsRepository
{
    public Task<List<MemoryCard>> GetAllAsync();
}