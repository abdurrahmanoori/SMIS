using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common.Response;

namespace SMIS.Api.Errors;

public static class ApiProblemDetailsFactory
{
    // This stays in the API layer because ProblemDetails, HTTP status codes and the serialized
    // error shape are presentation/transport concerns. Application only exposes Error/ErrorType.
    public static ProblemDetails Create(
        HttpContext httpContext,
        IReadOnlyCollection<Error> errors,
        string? detail = null,
        int? statusOverride = null,
        string? titleOverride = null
    )
    {
        var normalizedErrors = errors.Count == 0
            ? new[] { Error.Failure("common.failure", "The request could not be completed.") }
            : errors.ToArray();

        var primaryType = normalizedErrors[0].Type;
        var status = statusOverride ?? GetStatusCode(primaryType);

        var problem = new ProblemDetails
        {
            Status = status,
            Title = titleOverride ?? GetTitle(primaryType),
            Detail = detail,
            Type = $"https://httpstatuses.com/{status}",
            Instance = httpContext.Request.Path
        };

        problem.Extensions["errors"] = normalizedErrors.Select(error => new ApiErrorDetails(
            error.Code,
            error.Property,
            error.Description,
            GetErrorTypeName(error.Type))).ToArray();
        problem.Extensions["traceId"] = httpContext.TraceIdentifier;

        return problem;
    }

    public static int GetStatusCode(
        ErrorType type
    ) => type switch
    {
        ErrorType.Validation => StatusCodes.Status400BadRequest,
        ErrorType.Unauthorized => StatusCodes.Status401Unauthorized,
        ErrorType.Forbidden => StatusCodes.Status403Forbidden,
        ErrorType.NotFound => StatusCodes.Status404NotFound,
        ErrorType.Conflict => StatusCodes.Status409Conflict,
        ErrorType.BusinessRule => StatusCodes.Status422UnprocessableEntity,
        ErrorType.Failure => StatusCodes.Status500InternalServerError,
        _ => StatusCodes.Status500InternalServerError
    };

    public static string GetTitle(
        ErrorType type
    ) => type switch
    {
        ErrorType.Validation => "Validation failed",
        ErrorType.Unauthorized => "Authentication required",
        ErrorType.Forbidden => "Access denied",
        ErrorType.NotFound => "Resource not found",
        ErrorType.Conflict => "Request conflict",
        ErrorType.BusinessRule => "Business rule violation",
        ErrorType.Failure => "Unexpected server error",
        _ => "Request failed"
    };

    private static string GetErrorTypeName(
        ErrorType type
    ) => type switch
    {
        ErrorType.Validation => "validation",
        ErrorType.NotFound => "notFound",
        ErrorType.Conflict => "conflict",
        ErrorType.Unauthorized => "unauthorized",
        ErrorType.Forbidden => "forbidden",
        ErrorType.BusinessRule => "businessRule",
        ErrorType.Failure => "failure",
        _ => "failure"
    };

    private sealed record ApiErrorDetails(
        string Code,
        string? Property,
        string Description,
        string Type
    );
}