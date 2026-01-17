namespace SMIS.Api.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseSwaggerWithUI(this IApplicationBuilder app, IHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            else
            {
                app.UseSwagger();
                app.UseSwaggerUI();

                // Uncomment if you have custom exception handling
                //app.UseMiddleware<ExceptionMiddleware>();
            }

            return app;
        }
    }
}
