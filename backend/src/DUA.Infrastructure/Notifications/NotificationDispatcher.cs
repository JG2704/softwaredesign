namespace DUA.Infrastructure.Notifications;

public sealed class NotificationDispatcher
{
    public Task DispatchAsync(string message, CancellationToken cancellationToken) => Task.CompletedTask;
}
