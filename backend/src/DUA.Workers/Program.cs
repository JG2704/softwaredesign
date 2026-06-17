using DUA.Workers.Consumers;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<DuaGenerationConsumerWorker>();

var host = builder.Build();
host.Run();
