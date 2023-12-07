namespace NDI.Api.Domain.Services;

public interface IGPTService
{
    public Task<string> Ask(string prompt);
}