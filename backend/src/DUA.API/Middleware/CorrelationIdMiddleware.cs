namespace DUA.API.Middleware;

public sealed class CorrelationIdMiddleware
{
    private readonly RequestDelegate _next;

    public CorrelationIdMiddleware(RequestDelegate next) => _next = next;

    public Task InvokeAsync(HttpContext context) => _next(context);
}
