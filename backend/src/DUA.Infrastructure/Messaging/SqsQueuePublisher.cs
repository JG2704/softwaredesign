using DUA.Application.Interfaces;

namespace DUA.Infrastructure.Messaging;

public sealed class SqsQueuePublisher : IQueuePublisher
{
    public Task PublishAsync<TMessage>(TMessage message, CancellationToken cancellationToken)
        => Task.CompletedTask;
}
