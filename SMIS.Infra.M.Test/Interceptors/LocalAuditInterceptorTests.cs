using FluentAssertions;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Moq;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Mobile.Context;
using SMIS.Infrastructure.Mobile.Interceptors;
using SMIS.Infrastructure.Mobile.Services.Identity;
using Xunit;

namespace SMIS.Infra.M.Test.Interceptors;

public class LocalAuditInterceptorTests : IAsyncLifetime
{
    private SqliteConnection _connection = null!;
    private const string UserId = "test-user-1";

    private LocalDbContext CreateContext()
    {
        var currentUserMock = new Mock<IMobileCurrentUser>();
        currentUserMock.Setup(u => u.GetId()).Returns(UserId);

        var auditInterceptor = new LocalAuditInterceptor(currentUserMock.Object);

        var options = new DbContextOptionsBuilder<LocalDbContext>()
            .UseSqlite(_connection)
            .AddInterceptors(auditInterceptor)
            .Options;

        return new LocalDbContext(options);
    }

    public async Task InitializeAsync()
    {
        _connection = new SqliteConnection("DataSource=:memory:");
        _connection.Open();
        using var ctx = CreateContext();
        await ctx.Database.EnsureCreatedAsync();
    }

    public async Task DisposeAsync()
    {
        await _connection.CloseAsync();
        await _connection.DisposeAsync();
    }

    [Fact]
    public async Task SavingChanges_OnAdd_SetsCreatedByAndIsSyncedToServerFalse()
    {
        using var ctx = CreateContext();
        var category = Category.Create("Drinks", "shop-1");
        category.IsSyncedToServer = true; // interceptor should override this

        ctx.Categories.Add(category);
        await ctx.SaveChangesAsync();

        category.CreatedBy.Should().Be(UserId);
        category.CreatedDate.Should().NotBeNull();
        category.IsSyncedToServer.Should().BeFalse();
        category.LastModifiedUtc.Should().NotBe(default);
    }

    [Fact]
    public async Task SavingChanges_OnModify_SetsUpdatedByAndIsSyncedToServerFalse()
    {
        // Arrange — seed a synced category
        using var seedCtx = CreateContext();
        var category = Category.Create("Food", "shop-1");
        seedCtx.Categories.Add(category);
        await seedCtx.SaveChangesAsync();

        // Mark as synced so we can verify the interceptor resets it
        category.IsSyncedToServer = true;
        await seedCtx.SaveChangesAsync();

        // Act — real business change
        using var modifyCtx = CreateContext();
        var tracked = await modifyCtx.Categories.FindAsync(category.Id);
        tracked!.SetName("Food Updated");
        await modifyCtx.SaveChangesAsync();

        // Assert
        tracked.UpdatedBy.Should().Be(UserId);
        tracked.UpdatedDate.Should().NotBeNull();
        tracked.IsSyncedToServer.Should().BeFalse();
    }

    [Fact]
    public async Task SavingChanges_WhenOnlySyncFlagsModified_DoesNotResetIsSyncedToServer()
    {
        // Arrange — seed an unsynced category
        using var seedCtx = CreateContext();
        var category = Category.Create("Stationery", "shop-1");
        seedCtx.Categories.Add(category);
        await seedCtx.SaveChangesAsync();

        // Act — simulate sync service marking entity as synced (sync-only save)
        using var syncCtx = CreateContext();
        var tracked = await syncCtx.Categories.FindAsync(category.Id);
        tracked!.IsSyncedToServer = true;
        tracked.LastSyncedAt = DateTime.UtcNow;
        await syncCtx.SaveChangesAsync();

        // Assert — IsSyncedToServer must remain true; interceptor must not undo the sync result
        using var verifyCtx = CreateContext();
        var result = await verifyCtx.Categories.FindAsync(category.Id);
        result!.IsSyncedToServer.Should().BeTrue();
    }
}
