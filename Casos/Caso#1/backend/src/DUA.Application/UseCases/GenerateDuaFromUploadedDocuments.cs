using DUA.Application.DTOs;

namespace DUA.Application.UseCases;

public sealed class GenerateDuaFromUploadedDocuments
{
    public Task<GenerateDuaFromUploadedDocumentsResponse> ExecuteAsync(GenerateDuaFromUploadedDocumentsRequest request, CancellationToken cancellationToken)
    {
        return Task.FromResult(new GenerateDuaFromUploadedDocumentsResponse(Guid.Empty, "Queued"));
    }
}
