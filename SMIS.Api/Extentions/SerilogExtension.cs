using Serilog;
using Serilog.Core;
using Serilog.Events;
using Serilog.Sinks.PeriodicBatching;
using SMIS.Infrastructure.Server.Logging;

namespace SMIS.Api.Extensions
{
    public static class SerilogExtension
    {
        public static WebApplicationBuilder AddSerilogService(this WebApplicationBuilder builder)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Information)
                .MinimumLevel.Override("Microsoft.AspNetCore.Routing", LogEventLevel.Warning)
                .MinimumLevel.Override("Microsoft.AspNetCore.Mvc.Infrastructure", LogEventLevel.Warning)
                .MinimumLevel.Override("Microsoft.AspNetCore.Hosting.Diagnostics", LogEventLevel.Warning)
                .MinimumLevel.Override("Microsoft.EntityFrameworkCore.Model", LogEventLevel.Error)
                .MinimumLevel.Override("Microsoft.EntityFrameworkCore.Model.Validation", LogEventLevel.Error)
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .WriteTo.Seq("http://localhost:5341")
                .CreateLogger();

            builder.Host.UseSerilog();
            return builder;
        }

        public static void AddDatabaseLogging(this IServiceCollection services)
        {
            services.AddSingleton<ILogEventSink>(provider =>
            {
                var databaseSink = new DatabaseSink(provider);
                return new PeriodicBatchingSink(databaseSink, new PeriodicBatchingSinkOptions
                {
                    BatchSizeLimit = 50,
                    Period = TimeSpan.FromSeconds(10)
                });
            });
        }
    }
}
