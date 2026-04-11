using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SMIS.Application.Identity.IServices;
using SMIS.Infrastructure.Server.Context;

namespace SMIS.Infrastructure.Server.Context;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var apiProjectPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..", "SMIS.Api"));

        // First pass: read base appsettings.json to get the "Environment" key
        var baseConfig = new ConfigurationBuilder()
            .SetBasePath(apiProjectPath)
            .AddJsonFile("appsettings.json")
            .Build();

        var environment = Environment.GetEnvironmentVariable("EF_ENVIRONMENT")
                       ?? baseConfig["Environment"]
                       ?? "Development";
        //throw new Exception(apiProjectPath);
        //throw new Exception(environment);
        // Second pass: layer the environment-specific file on top
        var configuration = new ConfigurationBuilder()
            .SetBasePath(apiProjectPath)
            .AddJsonFile("appsettings.json")
            .AddJsonFile($"appsettings.{environment}.json", optional: true)
            .Build();

        var connectionString = configuration.GetConnectionString("DefaultConnection")
            ?? throw new InvalidOperationException(
                $"Connection string 'DefaultConnection' not found in appsettings.{environment}.json");

        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseSqlServer(connectionString);

        // ICurrentUser is not available at design-time; null is safe here
        // since EF tooling only uses the DbContext for schema/migration purposes.
        return new AppDbContext(optionsBuilder.Options, null!);
    }
}
