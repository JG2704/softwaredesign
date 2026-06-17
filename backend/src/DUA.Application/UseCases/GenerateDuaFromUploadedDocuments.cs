using DUA.Application.DTOs;

namespace DUA.Application.UseCases;

public sealed class GenerateDuaFromUploadedDocuments
{
    public Task<GenerateDuaFromUploadedDocumentsResponse> ExecuteAsync(GenerateDuaFromUploadedDocumentsRequest request, CancellationToken cancellationToken)
    {
        var response = new GenerateDuaFromUploadedDocumentsResponse(Guid.NewGuid(), "Processing");
        return Task.FromResult(response);
    }
}
