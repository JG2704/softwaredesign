namespace DUA.Domain.Entities;

public sealed class GeneratedDua
{
    public Guid Id { get; init; }
    public Guid JobId { get; init; }
    public string Content { get; init; } = string.Empty;
    public DateTimeOffset GeneratedAtUtc { get; init; }
}
