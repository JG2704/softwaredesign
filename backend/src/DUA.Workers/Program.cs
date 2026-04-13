using DUA.Workers.Consumers;
using DUA.Workers.Health;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddHostedService<DuaGenerationQueueConsumer>();
builder.Services.AddSingleton<WorkerHealthProbe>();

var host = builder.Build();
host.Run();
