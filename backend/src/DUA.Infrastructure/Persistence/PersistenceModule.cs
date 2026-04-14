using Microsoft.Extensions.DependencyInjection;

namespace DUA.Infrastructure.Persistence;

public static class PersistenceModule
{
    public static IServiceCollection AddDuaPersistence(this IServiceCollection services) => services;
}
