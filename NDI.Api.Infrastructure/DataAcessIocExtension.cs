using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NDI.Api.Infrastructure.EfCore;
using Microsoft.Extensions.Hosting;

namespace NDI.Api.Infrastructure;

public static class DataAcessIocExtension
{
    public static IServiceCollection AddDomainDataServices(this IServiceCollection services, IConfiguration configuration)
    {
        string connectionString = configuration.GetConnectionString(nameof(ApplicationDbContext));
        services.AddDbContext<ApplicationDbContext>(options => options.UseEfCoreProvider(connectionString));

        return services;
    }
    
    public async static Task MigrateDbAsync(this IHost host)
    {
        using IServiceScope scope = host.Services.CreateScope();
        ILogger<ApplicationDbContext> logger = scope.ServiceProvider.GetRequiredService<ILogger<ApplicationDbContext>>();

        ApplicationDbContext dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        logger.LogInformation($"Provider: {dbContext.Database.ProviderName}");

        logger.LogInformation("Migrate database...");
        await dbContext.Database.MigrateAsync();
        logger.LogInformation("Database migrated.");
    }
    internal static DbContextOptionsBuilder UseEfCoreProvider(this DbContextOptionsBuilder builder,
        string connectionString)
    {
        builder.UseSqlServer(connectionString);
        return builder;
    }
}