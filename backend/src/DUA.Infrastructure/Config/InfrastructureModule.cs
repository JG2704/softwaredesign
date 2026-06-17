using Microsoft.Extensions.DependencyInjection;

using DUA.Application.Interfaces;
using DUA.Infrastructure.Messaging;
using DUA.Infrastructure.OCR;
using DUA.Infrastructure.SemanticExtraction;
using DUA.Infrastructure.Storage;
using DUA.Infrastructure.TemplateRendering;

namespace DUA.Infrastructure.Config;

public static class InfrastructureModule
{
    public static IServiceCollection AddDuaInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IFileStorageService, S3FileStorageService>();
        services.AddScoped<IQueuePublisher, SqsQueuePublisher>();
        services.AddScoped<IOcrService, OcrService>();
        services.AddScoped<ISemanticExtractionService, SemanticExtractionService>();
        services.AddScoped<ITemplateRenderer, TemplateRenderer>();
        return services;
    }
}
