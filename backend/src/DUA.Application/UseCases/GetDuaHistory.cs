using DUA.Application.DTOs;

namespace DUA.Application.UseCases;

public sealed class GetDuaHistory
{
    public Task<GetDuaHistoryResponse> ExecuteAsync(GetDuaHistoryRequest request, CancellationToken cancellationToken)
    {
        return Task.FromResult(new GetDuaHistoryResponse(request.UserId, Array.Empty<DuaHistoryItemDto>()));
    }
}
