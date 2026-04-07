using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using SMIS.Infrastructure.Mobile.Context;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.Infrastructure.Mobile.Test.TestInfrastructure;

/// <summary>
/// Base for sync integration tests.
/// Spins up a real in-memory SQLite LocalDbContext per test so every test
/// runs against an isolated, schema-correct database — the same principle
/// used by CustomWebApplicationFactory in SMIS.Test.
/// </summary>
public abstract class BaseSyncTest : IAsyncLifetime
{
    // Keep the connection open for the lifetime of the test so the in-memory
    // database is not destroyed between DbContext operations.
    private readonly SqliteConnection _connection;
    protected readonly LocalDbContext Db;
    protected readonly ITestOutputHelper Output;

    protected BaseSyncTest(ITestOutputHelper output)
    {
        Output = output;

        _connection = new SqliteConnection("DataSource=:memory:");
        _connection.Open();

        var options = new DbContextOptionsBuilder<LocalDbContext>()
            .UseSqlite(_connection)
            .Options;

        Db = new LocalDbContext(options);
    }

    /// <summary>
    /// Ensures the schema is created before each test runs.
    /// Mirrors InitializeAsync in BaseIntegrationTest.
    /// </summary>
    public virtual async Task InitializeAsync()
        => await Db.Database.EnsureCreatedAsync();

    public virtual async Task DisposeAsync()
    {
        await Db.DisposeAsync();
        await _connection.DisposeAsync();
    }

    /// <summary>
    /// Logs a diagnostic message to the test output.
    /// Mirrors LogIfError in BaseIntegrationTest.
    /// </summary>
    protected void Log(string message) => Output.WriteLine(message);
}
