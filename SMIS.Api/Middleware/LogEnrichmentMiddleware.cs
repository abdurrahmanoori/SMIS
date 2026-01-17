using Serilog.Context;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Common.Exceptions;
using System.Text.Json;

namespace SMIS.Api.Middleware
{
    public class LogEnrichmentMiddleware
    {
        private readonly RequestDelegate _next;

        public LogEnrichmentMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var currentUser = context.RequestServices.GetService<ICurrentUser>();
            
            using (LogContext.PushProperty("ClientIP", context.Connection.RemoteIpAddress?.ToString()))
            using (LogContext.PushProperty("RequestScheme", context.Request?.Scheme))
            using (LogContext.PushProperty("RequestHost", context.Request?.Host.Value))
            using (LogContext.PushProperty("RequestPath", context.Request?.Path))
            using (LogContext.PushProperty("QueryString", context.Request?.QueryString.Value))
            using (LogContext.PushProperty("UserId", currentUser?.GetId()))
            {
                await _next(context);

                // Log request/response details for error responses
                if (context.Response.StatusCode >= 400)
                {
                    var endpoint = context.GetEndpoint()?.DisplayName ?? "Unknown";
                    using (LogContext.PushProperty("Endpoint", endpoint))
                    using (LogContext.PushProperty("StatusCode", context.Response.StatusCode))
                    {
                        if (context.Items.TryGetValue("RequestBody", out var requestBody) && 
                            !string.IsNullOrEmpty(requestBody?.ToString()))
                        {
                            LogContext.PushProperty("RequestBody", FormatJson(requestBody.ToString()));
                        }

                        if (context.Items.TryGetValue("ResponseBody", out var responseBody) && 
                            !string.IsNullOrEmpty(responseBody?.ToString()))
                        {
                            LogContext.PushProperty("ResponseBody", FormatJson(responseBody.ToString()));
                        }

                        if (context.Items.TryGetValue(nameof(ExceptionLog), out var exceptionLog))
                        {
                            LogContext.PushProperty("ExceptionId", ((ExceptionLog)exceptionLog!).Id);
                        }
                    }
                }
            }
        }

        private static string? FormatJson(string? content)
        {
            if (string.IsNullOrEmpty(content)) return content;
            
            try
            {
                var jsonElement = JsonSerializer.Deserialize<JsonElement>(content);
                return JsonSerializer.Serialize(jsonElement, new JsonSerializerOptions { WriteIndented = true });
            }
            catch
            {
                return content;
            }
        }
    }
}