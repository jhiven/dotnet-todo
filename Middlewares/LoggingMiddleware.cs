namespace Todo.Middlewares;

public class LoggingMiddleware(RequestDelegate next, ILoggerFactory logger)
{
    private readonly RequestDelegate _next = next;
    private readonly ILogger _logger = logger.CreateLogger<LoggingMiddleware>();

    public async Task InvokeAsync(HttpContext context)
    {
        _logger.LogInformation($"Request: {context.Request.Method} {context.Request.Path}");

        await _next(context);

        _logger.LogInformation($"Response: {context.Response.StatusCode}");
    }
}