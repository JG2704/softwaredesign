using DUA.Application.DTOs;

namespace DUA.Application.UseCases;

public sealed class SetupDuaTemplate
{
    public Task<SetupDuaTemplateResponse> ExecuteAsync(SetupDuaTemplateRequest request, CancellationToken cancellationToken)
    {
        var response = new SetupDuaTemplateResponse(Guid.NewGuid(), true);
        return Task.FromResult(response);
    }
}
