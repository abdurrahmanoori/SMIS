using SMIS.Api.Middleware;

namespace SMIS.Api.Extensions
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseExceptionLogging(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
            app.UseMiddleware<RequestResponseLoggingMiddleware>();
            app.UseMiddleware<LogEnrichmentMiddleware>();
            return app;
        }
    }
}