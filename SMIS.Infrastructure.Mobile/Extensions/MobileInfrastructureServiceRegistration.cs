using Microsoft.EntityFrameworkCore;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Services;
using SMIS.Infrastructure.Mobile.Context;
using SMIS.Infrastructure.Mobile.Interceptors;
using SMIS.Infrastructure.Mobile.Repositories;
using SMIS.Infrastructure.Mobile.Services;
using SMIS.Infrastructure.Mobile.Services.Auth;
using SMIS.Infrastructure.Mobile.Services.Http;
using SMIS.Infrastructure.Mobile.Services.Identity;
using SMIS.Infrastructure.Mobile.Services.Sync;
using SMIS.Infrastructure.Mobile.Services.Sync.Categories;

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
        services.AddSingleton<TombstoneInterceptor>();

        // Database - path will be determined at runtime by platform
        services.AddDbContext<LocalDbContext>((serviceProvider, options) =>
        {
            var syncInterceptor = serviceProvider.GetRequiredService<LocalAuditInterceptor>();
            var pkInterceptor = serviceProvider.GetRequiredService<EntityPKInterceptor>();
            var tombstoneInterceptor = serviceProvider.GetRequiredService<TombstoneInterceptor>();
            var dbPath = GetDatabasePath();
            options.UseSqlite($"Data Source={dbPath}")
                   .AddInterceptors(syncInterceptor, pkInterceptor, tombstoneInterceptor);
        });

        services.Scan(scan => scan
      .FromAssembliesOf(typeof(MobileInfrastructureServiceRegistration))
      .AddClasses(c => c.InNamespaces("SMIS.Infrastructure.Mobile.Repositories"))
      .AsImplementedInterfaces()
      .WithScopedLifetime());
        // Repositories
        services.AddScoped<IUnitOfWork, LocalUnitOfWork>();
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
        services.AddScoped<ICategorySyncService, CategorySyncService>();

        return services;
    }

    private static string GetDatabasePath()
    {
        var fileName = "smis_local.db";
        string path;

#if ANDROID
        path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
#elif IOS || MACCATALYST
        path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        path = Path.Combine(path, "..", "Library");
#elif WINDOWS
        path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
#else
        path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
#endif

        var fullPath = Path.Combine(path, fileName);
        System.Diagnostics.Debug.WriteLine($"Database path: {fullPath}");
        return fullPath;
    }
}
