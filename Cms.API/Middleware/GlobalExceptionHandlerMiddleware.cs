using Cms.Service.Exceptions;
using Cms.Service.Models;
using FluentValidation;

namespace Cms.API.Middleware;

public class GlobalExceptionHandlerMiddleware : IMiddleware
{
    private readonly IHostEnvironment _environment;
    private readonly ILogger<GlobalExceptionHandlerMiddleware> _logger;

    public GlobalExceptionHandlerMiddleware(
        IHostEnvironment environment,
        ILogger<GlobalExceptionHandlerMiddleware> logger)
    {
        _environment = environment;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (ValidationException ex)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = 400;

            var response = ApiResponseFactory.Error(
                title: "Validation Failed",
                status: 400,
                detail: ex.Message,
                messageCode: "VALIDATION_ERROR",
                errors: ex.Errors.ToDictionary(e => e.PropertyName, e => e.ErrorMessage),
                traceId: context.TraceIdentifier
            );

            await context.Response.WriteAsJsonAsync(response);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unhandled exception occurred while processing request {Path}",
                context.Request.Path);

            if (context.Response.HasStarted)
            {
                _logger.LogWarning("Response has already started, cannot write error response.");
                throw;
            }

            context.Response.ContentType = "application/json";

            var appEx = ex as AppException ?? new ServerException("An unexpected system error occurred.");
            context.Response.StatusCode = appEx.StatusCode;

            var response = ApiResponseFactory.Error(
                title: appEx.Title,
                status: appEx.StatusCode,
                detail: appEx.StatusCode >= 500 ? "An unexpected error occurred." : ex.Message,
                messageCode: appEx.MessageCode,
                errors: _environment.IsDevelopment() ? new { detail = ex.Message } : null,
                traceId: context.TraceIdentifier
            );

            await context.Response.WriteAsJsonAsync(response);
        }
    }
}
