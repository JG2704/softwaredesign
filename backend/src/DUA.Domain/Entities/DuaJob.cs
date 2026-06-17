namespace DUA.Domain.Entities;

public sealed class DuaJob
{
    public Guid Id { get; init; }
    public Guid UserId { get; init; }
    public string Status { get; set; } = "Pending";
    public DateTimeOffset RequestedAtUtc { get; init; }
}
