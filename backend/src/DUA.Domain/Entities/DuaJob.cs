using DUA.Domain.Enums;

namespace DUA.Domain.Entities;

public sealed class DuaJob
{
    public Guid Id { get; init; }
    public Guid UserId { get; init; }
    public DuaJobStatus Status { get; set; } = DuaJobStatus.Pending;
    public DateTimeOffset CreatedAtUtc { get; init; } = DateTimeOffset.UtcNow;
}
