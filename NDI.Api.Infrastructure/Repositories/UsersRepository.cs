using Microsoft.EntityFrameworkCore;
using NDI.Api.Domain.Entities;
using NDI.Api.Domain.Repositories;
using NDI.Api.Infrastructure.EfCore;
using NDI.Api.Domain.Entities;
using NDI.Api.Domain.Repositories;
using NDI.Api.Infrastructure.EfCore;

namespace NoteTonRu.Api.Infrastructure.Repositories;

public class UsersRepository : IUsersRepository
{
    private readonly ApplicationDbContext _context;
    public UsersRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task  Create(User entity)
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

    public async Task<User?> GetFullById(Guid id)
    {
        User? user = await _context.Users
            .FirstOrDefaultAsync(u => u.Id.Equals(id));

        return user;
    }

    public async Task<User?> GetByUsernameOrEmail(string? username, string? email)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Username.Equals(username) || u.Email.Equals(email));
    }
}