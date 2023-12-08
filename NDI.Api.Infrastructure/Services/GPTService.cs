using Azure;
using Azure.AI.OpenAI;
using NDI.Api.Domain.Services;
using NDI.Api.Infrastructure.Options;

namespace NDI.Api.Infrastructure.Services;

public class GPTService : IGPTService
{
    private OpenAIClient _openAIClient;
    
    public GPTService(OpenAIOptions openAIOptions)
    {
        _openAIClient = new OpenAIClient(new Uri(openAIOptions.Endpoint), new AzureKeyCredential(openAIOptions.ApiKey));
    }
    
    public string Ask(string prompt)
    {
        CompletionsOptions completionsOptions = new()
        {
            DeploymentName = "gpt-35-turbo-instruct",
            Prompts = { prompt },
        };

        Response<Completions> completionsResponse = _openAIClient.GetCompletions(completionsOptions);
        return completionsResponse.Value.Choices.First().Text;
    }
}