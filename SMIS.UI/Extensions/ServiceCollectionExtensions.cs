using Microsoft.Extensions.Configuration;
using MediatR;
using SMIS.Application.Identity.IServices;
using SMIS.Infrastructure.Mobile.Extensions;
using SMIS.Infrastructure.Mobile.Services.Identity;
using SMIS.UI.Services;

namespace SMIS.UI.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddAppServices(this IServiceCollection services, IConfiguration configuration)
    {
        var apiBaseUrl = configuration["AppSettings:ApiBaseUrl"] ?? "https://localhost:7216";
        var timeoutSeconds = int.Parse(configuration["AppSettings:TimeoutSeconds"] ?? "30");

        var dbPath = Path.Combine(FileSystem.AppDataDirectory, "smis_local.db");
        services.AddMobileInfrastructure(dbPath, apiBaseUrl, timeoutSeconds);

        services.AddMediatR(typeof(SMIS.Application.AssemblyReference).Assembly);
        services.AddSingleton<ICurrentUser>(sp => sp.GetRequiredService<IMobileCurrentUser>());
        services.AddSingleton(Connectivity.Current);

        services.AddScoped<AuthServiceWrapper>();
        services.AddScoped<CategoryService>();

        return services;
    }
}
