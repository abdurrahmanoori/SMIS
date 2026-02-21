using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SMIS.Domain.Common.Interfaces;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.Interceptors;

namespace SMIS.Infrastructure.Server.Extensions
{
    public static class DbContextExtensions
    {
        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>((serviceProvider, options) =>
            {
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                var interceptor = serviceProvider.GetRequiredService<AuditInterceptor>();
                var pkEntityInterceptor = serviceProvider.GetRequiredService<EntityPKInterceptor>();

                options.UseSqlite(connectionString)
                    //o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery))
                       .AddInterceptors(interceptor, pkEntityInterceptor);

                options.EnableSensitiveDataLogging(true);
            });

            return services;
        }
    }
}
