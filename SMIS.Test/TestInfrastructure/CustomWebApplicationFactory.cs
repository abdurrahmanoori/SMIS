using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.Interceptors;
using System.Text.Json;
using System.Text.Json.Serialization;
using Xunit;

namespace SMIS.Test.TestInfrastructure;
public class CustomWebApplicationFactory : WebApplicationFactory<Program>, IAsyncLifetime
{
    private SqliteConnection? _connection;

    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        // Use Testing environment so PublicIdGenerator generates GUIDs (not sequential IDs)
        builder.UseEnvironment("Testing");

        builder.ConfigureAppConfiguration((context, config) =>
        {
            // Override the Environment config key so PublicIdGenerator picks up Testing
            config.AddInMemoryCollection(new Dictionary<string, string?>
            {
                ["Environment"] = "Testing"
            });
        });

        builder.ConfigureServices(services =>
        {
            // Remove the production provider and its options callback before
            // registering SQLite. Leaving the callback behind registers both
            // SQL Server and SQLite in the same EF service provider.
            services.RemoveAll<AppDbContext>();
            services.RemoveAll<DbContextOptions<AppDbContext>>();
            services.RemoveAll<IDbContextOptionsConfiguration<AppDbContext>>();

            // Create new connection for each test
            _connection = new SqliteConnection("DataSource=:memory:");
            _connection.Open();

            services.AddSingleton(_connection);
            services.AddDbContext<AppDbContext>((sp, options) =>
            {
                options.UseSqlite(_connection)
                    .AddInterceptors(
                        sp.GetRequiredService<AuditInterceptor>(),
                        sp.GetRequiredService<EntityPKInterceptor>());
            });

            services.ConfigureHttpJsonOptions(options =>
            {
                options.SerializerOptions.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
            });

            services.Configure<Microsoft.AspNetCore.Mvc.JsonOptions>(options =>
            {
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
            });

            // Build service provider and create schema
            var sp = services.BuildServiceProvider();
            using var scope = sp.CreateScope();
            var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            db.Database.EnsureCreated();
        });

    }

    public async Task InitializeAsync( )
    {
        // Optional: Seed base test data here
        using var scope = Services.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        await db.Database.EnsureCreatedAsync();
    }

    public new async Task DisposeAsync( )
    {
        if (_connection != null)
        {
            await _connection.CloseAsync();
            await _connection.DisposeAsync();
            _connection = null;
        }
    }
}
