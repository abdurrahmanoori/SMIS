using Microsoft.Extensions.Logging;
using Syncfusion.Blazor;
using Syncfusion.Licensing;

namespace SMIS.UI2
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            // Register Syncfusion license key
            SyncfusionLicenseProvider.RegisterLicense("YOUR_LICENSE_KEY_HERE");

            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

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
