using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using SMIS.Infrastructure.Mobile.Context;
using Xunit;

namespace SMIS.Infra.M.Test.TestInfrastructure;

/// <summary>
/// Shared fixture that spins up an in-memory SQLite <see cref="LocalDbContext"/>
/// for the duration of a test class, then tears it down cleanly.
/// Mirrors the CustomWebApplicationFactory pattern used in SMIS.Test.
/// </summary>
public class LocalDbContextFactory : IAsyncLifetime
{
    private SqliteConnection? _connection;

    public LocalDbContext CreateContext()
    {
        if (_connection == null)
            throw new InvalidOperationException("Call InitializeAsync before creating a context.");

        var options = new DbContextOptionsBuilder<LocalDbContext>()
            .UseSqlite(_connection)
            .Options;

        return new LocalDbContext(options);
    }

    public async Task InitializeAsync()
    {
        _connection = new SqliteConnection("DataSource=:memory:");
        _connection.Open();

        // Create schema once; all test contexts share the same connection/schema.
        using var ctx = CreateContext();
        await ctx.Database.EnsureCreatedAsync();
    }

    public async Task DisposeAsync()
    {
        if (_connection != null)
        {
            await _connection.CloseAsync();
            await _connection.DisposeAsync();
            _connection = null;
        }
    }
}
