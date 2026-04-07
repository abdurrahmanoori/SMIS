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

public class TombstoneInterceptorTests : IAsyncLifetime
{
    private SqliteConnection _connection = null!;

    private LocalDbContext CreateContext()
    {
        var currentUserMock = new Mock<IMobileCurrentUser>();
        currentUserMock.Setup(u => u.GetId()).Returns("user-1");

        // TombstoneInterceptor has no dependencies; LocalAuditInterceptor needed to satisfy SaveChanges
        var tombstone = new TombstoneInterceptor();
        var audit = new LocalAuditInterceptor(currentUserMock.Object);

        var options = new DbContextOptionsBuilder<LocalDbContext>()
            .UseSqlite(_connection)
            .AddInterceptors(audit, tombstone)
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
    public async Task Delete_SyncedEntity_WritesTombstoneRecord()
    {
        // Arrange — seed a category that has been synced to server
        using var seedCtx = CreateContext();
        var category = Category.Create("Drinks", "shop-1");
        seedCtx.Categories.Add(category);
        await seedCtx.SaveChangesAsync();

        // Mark as synced (simulate sync service result)
        category.IsSyncedToServer = true;
        category.LastSyncedAt = DateTime.UtcNow;
        await seedCtx.SaveChangesAsync();

        var categoryId = category.Id;

        // Act
        using var deleteCtx = CreateContext();
        var tracked = await deleteCtx.Categories.FindAsync(categoryId);
        deleteCtx.Categories.Remove(tracked!);
        await deleteCtx.SaveChangesAsync();

        // Assert — tombstone must exist
        using var verifyCtx = CreateContext();
        var tombstone = await verifyCtx.DeletedRecords
            .FirstOrDefaultAsync(d => d.EntityId == categoryId);

        tombstone.Should().NotBeNull();
        tombstone!.EntityType.Should().Be("Category");
        tombstone.ApiEndpoint.Should().Be("/api/Category");
        tombstone.IsSyncedToServer.Should().BeFalse();
    }

    [Fact]
    public async Task Delete_NeverSyncedEntity_DoesNotWriteTombstone()
    {
        // Arrange — seed a category that was never synced (IsSyncedToServer = false)
        using var seedCtx = CreateContext();
        var category = Category.Create("Food", "shop-1");
        seedCtx.Categories.Add(category);
        await seedCtx.SaveChangesAsync();

        // Confirm it is unsynced
        category.IsSyncedToServer.Should().BeFalse();
        var categoryId = category.Id;

        // Act
        using var deleteCtx = CreateContext();
        var tracked = await deleteCtx.Categories.FindAsync(categoryId);
        deleteCtx.Categories.Remove(tracked!);
        await deleteCtx.SaveChangesAsync();

        // Assert — no tombstone should be written
        using var verifyCtx = CreateContext();
        var tombstone = await verifyCtx.DeletedRecords
            .FirstOrDefaultAsync(d => d.EntityId == categoryId);

        tombstone.Should().BeNull();
    }
}
