using SMIS.Application.Common.Exceptions;
using System.Text.Json;
using Serilog;
using Microsoft.EntityFrameworkCore;

namespace SMIS.Api.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception exception)
            {
                await HandleExceptionAsync(context, exception);
            }
        }

        private static async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var hostEnvironment = context.RequestServices.GetRequiredService<IHostEnvironment>();
            
            var log = ExceptionLog.CreateLog(exception);
            context.Items[nameof(ExceptionLog)] = log;

            // Log the exception to Serilog
            Log.Error(exception, "Unhandled exception occurred. ExceptionId: {ExceptionId}", log.Id);

            context.Response.Clear();
            context.Response.StatusCode = exception switch
            {
                UnauthorizedAccessException => StatusCodes.Status401Unauthorized,
                DbUpdateException dbEx when dbEx.InnerException?.Message.Contains("FOREIGN KEY constraint failed") == true => StatusCodes.Status409Conflict,
                _ => StatusCodes.Status500InternalServerError
            };
            context.Response.ContentType = "application/json";

            var response = hostEnvironment.IsDevelopment()
                ? JsonSerializer.Serialize(log, new JsonSerializerOptions { WriteIndented = true })
                : JsonSerializer.Serialize(new
                {
                    Message = "An unexpected error occurred.",
                    Exception = $"Please contact the administrator with id: {log.Id}"
                });

            await context.Response.WriteAsync(response);
        }
    }
}