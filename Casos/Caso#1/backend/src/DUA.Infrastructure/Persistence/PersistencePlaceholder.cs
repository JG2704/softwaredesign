namespace DUA.Infrastructure.Persistence;

public interface IDuaRepository
{
    Task SaveChangesAsync(CancellationToken cancellationToken);
}
