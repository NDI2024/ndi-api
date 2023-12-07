using Microsoft.EntityFrameworkCore;
using NDI.Api.Domain.Entities;

namespace NDI.Api.Infrastructure.EfCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext() { }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        Seeder.SeedAsync(modelBuilder); 
        base.OnModelCreating(modelBuilder);
    }
    
    
    public DbSet<User> Users { get; set; }
    public DbSet<Information> Informations { get; set; }
    public DbSet<MemoryCard> MemoryCards { get; set; }
    public DbSet<Score> Scores { get; set; }
    
}