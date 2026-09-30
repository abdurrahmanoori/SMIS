using SMIS.Api.Errors;
using SMIS.Application.Common.Response;

namespace SMIS.Api.Middleware;

public sealed class AuthorizationProblemDetailsMiddleware
{
    private readonly RequestDelegate _next;

    public AuthorizationProblemDetailsMiddleware(
        RequestDelegate next
    )
    {
        _next = next;
    }

    public async Task InvokeAsync(
        HttpContext httpContext,
        IProblemDetailsService problemDetailsService
    )
    {
        await _next(httpContext);

        if (httpContext.Response.HasStarted)
            return;

        var status = httpContext.Response.StatusCode;
        if (status is not (StatusCodes.Status401Unauthorized or StatusCodes.Status403Forbidden))
            return;

        var unauthorized = status == StatusCodes.Status401Unauthorized;
        var error = unauthorized
            ? Error.Unauthorized("auth.unauthorized", "Authentication is required to access this resource.")
            : Error.Forbidden("auth.forbidden", "You do not have permission to access this resource.");

        var problem = ApiProblemDetailsFactory.Create(httpContext, new[] { error });

        await problemDetailsService.TryWriteAsync(new ProblemDetailsContext
        {
            HttpContext = httpContext,
            ProblemDetails = problem
        });
    }
}