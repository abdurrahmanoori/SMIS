using SMIS.Infrastructure.Mobile.Context;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.Infra.M.Test.TestInfrastructure;

/// <summary>
/// Base for tests that need a real <see cref="LocalDbContext"/> backed by in-memory SQLite.
/// Mirrors <c>BaseIntegrationTest</c> from SMIS.Test.
/// </summary>
public abstract class BaseLocalDbTest : IClassFixture<LocalDbContextFactory>, IAsyncLifetime
{
    protected readonly LocalDbContextFactory DbFactory;
    protected readonly ITestOutputHelper Output;

    protected BaseLocalDbTest(LocalDbContextFactory dbFactory, ITestOutputHelper output)
    {
        DbFactory = dbFactory;
        Output = output;
    }

    /// <summary>Creates a fresh context for each test method.</summary>
    protected LocalDbContext CreateContext() => DbFactory.CreateContext();

    public virtual Task InitializeAsync() => Task.CompletedTask;
    public virtual Task DisposeAsync() => Task.CompletedTask;
}
