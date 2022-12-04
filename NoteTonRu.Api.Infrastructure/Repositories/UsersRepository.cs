using NoteTonRu.Api.Domain.Entities;
using NoteTonRu.Api.Domain.Repositories;
using NoteTonRu.Api.Infrastructure.EfCore;

namespace NoteTonRu.Api.Infrastructure.Repositories;

public class UsersRepository : IUsersRepository
{
    private readonly ApplicationDbContext _context;
    public UsersRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task CreateAsync(User entity, CancellationToken token = default)
    {
        try
        {
            await _context.Users.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            throw e;
        }
    }
}