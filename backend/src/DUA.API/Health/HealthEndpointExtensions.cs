namespace DUA.API.Health;

public static class HealthEndpointExtensions
{
    public static IEndpointRouteBuilder MapDuaHealthChecks(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapHealthChecks("/health/live");
        endpoints.MapHealthChecks("/health/ready");

        return endpoints;
    }
}
