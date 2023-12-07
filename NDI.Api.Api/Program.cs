using FastEndpoints;
using FastEndpoints.Security;
using FastEndpoints.Swagger;
using Microsoft.AspNetCore.Builder;
using NDI.Api.Api.Hubs;
using NDI.Api.Api.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using NDI.Api.Infrastructure;
using NDI.Api.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);
IConfiguration configuration = CreateConfiguration();
builder.Services.AddDomainDataServices(configuration);
// Add services to the container.
builder.Services
    .AddFastEndpoints()
    .AddAuthenticationJWTBearer(configuration.GetSection("TokenStrings").GetSection("TokenSigningKey").Value)
    .AddAuthorization()
    ;
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInfrastructureImplementations(configuration, builder.Environment);
builder.Services.AddHealthChecks();
builder.Services.AddMemoryCache();

builder.Services.Configure<TokenOptions>(configuration.GetSection("TokenStrings"));

builder.Services.AddSwaggerDoc(
    config =>
    {
        config.Title = "NDI.Api.Api";
        config.Version = "v1";
        config.SerializerSettings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
    },
    shortSchemaNames: true);



WebApplication app = builder.Build();

app.MapHealthChecks("/health-check");
app.UseCors(b => b.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

app.UseAuthentication() 
    .UseAuthorization()
    .UseFastEndpoints(c =>
{
    c.Endpoints.Configurator = ep =>
    {
        ep.Options(b => b.RequireHost("*"));
    };
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseOpenApi();
    app.UseSwaggerUi3(s => s.ConfigureDefaults());
}
app.UseHttpsRedirection();

app.MapControllers();

app.UseEndpoints(endpoints =>
{
    endpoints.MapHub<GameHub>("/gamehub");
});

await app.MigrateDbAsync();

await app.RunAsync();

static IConfiguration CreateConfiguration()
{
    string? environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

    IConfigurationBuilder builder = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        .AddJsonFile($"appsettings.{environment}.json", optional: true, reloadOnChange: true)
        .AddEnvironmentVariables();

    if (environment == Environments.Development)
    {
        builder.AddUserSecrets<Program>(optional: true);
    }

    return builder.Build();
}

