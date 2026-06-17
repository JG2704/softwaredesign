namespace DUA.Application.Interfaces;

public interface IFileStorageService
{
    Task<string> SaveAsync(Stream content, string fileName, CancellationToken cancellationToken);
}
