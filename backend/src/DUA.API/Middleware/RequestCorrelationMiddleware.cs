namespace DUA.API.Middleware;

public sealed class RequestCorrelationMiddleware
{
    private readonly RequestDelegate _next;

    public RequestCorrelationMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public Task InvokeAsync(HttpContext context)
    {
        context.Response.Headers.TryAdd("X-Correlation-Id", context.TraceIdentifier);
        return _next(context);
    }
}
