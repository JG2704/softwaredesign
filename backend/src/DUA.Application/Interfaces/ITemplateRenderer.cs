namespace DUA.Application.Interfaces;

public interface ITemplateRenderer
{
    Task<string> RenderAsync(string templateName, object payload, CancellationToken cancellationToken);
}
