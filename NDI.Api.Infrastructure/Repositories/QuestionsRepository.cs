using Microsoft.EntityFrameworkCore;
using NDI.Api.Domain.Entities;
using NDI.Api.Domain.Repositories;
using NDI.Api.Infrastructure.EfCore;

namespace NDI.Api.Infrastructure.Repositories;

public class QuestionsRepository : IQuestionsRepository
{
    private readonly ApplicationDbContext _context;
    public QuestionsRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<Question>> ListQuestionsAsync()
    {
        return await _context.Questions.Include(x => x.Reponses).ToListAsync();
    }
}