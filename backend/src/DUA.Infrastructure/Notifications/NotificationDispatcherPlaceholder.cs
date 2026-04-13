namespace DUA.Infrastructure.Notifications;

public interface INotificationDispatcher
{
    Task NotifyAsync(string destination, string message, CancellationToken cancellationToken);
}
