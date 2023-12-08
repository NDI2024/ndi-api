namespace NDI.Api.Infrastructure.Options;

public class OpenAIOptions
{
    public string Endpoint { get; set; } = string.Empty;
    public string RessourceName { get; set; } = string.Empty;
    public string ApiKey { get; set; } = string.Empty;
    public string ModelName { get; set; } = string.Empty;
    public string DeploymentName { get; set; } = string.Empty;
}