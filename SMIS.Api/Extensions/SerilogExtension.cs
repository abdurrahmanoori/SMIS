using Serilog;
using Serilog.Events;
using Serilog.Sinks.PeriodicBatching;
using SMIS.Infrastructure.Server.Logging;

namespace SMIS.Api.Extensions
{
    public static class SerilogExtension
    {
        public static WebApplicationBuilder AddSerilogService(this WebApplicationBuilder builder)
        {
            // DatabaseSink is wired here after the host is built so IServiceProvider is available.
            // We use a deferred sink pattern: the actual sink is created lazily on first use.
            builder.Host.UseSerilog((ctx, services, config) =>
            {
                var databaseSink = new DatabaseSink(services);
                var periodicSink = new PeriodicBatchingSink(databaseSink, new PeriodicBatchingSinkOptions
                {
                    BatchSizeLimit = 50,
                    Period = TimeSpan.FromSeconds(10)
                });

                // In production, only errors are persisted to the database to reduce noise and storage.
                // In development, warnings and above are also captured for easier debugging.
                var dbMinLevel = ctx.HostingEnvironment.IsProduction()
                    ? LogEventLevel.Error
                    : LogEventLevel.Warning;

                config
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
                    .WriteTo.Sink(periodicSink, restrictedToMinimumLevel: dbMinLevel);
            });

            return builder;
        }
    }
}
