using DUA.Application.DTOs;

namespace DUA.Application.UseCases;

public sealed class GetDuaHistory
{
    public Task<IReadOnlyCollection<DuaHistoryItemResponse>> ExecuteAsync(GetDuaHistoryRequest request, CancellationToken cancellationToken)
    {
        IReadOnlyCollection<DuaHistoryItemResponse> response =
        [
            new DuaHistoryItemResponse(Guid.NewGuid(), "Completed", DateTimeOffset.UtcNow)
        ];

        return Task.FromResult(response);
    }
}
