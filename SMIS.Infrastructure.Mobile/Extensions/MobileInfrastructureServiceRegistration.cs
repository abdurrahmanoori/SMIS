using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SMIS.Application.Repositories.Categories;
using SMIS.Application.Services;
using SMIS.Infrastructure.Mobile.Context;
using SMIS.Infrastructure.Mobile.Interceptors;
using SMIS.Infrastructure.Mobile.Repositories;
using SMIS.Infrastructure.Mobile.Repositories.Categories;
using SMIS.Infrastructure.Mobile.Services;
using SMIS.Infrastructure.Mobile.Services.Auth;
using SMIS.Infrastructure.Mobile.Services.Http;
using SMIS.Infrastructure.Mobile.Services.Identity;
using SMIS.Infrastructure.Mobile.Services.Sync;

namespace SMIS.Infrastructure.Mobile.Extensions;

public static class MobileInfrastructureServiceRegistration
{
    public static IServiceCollection AddMobileInfrastructure(
        this IServiceCollection services,
        string apiBaseUrl,
        int timeoutSeconds = 30)
    {
        // Current User
        services.AddSingleton<IMobileCurrentUser, MobileCurrentUser>();
        services.AddSingleton<LocalAuditInterceptor>();
        services.AddSingleton<EntityPKInterceptor>();

        // Database - path will be determined at runtime by platform
        services.AddDbContext<LocalDbContext>((serviceProvider, options) =>
        {
            var auditInterceptor = serviceProvider.GetRequiredService<LocalAuditInterceptor>();
            var pkInterceptor = serviceProvider.GetRequiredService<EntityPKInterceptor>();
            var dbPath = GetDatabasePath();
            options.UseSqlite($"Data Source={dbPath}")
                   .AddInterceptors(auditInterceptor, pkInterceptor);
        });

        services.Scan(scan => scan
      .FromAssembliesOf(typeof(MobileInfrastructureServiceRegistration))
      .AddClasses(c => c.InNamespaces("SMIS.Infrastructure.Mobile.Repositories"))
      .AsImplementedInterfaces()
      .WithScopedLifetime());
        // Repositories
        services.AddScoped<ILocalUnitOfWork, LocalUnitOfWork>();
        //services.AddScoped<ICategoryRepository, LocalCategoryRepository>();

        // Domain Services (Mobile implementations)
        // Note: DateTimeService is static in Domain layer - no registration needed
        services.AddSingleton<IPublicIdGenerator, MobilePublicIdGenerator>();
        services.AddScoped<ITranslationService, MobileTranslationService>();

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

    private static string GetDatabasePath( )
    {
        var fileName = "smis_local.db";

#if ANDROID
        var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        return Path.Combine(path, fileName);
#elif IOS || MACCATALYST
        var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        var library = Path.Combine(path, "..", "Library");
        return Path.Combine(library, fileName);
#elif WINDOWS
        var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        return Path.Combine(path, fileName);
#else
        var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        return Path.Combine(path, fileName);
#endif
    }
}
