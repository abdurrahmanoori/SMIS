using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Policy;
using SMIS.Api.Errors;
using SMIS.Application.Common.Response;

namespace SMIS.Api.Authorization;

/// <summary>
/// Formats failures produced by ASP.NET Core authorization without rewriting
/// application-level 401/403 responses returned by controllers.
/// </summary>
public sealed class ApiAuthorizationMiddlewareResultHandler : IAuthorizationMiddlewareResultHandler
{
    private readonly AuthorizationMiddlewareResultHandler _defaultHandler = new();
    private readonly IProblemDetailsService _problemDetailsService;

    public ApiAuthorizationMiddlewareResultHandler(
        IProblemDetailsService problemDetailsService
    )
    {
        _problemDetailsService = problemDetailsService;
    }

    public async Task HandleAsync(
        RequestDelegate next,
        HttpContext httpContext,
        AuthorizationPolicy policy,
        PolicyAuthorizationResult authorizeResult
    )
    {
        // Let the framework authenticate/challenge/forbid through the configured
        // scheme first, preserving JWT headers such as WWW-Authenticate.
        await _defaultHandler.HandleAsync(next, httpContext, policy, authorizeResult);

        if (!authorizeResult.Challenged && !authorizeResult.Forbidden)
            return;

        // Authentication schemes may have written their own response. Do not append
        // another JSON document, including when logging buffers Response.Body.
        if (httpContext.Response.HasStarted ||
            httpContext.Response.ContentLength is > 0 ||
            (httpContext.Response.Body.CanSeek && httpContext.Response.Body.Length > 0))
        {
            return;
        }

        var error = authorizeResult.Challenged
            ? Error.Unauthorized("auth.unauthorized", "Authentication is required to access this resource.")
            : Error.Forbidden("auth.forbidden", "You do not have permission to access this resource.");

        var problem = ApiProblemDetailsFactory.Create(httpContext, new[] { error });

        await _problemDetailsService.TryWriteAsync(new ProblemDetailsContext
        {
            HttpContext = httpContext,
            ProblemDetails = problem
        });
    }
}
