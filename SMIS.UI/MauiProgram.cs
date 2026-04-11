using CommunityToolkit.Maui;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SMIS.Infrastructure.Mobile.Context;
using SMIS.UI.Extensions;
using Syncfusion.Blazor;
using Syncfusion.Licensing;
using System.Reflection;

namespace SMIS.UI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            // Configuration — load shared settings first, then project-specific overrides
            var assembly = Assembly.GetExecutingAssembly();

            using var sharedStream = assembly.GetManifestResourceStream("SMIS.UI.appsettings.shared.json");
            if (sharedStream != null)
            {
                var sharedConfig = new ConfigurationBuilder()
                    .AddJsonStream(sharedStream)
                    .Build();
                builder.Configuration.AddConfiguration(sharedConfig);
            }

            using var stream = assembly.GetManifestResourceStream("SMIS.UI.appsettings.json");
            if (stream != null)
            {
                var config = new ConfigurationBuilder()
                    .AddJsonStream(stream)
                    .Build();
                builder.Configuration.AddConfiguration(config);
            }

            // Solution-level appsettings.secrets.json (git-ignored) — embedded from solution root via LogicalName
            // Contains SyncfusionLicenseKey and any other shared secrets; overrides all previous config
            using var secretsStream = assembly.GetManifestResourceStream("SMIS.UI.appsettings.secrets.json");
            if (secretsStream != null)
            {
                var secretsConfig = new ConfigurationBuilder()
                    .AddJsonStream(secretsStream)
                    .Build();
                builder.Configuration.AddConfiguration(secretsConfig);
            }

            // Syncfusion license key loaded from solution-level appsettings.secrets.json (git-ignored)
            SyncfusionLicenseProvider.RegisterLicense(builder.Configuration["SyncfusionLicenseKey"]);

            // Register application services (includes Mobile Infrastructure)
            builder.Services.AddAppServices(builder.Configuration);

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddSyncfusionBlazor();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            var app = builder.Build();

            // Ensure database is created
            using (var scope = app.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<LocalDbContext>();
                var dbPath = db.Database.GetConnectionString();
                System.Diagnostics.Debug.WriteLine($"[MAUI] Database location: {dbPath}");
                //db.Database.EnsureCreated();
                db.Database.Migrate();
                System.Diagnostics.Debug.WriteLine($"[MAUI] Database created successfully");
            }

            return app;
        }
    }
}
