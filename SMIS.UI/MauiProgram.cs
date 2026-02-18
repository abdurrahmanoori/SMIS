using Microsoft.Extensions.Logging;
using Syncfusion.Blazor;
using SMIS.UI.Models;
using SMIS.UI.Services.Auth;
using SMIS.UI.Services.Http;
using SMIS.UI.Data;
using SMIS.UI.Services;
using SMIS.UI.Services.Sync;
using System.Reflection;
using Microsoft.Extensions.Configuration;

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

            var appSettings = builder.Configuration.GetSection("AppSettings").Get<AppSettings>() ?? new AppSettings();

            // Local Database
            builder.Services.AddDbContext<LocalDbContext>();

            // Connectivity
            builder.Services.AddSingleton(Connectivity.Current);

            // HTTP Client with authentication
            builder.Services.AddSingleton<ITokenStorage, SecureTokenStorage>();
            builder.Services.AddTransient<AuthenticatedHttpMessageHandler>();
            
            builder.Services.AddHttpClient<IApiClient, ApiClient>(client =>
            {
                client.BaseAddress = new Uri(appSettings.ApiBaseUrl);
                client.Timeout = TimeSpan.FromSeconds(appSettings.TimeoutSeconds);
            })
            .AddHttpMessageHandler<AuthenticatedHttpMessageHandler>();

            // Services
            builder.Services.AddScoped<IAuthService, AuthService>();
            builder.Services.AddScoped<CategoryService>();
            builder.Services.AddScoped<SyncService>();

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddSyncfusionBlazor();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
