namespace DUA.Domain.Entities;

public sealed class GeneratedDua
{
    public Guid Id { get; init; }
    public Guid DuaJobId { get; init; }
    public string OutputStorageKey { get; init; } = string.Empty;
    public DateTimeOffset GeneratedAtUtc { get; init; } = DateTimeOffset.UtcNow;
}
