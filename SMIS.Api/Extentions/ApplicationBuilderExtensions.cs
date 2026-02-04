namespace SMIS.Api.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseSwaggerWithUI(this IApplicationBuilder app, IHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyAPI");
                    c.InjectStylesheet("/swagger-ui/SwaggerDark.css");
                });
            }
            else
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyAPI");
                    c.InjectStylesheet("/swagger-ui/SwaggerDark.css");
                });

                // Uncomment if you have custom exception handling
                //app.UseMiddleware<ExceptionMiddleware>();
            }

            return app;
        }
    }
}
