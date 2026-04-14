using DUA.Application.Interfaces;

namespace DUA.Infrastructure.TemplateRendering;

public sealed class TemplateRenderer : ITemplateRenderer
{
    public Task<string> RenderAsync(string templateName, object payload, CancellationToken cancellationToken)
        => Task.FromResult(string.Empty);
}
