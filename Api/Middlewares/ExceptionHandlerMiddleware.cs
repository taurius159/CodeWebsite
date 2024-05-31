using System.Net;

namespace api.Middlewares;
public class ExceptionHandlerMiddleware
{
    private readonly ILogger<ExceptionHandlerMiddleware> logger;
    private readonly RequestDelegate next;

    public ExceptionHandlerMiddleware(ILogger<ExceptionHandlerMiddleware> logger,
        RequestDelegate next)
    {
        this.logger = logger;
        this.next = next;
    }

    public async Task InvokeAsync(HttpContext httpContext)
    {
        try
        {
            await next(httpContext);
        }
        catch(Exception ex)
        {
            var errorId = Guid.NewGuid();

            // Log the exception
            logger.LogError(ex, $"{errorId} : {ex.Message}");

            // Return a Custom error response
            httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            httpContext.Response.ContentType = "application/json";

            var error = new 
            {
                Id = errorId,
                ErrorMessage = "Something went on the server side. Let me know by email taurius159@gmail.com if this causes you inconvenience as alerting for this issue has not been set up for this app."
            };

            await httpContext.Response.WriteAsJsonAsync(error);
        }
    }
}