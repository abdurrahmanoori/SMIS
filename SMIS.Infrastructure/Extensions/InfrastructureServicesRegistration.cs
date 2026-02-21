using AutoMapper;
using AutoMapper.EquivalencyExpression;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Scrutor;
using SMIS.Application.Mappings;
using SMIS.Application.Services;
using SMIS.Domain.Contracts;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.ContractsImplementation;
using SMIS.Infrastructure.Server.Interceptors;
using SMIS.Infrastructure.Server.Services;

// Plan (pseudocode):
// - Add internal marker types in the target namespaces to avoid magic strings.
// - Use typeof(NamespaceMarker).Namespace to get the namespace string.
// - Use Scrutor .InNamespaces(...) instead of .InNamespacesOf.
// - Keep the rest of the registrations unchanged.

namespace SMIS.Infrastructure.Server.Repositories
{
    internal sealed class NamespaceMarker { }
}

namespace SMIS.Infrastructure.Server.RepositoryStores
{
    internal sealed class NamespaceMarker { }
}

namespace SMIS.Infrastructure.Server.Extensions
{
    public static class InfrastructureServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration, IWebHostEnvironment environment)
        {
            services.AddApplicationDbContext(configuration);
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


            // Automatically register repositories with Scrutor (no magic strings)
            services.Scan(scan => scan
                .FromAssemblies(typeof(InfrastructureServicesRegistration).Assembly)
                    .AddClasses(c => c.InNamespaces(
                        typeof(SMIS.Infrastructure.Server.Repositories.NamespaceMarker).Namespace!,
                        typeof(SMIS.Infrastructure.Server.RepositoryStores.NamespaceMarker).Namespace!))
                        .AsImplementedInterfaces()
                        .WithScopedLifetime());

            // Preserve explicit registrations for generic base and UoW
            services.AddScoped(typeof(SMIS.Application.Repositories.Base.IGenericRepository<>), typeof(SMIS.Infrastructure.Server.Repositories.Base.GenericRepository<>));
            services.AddScoped<SMIS.Infrastructure.Server.RepositoryStores.RepositoriesStore>();
            services.AddScoped<SMIS.Application.Repositories.Base.IUnitOfWork, SMIS.Infrastructure.Server.Repositories.Base.UnitOfWork>();

            // Register services
            services.AddScoped<ITranslationService, TranslationService>();
            services.AddSingleton<IPublicIdGenerator, SMIS.Infrastructure.Server.Services.PublicIdGenerator>();
            services.AddSingleton<IDateTimeService, DateTimeService>();

            services.AddAutoMapper((serviceProvider, cfg) =>
            {
                cfg.AddCollectionMappers();
                cfg.UseEntityFrameworkCoreModel<AppDbContext>(serviceProvider);
            },
              typeof(MappingProfile).Assembly);

            return services;
        }
    }
}
