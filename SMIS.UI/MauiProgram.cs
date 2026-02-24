using Microsoft.Extensions.Logging;
using Syncfusion.Blazor;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using SMIS.UI.Extensions;
using SMIS.Infrastructure.Mobile.Context;
using Microsoft.EntityFrameworkCore;

namespace SMIS.UI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            // Configuration
            var assembly = Assembly.GetExecutingAssembly();
            using var stream = assembly.GetManifestResourceStream("SMIS.UI.appsettings.json");
            if (stream != null)
            {
                var config = new ConfigurationBuilder()
                    .AddJsonStream(stream)
                    .Build();
                builder.Configuration.AddConfiguration(config);
            }

            // Register application services (includes Mobile Infrastructure)
            builder.Services.AddAppServices(builder.Configuration);

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddSyncfusionBlazor();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            var app = builder.Build();

            // Apply migrations on startup - creates DB in platform-specific location
            using (var scope = app.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<LocalDbContext>();
                var dbPath = db.Database.GetConnectionString();
                System.Diagnostics.Debug.WriteLine($"[MAUI] Database location: {dbPath}");
                db.Database.Migrate();
                System.Diagnostics.Debug.WriteLine($"[MAUI] Database migrated successfully");
            }

            return app;
        }
    }
}
