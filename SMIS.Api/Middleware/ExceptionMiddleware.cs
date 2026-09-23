using SMIS.Application.Common.Exceptions;
using SMIS.Domain.Exceptions;
using System.Text.Json;
using Serilog;
using Microsoft.EntityFrameworkCore;

namespace SMIS.Api.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(
            RequestDelegate next
        )
        {
            _next = next;
        }

        public async Task InvokeAsync(
            HttpContext context
        )
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

        private static async Task HandleExceptionAsync(
            HttpContext context,
            Exception exception
        )
        {
            var hostEnvironment = context.RequestServices.GetRequiredService<IHostEnvironment>();

            var log = ExceptionLog.CreateLog(exception);
            context.Items[nameof(ExceptionLog)] = log;

            // Log the exception to Serilog
            Log.Error(exception, "Unhandled exception occurred. ExceptionId: {ExceptionId}", log.Id);

            context.Response.Clear();
            context.Response.StatusCode = exception switch
            {
                DomainValidationException => StatusCodes.Status400BadRequest,
                UnauthorizedAccessException => StatusCodes.Status401Unauthorized,
                DbUpdateConcurrencyException => StatusCodes.Status409Conflict,
                DbUpdateException dbEx when IsConstraintViolation(dbEx)
                    => StatusCodes.Status409Conflict,
                _ => StatusCodes.Status500InternalServerError
            };
            context.Response.ContentType = "application/json";

            var response = exception switch
            {
                DomainValidationException domainEx => JsonSerializer.Serialize(new
                {
                    Success = false,
                    Errors = new[] { new { Code = "DomainValidation", Description = domainEx.Message } }
                }),
                DbUpdateConcurrencyException => JsonSerializer.Serialize(new
                {
                    Success = false,
                    Errors = new[]
                    {
                        new
                        {
                            Code = "InventoryConcurrencyConflict",
                            Description =
                                "Inventory changed while this operation was being processed. Refresh the stock state and retry."
                        }
                    }
                }),
                DbUpdateException dbEx when IsConstraintViolation(dbEx) => JsonSerializer.Serialize(new
                {
                    Success = false,
                    Errors = new[]
                    {
                        new
                        {
                            Code = "DatabaseConstraintViolation",
                            Description =
                                "The operation conflicts with related or duplicate data. Resolve the related records and retry."
                        }
                    }
                }),
                _ => hostEnvironment.IsDevelopment()
                    ? JsonSerializer.Serialize(log, new JsonSerializerOptions { WriteIndented = true })
                    : JsonSerializer.Serialize(new
                    {
                        Message = "An unexpected error occurred.",
                        Exception = $"Please contact the administrator with id: {log.Id}"
                    })
            };

            await context.Response.WriteAsync(response);
        }

        private static bool IsConstraintViolation(
            DbUpdateException exception
        )
        {
            var message = exception.InnerException?.Message ?? exception.Message;
            return message.Contains("FOREIGN KEY constraint failed", StringComparison.OrdinalIgnoreCase)
                   || message.Contains("REFERENCE constraint", StringComparison.OrdinalIgnoreCase)
                   || message.Contains("UNIQUE constraint failed", StringComparison.OrdinalIgnoreCase)
                   || message.Contains("Cannot insert duplicate key", StringComparison.OrdinalIgnoreCase)
                   || message.Contains("duplicate key row", StringComparison.OrdinalIgnoreCase);
        }
    }
}