using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Scrutor;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Services;
using SMIS.Domain.Contracts;
using SMIS.Infrastructure.Server.ContractsImplementation;
using SMIS.Infrastructure.Server.Interceptors;
using SMIS.Infrastructure.Server.Repositories.Base;
using SMIS.Infrastructure.Server.Services;
using SMIS.Infrastructure.Server.Services.Identity;

namespace SMIS.Infrastructure.Server.Repositories
{
    internal sealed class NamespaceMarker
    {
    }
}

namespace SMIS.Infrastructure.Server.Extensions
{
    public static class InfrastructureServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(
            this IServiceCollection services,
            IConfiguration configuration,
            IWebHostEnvironment environment
        )
        {
            services.AddApplicationDbContext(configuration, environment);
            services.AddScoped<AuditInterceptor>();
            services.AddScoped<EntityPKInterceptor>();
            if (environment.IsProduction())
            {
                services.AddScoped<IPKGenerator, ProdPKGenerator>();
            }
            else
            {
                services.AddScoped<IPKGenerator, DevPKGenerator>();
            }

            services.AddScoped<ICurrentUser, CurrentUser>();
            services.AddScoped<ITokenGenerator, JwtTokenGenerator>();
            services.AddScoped<IPowerSyncTokenGenerator, PowerSyncTokenGenerator>();

            services.Scan(scan => scan
                .FromAssemblies(typeof(InfrastructureServicesRegistration).Assembly)
                .AddClasses(c => c.InNamespaces(
                    typeof(SMIS.Infrastructure.Server.Repositories.NamespaceMarker).Namespace!))
                .AsImplementedInterfaces()
                .WithScopedLifetime());

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IGenericQueryService, GenericQueryService>();
            services.AddSingleton<IPublicIdGenerator, PublicIdGenerator>();

            return services;
        }
    }
}
