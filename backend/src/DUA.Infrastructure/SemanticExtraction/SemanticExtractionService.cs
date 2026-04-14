using DUA.Application.Interfaces;

namespace DUA.Infrastructure.SemanticExtraction;

public sealed class SemanticExtractionService : ISemanticExtractionService
{
    public Task<IDictionary<string, string>> ExtractAsync(string inputText, CancellationToken cancellationToken)
        => Task.FromResult<IDictionary<string, string>>(new Dictionary<string, string>());
}
