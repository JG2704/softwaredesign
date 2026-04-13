namespace DUA.Workers.Consumers;

public sealed class DuaGenerationQueueConsumer : BackgroundService
{
    private readonly ILogger<DuaGenerationQueueConsumer> _logger;

    public DuaGenerationQueueConsumer(ILogger<DuaGenerationQueueConsumer> logger)
    {
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("DUA queue consumer heartbeat at: {Timestamp}", DateTimeOffset.UtcNow);
            await Task.Delay(TimeSpan.FromSeconds(15), stoppingToken);
        }
    }
}
