namespace DUA.Application.Interfaces;

public interface ISemanticExtractionService
{
    Task<IDictionary<string, string>> ExtractAsync(string inputText, CancellationToken cancellationToken);
}
