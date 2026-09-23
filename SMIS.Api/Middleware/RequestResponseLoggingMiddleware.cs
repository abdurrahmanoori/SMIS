using System.Text;

namespace SMIS.Api.Middleware
{
    /// <summary>
    /// Captures request and response bodies for the later logging/enrichment middleware.
    /// Streams are rewound/restored so diagnostics do not consume data that MVC or the
    /// network response still needs to read.
    /// </summary>
    public class RequestResponseLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly string[] _skipPaths = { "/swagger", "/health", "/_framework" };

        public RequestResponseLoggingMiddleware(
            RequestDelegate next
        )
        {
            _next = next;
        }

        public async Task InvokeAsync(
            HttpContext context
        )
        {
            if (_skipPaths.Any(path => context.Request.Path.StartsWithSegments(path)))
            {
                await _next(context);
                return;
            }

            var requestBody = await CaptureRequestBody(context.Request);
            context.Items["RequestBody"] = requestBody;

            var originalResponseBodyStream = context.Response.Body;
            // ASP.NET response streams are write-only in the normal pipeline. Temporarily
            // buffer into memory so the body can be inspected after downstream middleware runs.
            using var responseBodyStream = new MemoryStream();
            context.Response.Body = responseBodyStream;

            try
            {
                await _next(context);

                var responseBody = await CaptureResponseBody(context.Response);
                context.Items["ResponseBody"] = responseBody;

                await responseBodyStream.CopyToAsync(originalResponseBodyStream);
            }
            finally
            {
                context.Response.Body = originalResponseBodyStream;
            }
        }

        private async Task<string> CaptureRequestBody(
            HttpRequest request
        )
        {
            if (!request.Body.CanSeek)
            {
                // EnableBuffering allows us to inspect the body and then rewind it for MVC.
                request.EnableBuffering();
            }

            request.Body.Position = 0;
            var body = await new StreamReader(request.Body).ReadToEndAsync();
            request.Body.Position = 0;

            return body;
        }

        private async Task<string> CaptureResponseBody(
            HttpResponse response
        )
        {
            response.Body.Seek(0, SeekOrigin.Begin);
            var body = await new StreamReader(response.Body).ReadToEndAsync();
            response.Body.Seek(0, SeekOrigin.Begin);

            return body;
        }
    }
}