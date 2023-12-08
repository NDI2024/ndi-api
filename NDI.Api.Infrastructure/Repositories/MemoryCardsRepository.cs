using Microsoft.EntityFrameworkCore;
using NDI.Api.Domain.Entities;
using NDI.Api.Domain.Repositories;
using NDI.Api.Infrastructure.EfCore;

namespace NoteTonRu.Api.Infrastructure.Repositories;

public class MemoryCardsRepository : IMemoryCardsRepository
{
    private readonly ApplicationDbContext _context;
    
    public MemoryCardsRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    
    public async Task<List<MemoryCard>> GetAllAsync()
    {
        List<MemoryCard> memoryCards = await _context.MemoryCards.Include(x => x.Informations).ToListAsync();
        return memoryCards;
    }
}