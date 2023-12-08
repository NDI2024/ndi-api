using NDI.Api.Domain.Entities;

namespace NDI.Api.Domain.Repositories;

public interface IQuestionsRepository
{
    public Task<IEnumerable<Question>> ListQuestionsAsync();
}