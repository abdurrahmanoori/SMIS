using Microsoft.AspNetCore.Hosting;
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
        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration configuration, IWebHostEnvironment environment)
        {
            services.AddDbContext<AppDbContext>((serviceProvider, options) =>
            {
                var rawConnection = configuration.GetConnectionString("DefaultConnection") ?? string.Empty;
    //            var dbPath = Path.Combine(
    //Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
    //"smis.db"
//);
                // Resolve relative "Data Source=..." paths against the API content root so the
                // db file is found correctly on any machine without hardcoded paths.
                var connectionString = ResolveConnectionString(rawConnection, environment.ContentRootPath);

                var interceptor = serviceProvider.GetRequiredService<AuditInterceptor>();
                var pkEntityInterceptor = serviceProvider.GetRequiredService<EntityPKInterceptor>();

                options.UseSqlite(connectionString)
                    //o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery))
                       .AddInterceptors(interceptor, pkEntityInterceptor);

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
