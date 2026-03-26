using AutoMapper;
using Microsoft.Extensions.Configuration;
using MediatR;
using SMIS.Application.Extensions;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Mappings;
using SMIS.Domain.Services;
using SMIS.Infrastructure.Mobile.Extensions;
using SMIS.Infrastructure.Mobile.Services.Identity;
using SMIS.UI.Services;
using SMIS.UI.Shared.Services.Interfaces;

namespace SMIS.UI.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddAppServices(this IServiceCollection services, IConfiguration configuration)
    {
        var apiBaseUrl = configuration["AppSettings:ApiBaseUrl"] ?? "https://localhost:7216";
        var timeoutSeconds = int.Parse(configuration["AppSettings:TimeoutSeconds"] ?? "30");

#if DEBUG
        DateTimeService.UseUtc = false;
#else
        DateTimeService.UseUtc = true;
#endif

        // Infrastructure.Mobile - DbContext, Repositories, HTTP, Auth, Sync
        services.AddMobileInfrastructure(apiBaseUrl, timeoutSeconds);

        // Application Layer - MediatR, Validators, AutoMapper, Domain Services
        services.ConfigureApplicationServices();
        
        // AutoMapper
        services.AddAutoMapper(typeof(MappingProfile).Assembly);
        
        // Override ICurrentUser with mobile implementation
        services.AddSingleton<ICurrentUser>(sp => sp.GetRequiredService<IMobileCurrentUser>());
        
        // MAUI-specific services
        services.AddSingleton(Connectivity.Current);
        services.AddScoped<IUiAuthService, AuthServiceWrapper>();
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<ISyncFacade, SyncFacade>();
        services.AddSingleton<IThemeService, ThemeService>();
        services.AddScoped<DevelopmentAutoLoginService>();

        return services;
    }
}
