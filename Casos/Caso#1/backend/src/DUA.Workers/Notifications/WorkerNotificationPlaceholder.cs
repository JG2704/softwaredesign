namespace DUA.Workers.Notifications;

public sealed class WorkerNotificationPlaceholder
{
    public Task SendAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
