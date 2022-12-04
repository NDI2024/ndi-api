using Microsoft.EntityFrameworkCore;
using NoteTonRu.Api.Domain.Entities;

namespace NoteTonRu.Api.Infrastructure.EfCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext() { }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
    
    
    public DbSet<User> Users { get; set; }
    
}