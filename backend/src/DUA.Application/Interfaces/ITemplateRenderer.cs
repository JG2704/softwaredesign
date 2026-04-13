namespace DUA.Application.Interfaces;

public interface ITemplateRenderer
{
    Task<string> RenderAsync(Guid templateId, object model, CancellationToken cancellationToken);
}
