namespace DUA.Application.Interfaces;

public interface IFileStorageService
{
    Task<string> UploadAsync(Stream content, string fileName, CancellationToken cancellationToken);
}
