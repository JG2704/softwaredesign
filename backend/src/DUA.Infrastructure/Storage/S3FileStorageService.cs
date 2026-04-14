using DUA.Application.Interfaces;

namespace DUA.Infrastructure.Storage;

public sealed class S3FileStorageService : IFileStorageService
{
    public Task<string> SaveAsync(Stream content, string fileName, CancellationToken cancellationToken)
        => Task.FromResult($"s3://placeholder/{fileName}");
}
