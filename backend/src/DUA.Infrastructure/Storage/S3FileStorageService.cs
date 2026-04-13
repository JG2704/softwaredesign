using DUA.Application.Interfaces;

namespace DUA.Infrastructure.Storage;

public sealed class S3FileStorageService : IFileStorageService
{
    public Task<string> UploadAsync(Stream content, string fileName, CancellationToken cancellationToken)
    {
        return Task.FromResult($"s3://placeholder/{fileName}");
    }
}
