using Microsoft.EntityFrameworkCore;
using NDI.Api.Domain.Entities;
using NDI.Api.Domain.Repositories;
using NDI.Api.Infrastructure.EfCore;

namespace NoteTonRu.Api.Infrastructure.Repositories;

public class QuestionsRepository : IQuestionsRepository
{
    private readonly ApplicationDbContext _context;
    
    public async Task<IEnumerable<Question>> ListQuestionsAsync()
    {
        return _context.Questions.Include(x => x.Reponses).AsEnumerable();
    }
}