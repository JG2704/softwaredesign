namespace DUA.Domain.Entities;

public sealed class UploadedDocument
{
    public Guid Id { get; init; }
    public Guid JobId { get; init; }
    public string FileName { get; init; } = string.Empty;
    public string StorageKey { get; init; } = string.Empty;
}
