namespace DUA.Application.Interfaces;

public interface ISemanticExtractionService
{
    Task<IDictionary<string, string>> ExtractAsync(string rawText, CancellationToken cancellationToken);
}
