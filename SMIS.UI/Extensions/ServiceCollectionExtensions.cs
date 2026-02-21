using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Identity.IServices;
using SMIS.UI.Data;
using SMIS.UI.Data.Interceptors;
using SMIS.UI.Models;
using SMIS.UI.Services;
using SMIS.UI.Services.Auth;
using SMIS.UI.Services.Http;
using SMIS.UI.Services.Sync;

namespace SMIS.UI.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddAppServices(this IServiceCollection services, IConfiguration configuration)
    {
        var appSettings = configuration.GetSection("AppSettings").Get<AppSettings>() ?? new AppSettings();

        // Current User (MAUI-specific implementation)
        services.AddSingleton<ICurrentUser, MauiCurrentUser>();

        // Register Interceptor
        services.AddScoped<AuditInterceptor>();

        // Local Database
        services.AddDbContext<LocalDbContext>();

        // Connectivity
        services.AddSingleton(Connectivity.Current);

        // HTTP Client with authentication
        services.AddSingleton<ITokenStorage, SecureTokenStorage>();
        services.AddTransient<AuthenticatedHttpMessageHandler>();
        
        services.AddHttpClient<IApiClient, ApiClient>(client =>
        {
            client.BaseAddress = new Uri(appSettings.ApiBaseUrl);
            client.Timeout = TimeSpan.FromSeconds(appSettings.TimeoutSeconds);
        })
        .AddHttpMessageHandler<AuthenticatedHttpMessageHandler>();

        // Application Services
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<CategoryService>();
        services.AddScoped<SyncService>();

        return services;
    }
}
