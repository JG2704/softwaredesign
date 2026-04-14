namespace DUA.Workers.Consumers;

public sealed class DuaGenerationConsumerWorker(ILogger<DuaGenerationConsumerWorker> logger) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            logger.LogInformation("DUA worker heartbeat at {TimestampUtc}", DateTimeOffset.UtcNow);
            await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);
        }
    }
}
