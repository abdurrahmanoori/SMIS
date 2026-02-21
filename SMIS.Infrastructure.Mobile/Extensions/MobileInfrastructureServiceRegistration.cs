using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SMIS.Application.Repositories.Categories;
using SMIS.Infrastructure.Mobile.Context;
using SMIS.Infrastructure.Mobile.Interceptors;
using SMIS.Infrastructure.Mobile.Repositories;
using SMIS.Infrastructure.Mobile.Repositories.Categories;
using SMIS.Infrastructure.Mobile.Services.Identity;
using SMIS.Infrastructure.Mobile.Services.Sync;

namespace SMIS.Infrastructure.Mobile.Extensions;

public static class MobileInfrastructureServiceRegistration
{
    public static IServiceCollection AddMobileInfrastructure(this IServiceCollection services, string databasePath)
    {
        services.AddSingleton<ILocalCurrentUser, LocalCurrentUser>();
        services.AddSingleton<LocalAuditInterceptor>();
        
        services.AddDbContext<LocalDbContext>((serviceProvider, options) =>
        {
            var interceptor = serviceProvider.GetRequiredService<LocalAuditInterceptor>();
            options.UseSqlite($"Data Source={databasePath}")
                   .AddInterceptors(interceptor);
        });

        services.AddScoped<ILocalUnitOfWork, LocalUnitOfWork>();
        services.AddScoped<ICategoryRepository, LocalCategoryRepository>();
        services.AddScoped<ISyncService, SyncService>();

        return services;
    }
}
