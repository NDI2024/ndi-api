using Azure;
using Azure.AI.OpenAI;
using Microsoft.Extensions.Options;
using NDI.Api.Domain.Services;
using NDI.Api.Infrastructure.Options;

namespace NDI.Api.Infrastructure.Services;

public class GPTService : IGPTService
{
    private OpenAIOptions _openAIOptions;
    
    public GPTService( IOptions<OpenAIOptions> openAIOptions)
    {
        _openAIOptions = openAIOptions.Value;

    }
    
    public string Ask(string prompt)
    {
        var client = new OpenAIClient(new Uri(_openAIOptions.Endpoint), new AzureKeyCredential(_openAIOptions.ApiKey));

        CompletionsOptions completionsOptions = new()
        {
            DeploymentName = _openAIOptions.DeploymentName,
            Prompts = { prompt },
            
        };

        Response<Completions> completionsResponse = client.GetCompletions(completionsOptions);
        return completionsResponse.Value.Choices.First().Text;
    }
}