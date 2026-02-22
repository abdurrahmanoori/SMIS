using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SMIS.Application.Repositories.Categories;
using SMIS.Infrastructure.Mobile.Context;
using SMIS.Infrastructure.Mobile.Interceptors;
using SMIS.Infrastructure.Mobile.Repositories;
using SMIS.Infrastructure.Mobile.Repositories.Categories;
using SMIS.Infrastructure.Mobile.Services.Auth;
using SMIS.Infrastructure.Mobile.Services.Http;
using SMIS.Infrastructure.Mobile.Services.Identity;
using SMIS.Infrastructure.Mobile.Services.Sync;

namespace SMIS.Infrastructure.Mobile.Extensions;

public static class MobileInfrastructureServiceRegistration
{
    public static IServiceCollection AddMobileInfrastructure(
        this IServiceCollection services, 
        string databasePath,
        string apiBaseUrl,
        int timeoutSeconds = 30)
    {
        // Current User
        services.AddSingleton<IMobileCurrentUser, MobileCurrentUser>();
        services.AddSingleton<ILocalCurrentUser, LocalCurrentUser>();
        services.AddSingleton<LocalAuditInterceptor>();
        
        // Database
        services.AddDbContext<LocalDbContext>((serviceProvider, options) =>
        {
            var interceptor = serviceProvider.GetRequiredService<LocalAuditInterceptor>();
            options.UseSqlite($"Data Source={databasePath}")
                   .AddInterceptors(interceptor);
        });

        // Repositories
        services.AddScoped<ILocalUnitOfWork, LocalUnitOfWork>();
        services.AddScoped<ICategoryRepository, LocalCategoryRepository>();
        
        // Auth & HTTP
        services.AddSingleton<ITokenStorage, SecureTokenStorage>();
        services.AddTransient<AuthenticatedHttpMessageHandler>();
        
        services.AddHttpClient<IApiClient, ApiClient>(client =>
        {
            client.BaseAddress = new Uri(apiBaseUrl);
            client.Timeout = TimeSpan.FromSeconds(timeoutSeconds);
        })
        .AddHttpMessageHandler<AuthenticatedHttpMessageHandler>();
        
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<ISyncService, SyncService>();

        return services;
    }
}
