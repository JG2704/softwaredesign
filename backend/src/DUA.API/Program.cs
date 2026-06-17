using DUA.API.Health;
using DUA.API.OpenApi;
using DUA.Application.UseCases;
using DUA.Infrastructure.Config;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDuaOpenApi();
builder.Services.AddDuaHealthChecks();
builder.Services.AddDuaInfrastructure();

builder.Services.AddScoped<UploadFilesToGenerateDua>();
builder.Services.AddScoped<GenerateDuaFromUploadedDocuments>();
builder.Services.AddScoped<SetupDuaTemplate>();
builder.Services.AddScoped<GetDuaHistory>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.MapDuaHealthChecks();

app.Run();
