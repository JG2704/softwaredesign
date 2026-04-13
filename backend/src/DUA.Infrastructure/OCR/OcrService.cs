using DUA.Application.Interfaces;

namespace DUA.Infrastructure.OCR;

public sealed class OcrService : IOcrService
{
    public Task<string> ExtractTextAsync(string storageKey, CancellationToken cancellationToken)
    {
        return Task.FromResult(string.Empty);
    }
}
