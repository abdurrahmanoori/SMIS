namespace SMIS.Api.Extensions
{
    public static class CorsServiceExtensions
    {
        public static IServiceCollection AddReactAppCors(
            this IServiceCollection services
        )
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowReactApp", policy =>
                {
                    policy.SetIsOriginAllowed(origin =>
                        Uri.TryCreate(origin, UriKind.Absolute, out var uri) &&
                        (uri.Host == "localhost" ||
                         (uri.Scheme == Uri.UriSchemeHttp &&
                          uri.Host.Equals("smis-flutter-web.runasp.net", StringComparison.OrdinalIgnoreCase))))
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials();
                });
            });

            return services;
        }
    }
}