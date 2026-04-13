namespace DUA.API.OpenApi;

public static class OpenApiExtensions
{
    public static IEndpointRouteBuilder MapOpenApiInfo(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/api/openapi/info", () => Results.Ok(new
        {
            Name = "DUA Streamliner API",
            Contract = "OpenAPI",
            Version = "v1"
        }));

        return endpoints;
    }
}
