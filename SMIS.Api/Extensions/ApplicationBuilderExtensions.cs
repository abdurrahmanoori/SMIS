namespace SMIS.Api.Extensions;

public static class ApplicationBuilderExtensions
{
    public static IApplicationBuilder UseSwaggerWithUI(this IApplicationBuilder app)
    {
        app.UseSwagger();
        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "SMIS API");
            options.InjectStylesheet("/swagger-ui/SwaggerDark.css");
        });

        return app;
    }
}
