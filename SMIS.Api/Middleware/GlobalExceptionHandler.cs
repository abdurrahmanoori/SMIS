using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using SMIS.Api.Errors;
using SMIS.Application.Common.Exceptions;
using SMIS.Application.Common.Response;
using SMIS.Domain.Exceptions;

namespace SMIS.Api.Middleware;

public sealed class GlobalExceptionHandler : IExceptionHandler
{
    private readonly IHostEnvironment _environment;
    private readonly IProblemDetailsService _problemDetailsService;
    private readonly ILogger<GlobalExceptionHandler> _logger;

    public GlobalExceptionHandler(
        IHostEnvironment environment,
        IProblemDetailsService problemDetailsService,
        ILogger<GlobalExceptionHandler> logger
    )
    {
        _environment = environment;
        _problemDetailsService = problemDetailsService;
        _logger = logger;
    }

    public async ValueTask<bool> TryHandleAsync(
        HttpContext httpContext,
        Exception exception,
        CancellationToken cancellationToken
    )
    {
        var exceptionLog = ExceptionLog.CreateLog(exception);
        httpContext.Items[nameof(ExceptionLog)] = exceptionLog;

        _logger.LogError(
            exception,
            "Unhandled exception occurred. ExceptionId: {ExceptionId}",
            exceptionLog.Id);

        var error = MapException(exception);
        var status = ApiProblemDetailsFactory.GetStatusCode(error.Type);
        var detail = status == StatusCodes.Status500InternalServerError && !_environment.IsDevelopment()
            ? "An unexpected error occurred."
            : exception.Message;

        var problem = ApiProblemDetailsFactory.Create(
            httpContext,
            new[] { error },
            detail);

        if (status == StatusCodes.Status500InternalServerError)
            problem.Extensions["exceptionId"] = exceptionLog.Id;

        httpContext.Response.StatusCode = status;

        return await _problemDetailsService.TryWriteAsync(new ProblemDetailsContext
        {
            HttpContext = httpContext,
            ProblemDetails = problem
        });
    }

    private static Error MapException(
        Exception exception
    ) => exception switch
    {
        DomainValidationException domainException =>
            Error.BusinessRule("domain.validation", domainException.Message),

        UnauthorizedAccessException unauthorizedException =>
            Error.Unauthorized("auth.unauthorized", unauthorizedException.Message),

        DbUpdateConcurrencyException =>
            Error.Conflict(
                "inventory.concurrency_conflict",
                "The data changed while this operation was being processed. Refresh and retry."),

        DbUpdateException dbUpdateException when IsConstraintViolation(dbUpdateException) =>
            Error.Conflict(
                "database.constraint_conflict",
                "The operation conflicts with related or duplicate data."),

        _ =>
            Error.Failure("common.unexpected", "An unexpected error occurred.")
    };

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