using NDI.Api.Domain.Services;

namespace NDI.Api.Infrastructure.Services;

public class GPTService : IGPTService
{
    private string endpoint;
    private string key;
    
    public GPTService()
    {
    }
    
    public Task<string> Ask(string prompt)
    {
        throw new NotImplementedException();
    }
}