namespace DUA.Workers.Health;

public sealed class WorkerHealthProbe
{
    public DateTimeOffset StartedAtUtc { get; } = DateTimeOffset.UtcNow;
}
