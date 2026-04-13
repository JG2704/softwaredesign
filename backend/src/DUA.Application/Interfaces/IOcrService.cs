namespace DUA.Application.Interfaces;

public interface IOcrService
{
    Task<string> ExtractTextAsync(string storageKey, CancellationToken cancellationToken);
}
