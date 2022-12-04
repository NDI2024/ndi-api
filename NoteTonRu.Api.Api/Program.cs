using FastEndpoints;
using FastEndpoints.Swagger;
using Microsoft.AspNetCore.Builder;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using NoteTonRu.Api.Infrastructure;
using NoteTonRu.Api.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);
IConfiguration configuration = CreateConfiguration();
builder.Services.AddDomainDataServices(configuration);
// Add services to the container.
builder.Services.AddFastEndpoints();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInfrastructureImplementations(configuration, builder.Environment);
builder.Services.AddHealthChecks();

builder.Services.AddSwaggerDoc(
    config =>
    {
        config.Title = "NoteTonRu.Api.Api";
        config.Version = "v1";
        config.SerializerSettings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
    },
    shortSchemaNames: true);

WebApplication app = builder.Build();

app.MapHealthChecks("/health-check");

app.UseAuthorization();
app.UseFastEndpoints();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseOpenApi();
    app.UseSwaggerUi3(s => s.ConfigureDefaults());
}

app.UseCors(b => b.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

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

