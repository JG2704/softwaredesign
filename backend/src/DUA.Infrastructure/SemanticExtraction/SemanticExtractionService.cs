using DUA.Application.Interfaces;

namespace DUA.Infrastructure.SemanticExtraction;

public sealed class SemanticExtractionService : ISemanticExtractionService
{
    public Task<IDictionary<string, string>> ExtractAsync(string rawText, CancellationToken cancellationToken)
    {
        IDictionary<string, string> values = new Dictionary<string, string>();
        return Task.FromResult(values);
    }
}
