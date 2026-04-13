using DUA.Application.DTOs;

namespace DUA.Application.UseCases;

public sealed class UploadFilesToGenerateDua
{
    public Task<UploadFilesToGenerateDuaResponse> ExecuteAsync(UploadFilesToGenerateDuaRequest request, CancellationToken cancellationToken)
    {
        var response = new UploadFilesToGenerateDuaResponse(Guid.NewGuid(), "Queued");
        return Task.FromResult(response);
    }
}
