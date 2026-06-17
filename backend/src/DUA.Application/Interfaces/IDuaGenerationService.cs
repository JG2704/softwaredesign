namespace DUA.Application.Interfaces;

public interface IDuaGenerationService
{
    Task<Guid> EnqueueGenerationAsync(Guid userId, IReadOnlyCollection<Guid> documentIds, CancellationToken cancellationToken);
}
