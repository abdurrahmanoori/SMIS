using Microsoft.Extensions.DependencyInjection;
using SMIS.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using SMIS.Infrastructure.Interceptors;
using Microsoft.Extensions.Configuration;

namespace SMIS.Infrastructure.Extensions
{
    public static class DbContextExtensions
    {
        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>((serviceProvider, options) =>
            {
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                var interceptor = serviceProvider.GetRequiredService<AuditInterceptor>();

                options.UseSqlite(connectionString,
                    o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery))
                       .AddInterceptors(interceptor);

                options.EnableSensitiveDataLogging(true);
            });

            return services;
        }
    }
}
