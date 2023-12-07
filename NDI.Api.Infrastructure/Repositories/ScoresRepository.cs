using Microsoft.EntityFrameworkCore;
using NDI.Api.Domain.Entities;
using NDI.Api.Domain.Repositories;
using NDI.Api.Infrastructure.EfCore;

namespace NoteTonRu.Api.Infrastructure.Repositories;

public class ScoresRepository : IScoresRepository
{
    private readonly ApplicationDbContext _context;

    public ScoresRepository(ApplicationDbContext context)
    {
        _context = context;
    }


    public async Task AddAsync(Score score)
    {
        try
        {
            await _context.Scores.AddAsync(score);
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    public async Task<List<Score>> GetAllAsync()
    {
        return await _context.Scores.Include(x => x.User).ToListAsync();
    }

    public async Task<List<Score>> GetByUserIdAsync(Guid userId)
    {
        return await _context.Scores.Include(x => x.User).Where(x => x.User!.Id == userId).ToListAsync();
    }
}