namespace DUA.Domain.Events;

public sealed record DuaGeneratedDomainEvent(Guid DuaJobId, Guid GeneratedDuaId, DateTimeOffset OccurredAtUtc);
