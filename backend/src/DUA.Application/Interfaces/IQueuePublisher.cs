namespace DUA.Application.Interfaces;

public interface IQueuePublisher
{
    Task PublishAsync<TMessage>(TMessage message, CancellationToken cancellationToken);
}
