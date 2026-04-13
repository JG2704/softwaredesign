using DUA.Application.DTOs;

namespace DUA.Application.UseCases;

public sealed class SetupDuaTemplate
{
    public Task<SetupDuaTemplateResponse> ExecuteAsync(SetupDuaTemplateRequest request, CancellationToken cancellationToken)
    {
        return Task.FromResult(new SetupDuaTemplateResponse(Guid.Empty, request.Name, request.Version));
    }
}
