using AutoMapper;
using AutoMapper.EquivalencyExpression;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Scrutor;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Mappings;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Services;
using SMIS.Domain.Contracts;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.ContractsImplementation;
using SMIS.Infrastructure.Server.Interceptors;
using SMIS.Infrastructure.Server.Repositories.Base;
using SMIS.Infrastructure.Server.Services;
using SMIS.Infrastructure.Server.Services.Identity;

namespace SMIS.Infrastructure.Server.Repositories
{
    internal sealed class NamespaceMarker { }
}

namespace SMIS.Infrastructure.Server.Extensions
{
    public static class InfrastructureServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(
            this IServiceCollection services,
            IConfiguration configuration,
            IWebHostEnvironment environment)
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

            // Register ICurrentUser for Web API (uses HttpContext)
            services.AddScoped<ICurrentUser, CurrentUser>();

            // Register JWT token generator — only the infrastructure layer knows about JWT
            services.AddScoped<ITokenGenerator, JwtTokenGenerator>();

            // Automatically register repositories with Scrutor (no magic strings)
            services.Scan(scan => scan
                .FromAssemblies(typeof(InfrastructureServicesRegistration).Assembly)
                    .AddClasses(c => c.InNamespaces(
                        typeof(SMIS.Infrastructure.Server.Repositories.NamespaceMarker).Namespace!))
                        .AsImplementedInterfaces()
                        .WithScopedLifetime());

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            // Register services
            services.AddScoped<ITranslationService, TranslationService>();
            services.AddScoped<IGenericQueryService, GenericQueryService>();
            services.AddSingleton<IPublicIdGenerator, PublicIdGenerator>();
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
