namespace DUA.Domain.Entities;

public sealed class User
{
    public Guid Id { get; init; }
    public string Email { get; init; } = string.Empty;
    public string FullName { get; init; } = string.Empty;
    public DateTimeOffset CreatedAtUtc { get; init; }
}
