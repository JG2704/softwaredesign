using DUA.Application.DTOs;

namespace DUA.Application.UseCases;

public sealed class UploadFilesToGenerateDua
{
    public Task<UploadFilesToGenerateDuaResponse> ExecuteAsync(UploadFilesToGenerateDuaRequest request, CancellationToken cancellationToken)
    {
        return Task.FromResult(new UploadFilesToGenerateDuaResponse(Guid.Empty, Array.Empty<Guid>()));
    }
}
