using DUA.Application.Interfaces;

namespace DUA.Infrastructure.TemplateRendering;

public sealed class TemplateRenderer : ITemplateRenderer
{
    public Task<string> RenderAsync(Guid templateId, object model, CancellationToken cancellationToken)
    {
        return Task.FromResult(string.Empty);
    }
}
