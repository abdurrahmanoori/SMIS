using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SMIS.Infrastructure.Mobile.Context;
using SMIS.UI.Extensions;
using Syncfusion.Blazor;
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

            // Ensure database is created (without migrations for now)
            using (var scope = app.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<LocalDbContext>();
                var dbPath = db.Database.GetConnectionString();
                System.Diagnostics.Debug.WriteLine($"[MAUI] Database location: {dbPath}");
                db.Database.EnsureCreated();
                System.Diagnostics.Debug.WriteLine($"[MAUI] Database created successfully");

                //#if DEBUG
                //                _ = Task.Run(async () =>
                //                {
                //                    var autoLogin = scope.ServiceProvider.GetRequiredService<DevelopmentAutoLoginService>();
                //                    var loginSuccess = await autoLogin.TryAutoLoginAsync();
                //                    System.Diagnostics.Debug.WriteLine($"[MAUI] Auto-login: {(loginSuccess ? "Success" : "Failed")}");
                //                });
                //#endif

            }

            return app;
        }
    }
}
