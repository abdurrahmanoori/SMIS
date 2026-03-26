using Microsoft.Extensions.DependencyInjection;
using SMIS.Application.Repositories.Base;
using SMIS.Infrastructure.Server.Repositories.Base;
using SMIS.Infrastructure.Server.RepositoryStores;

namespace SMIS.Infrastructure.Server.Configurations;

public static class RegisterRepositories
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        // Scrutor handles assembly scanning; retain generic base and UoW if directly referenced here
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<RepositoriesStore>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}
