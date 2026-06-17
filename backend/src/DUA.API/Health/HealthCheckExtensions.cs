namespace DUA.API.Health;

public static class HealthCheckExtensions
{
    public static IServiceCollection AddDuaHealthChecks(this IServiceCollection services)
    {
        services.AddHealthChecks();
        return services;
    }

    public static IEndpointRouteBuilder MapDuaHealthChecks(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapHealthChecks("/health");
        endpoints.MapHealthChecks("/health/ready");
        endpoints.MapHealthChecks("/health/live");
        return endpoints;
    }
}
