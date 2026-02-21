using Microsoft.Extensions.Configuration;
using MediatR;
using SMIS.Application.Identity.IServices;
using SMIS.Infrastructure.Mobile.Extensions;
using SMIS.Infrastructure.Mobile.Services.Identity;
using SMIS.UI.Models;
using SMIS.UI.Services;
using SMIS.UI.Services.Auth;
using SMIS.UI.Services.Http;
using ApiClient = SMIS.UI.Services.Http.ApiClient;
using IApiClient = SMIS.UI.Services.Http.IApiClient;

namespace SMIS.UI.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddAppServices(this IServiceCollection services, IConfiguration configuration)
    {
        var appSettings = configuration.GetSection("AppSettings").Get<AppSettings>() ?? new AppSettings();

        // Mobile Infrastructure Layer (includes LocalDbContext, Repositories, Sync)
        var dbPath = Path.Combine(FileSystem.AppDataDirectory, "smis_local.db");
        services.AddMobileInfrastructure(dbPath);

        // MediatR for CQRS (shared Application layer handlers)
        services.AddMediatR(typeof(SMIS.Application.AssemblyReference).Assembly);

        // Current User - Map ILocalCurrentUser to ICurrentUser for Application layer
        services.AddSingleton<ICurrentUser>(sp => new MauiCurrentUserAdapter(sp.GetRequiredService<ILocalCurrentUser>()));

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

        return services;
    }
}
