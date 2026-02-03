namespace SMIS.Api.Middleware
{
    public class UnauthorizedMiddleware
    {
        private readonly RequestDelegate _next;

        public UnauthorizedMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            await _next(httpContext);

            if (httpContext.Response.StatusCode == 401)
            {
                httpContext.Response.ContentType = "application/json";
                var response = new
                {
                    Message = "Unauthorized access. Please check your credentials or login status.",
                    Error = "Authentication failed"
                };

                await httpContext.Response.WriteAsJsonAsync(response);
            }
        }
    }
}
