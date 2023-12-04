using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace NDI.Api.Infrastructure.Extensions;

public static class DependencyInjectionExtensions
{
    public static IServiceCollection AddInfrastructureImplementations(this IServiceCollection services,
        IConfiguration configuration,
        IHostEnvironment hostEnvironment)
    {
        
        services.Scan(scan => 
            scan.FromCallingAssembly()                    
                .AddClasses()
                .AsMatchingInterface());
        
        return services;
    }
}