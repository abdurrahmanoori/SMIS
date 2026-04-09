using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SMIS.Domain.Common.Interfaces;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.Interceptors;

namespace SMIS.Infrastructure.Server.Extensions
{
    public static class DbContextExtensions
    {
        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration configuration, IWebHostEnvironment environment)
        {
            services.AddDbContext<AppDbContext>((serviceProvider, options) =>
            {
                var connectionString = configuration.GetConnectionString("DefaultConnection") ?? string.Empty;

                var interceptor = serviceProvider.GetRequiredService<AuditInterceptor>();
                var pkEntityInterceptor = serviceProvider.GetRequiredService<EntityPKInterceptor>();

                if (environment.IsProduction())
                {
                    // Production: SQL Server hosted on databaseasp.net
                    options.UseSqlServer(connectionString)
                           .AddInterceptors(interceptor, pkEntityInterceptor);
                }
                else
                {
                    // Development/Staging: SQL Server LocalDB
                    options.UseSqlServer(connectionString)
                           .AddInterceptors(interceptor, pkEntityInterceptor);
                }

                options.EnableSensitiveDataLogging(true);
            });

            return services;
        }

        // Converts a SQLite connection string with a relative Data Source path into an absolute one.
        private static string ResolveConnectionString(string connectionString, string basePath)
        {
            const string prefix = "Data Source=";
            var index = connectionString.IndexOf(prefix, StringComparison.OrdinalIgnoreCase);
            if (index < 0) return connectionString;

            var dataSource = connectionString[(index + prefix.Length)..].Trim();
            if (Path.IsPathRooted(dataSource)) return connectionString;

            var absolutePath = Path.GetFullPath(Path.Combine(basePath, dataSource));
            Directory.CreateDirectory(Path.GetDirectoryName(absolutePath)!);
            return connectionString[..index] + prefix + absolutePath;
        }
    }
}
