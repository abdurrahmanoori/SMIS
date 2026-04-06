using FluentAssertions;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Moq;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Mobile.Context;
using SMIS.Infrastructure.Mobile.Entities;
using SMIS.Infrastructure.Mobile.Services.Http;
using SMIS.Infrastructure.Mobile.Services.Sync;
using SMIS.Infrastructure.Mobile.Services.Sync.Categories;
using Xunit;

namespace SMIS.Infra.M.Test.Services;

public class SyncServiceTests : IAsyncLifetime
{
    private SqliteConnection _connection = null!;
    private readonly Mock<IApiClient> _apiClientMock = new();
    private readonly Mock<IConnectivity> _connectivityMock = new();
    private readonly Mock<ICategorySyncService> _categorySyncMock = new();

    private LocalDbContext CreateDbContext()
    {
        var options = new DbContextOptionsBuilder<LocalDbContext>()
            .UseSqlite(_connection)
            .Options;
        return new LocalDbContext(options);
    }

    private SyncService CreateSut(LocalDbContext ctx) =>
        new SyncService(ctx, _apiClientMock.Object, _categorySyncMock.Object, _connectivityMock.Object);

    private void SetOnline() =>
        _connectivityMock.Setup(c => c.NetworkAccess).Returns(NetworkAccess.Internet);

    private void SetOffline() =>
        _connectivityMock.Setup(c => c.NetworkAccess).Returns(NetworkAccess.None);

    public async Task InitializeAsync()
    {
        _connection = new SqliteConnection("DataSource=:memory:");
        _connection.Open();
        using var ctx = CreateDbContext();
        await ctx.Database.EnsureCreatedAsync();
    }

    public async Task DisposeAsync()
    {
        await _connection.CloseAsync();
        await _connection.DisposeAsync();
    }

    // ── SyncAsync (push) ──────────────────────────────────────────────────────

    [Fact]
    public async Task SyncAsync_WhenOffline_ReturnsOfflineResult()
    {
        SetOffline();
        using var ctx = CreateDbContext();
        var sut = CreateSut(ctx);

        var result = await sut.SyncCategoriesAsync();

        result.Success.Should().BeFalse();
        result.Message.Should().Contain("No internet");
    }

    [Fact]
    public async Task SyncAsync_NoPendingEntities_ReturnsSuccessWithZeroCounts()
    {
        SetOnline();
        using var ctx = CreateDbContext();
        // Ensure all seeded categories are marked synced
        await ctx.Categories.ForEachAsync(c => c.IsSyncedToServer = true);
        await ctx.SaveChangesAsync();

        var sut = CreateSut(ctx);
        var result = await sut.SyncCategoriesAsync();

        result.Success.Should().BeTrue();
        result.SyncedCount.Should().Be(0);
    }

    [Fact]
    public async Task SyncAsync_PendingNewEntity_PostsToServerAndMarksSynced()
    {
        SetOnline();

        // Seed an unsynced category (no server record yet)
        using var seedCtx = CreateDbContext();
        var category = Category.Create("Drinks", "shop-1");
        category.IsSyncedToServer = false;
        seedCtx.Categories.Add(category);
        await seedCtx.SaveChangesAsync();

        // Server returns 404 (entity does not exist on server) → POST path
        _apiClientMock
            .Setup(a => a.GetAsync<CategoryDto>(It.IsAny<string>()))
            .ReturnsAsync(Result<CategoryDto>.FailureResult("NotFound", "Resource not found."));

        _apiClientMock
            .Setup(a => a.PostAsync<CategoryCreateDto, CategoryDto>(It.IsAny<string>(), It.IsAny<CategoryCreateDto>()))
            .ReturnsAsync(Result<CategoryDto>.SuccessResult(new CategoryDto { Id = category.Id, Name = "Drinks" }));

        using var syncCtx = CreateDbContext();
        var sut = CreateSut(syncCtx);
        var result = await sut.SyncCategoriesAsync();

        result.Success.Should().BeTrue();
        result.SyncedCount.Should().Be(1);
        result.FailedCount.Should().Be(0);
    }

    [Fact]
    public async Task SyncAsync_ApiPostFails_IncrementsFailedCount()
    {
        SetOnline();

        using var seedCtx = CreateDbContext();
        var category = Category.Create("Food", "shop-1");
        category.IsSyncedToServer = false;
        seedCtx.Categories.Add(category);
        await seedCtx.SaveChangesAsync();

        _apiClientMock
            .Setup(a => a.GetAsync<CategoryDto>(It.IsAny<string>()))
            .ReturnsAsync(Result<CategoryDto>.FailureResult("NotFound", "Resource not found."));

        _apiClientMock
            .Setup(a => a.PostAsync<CategoryCreateDto, CategoryDto>(It.IsAny<string>(), It.IsAny<CategoryCreateDto>()))
            .ReturnsAsync(Result<CategoryDto>.FailureResult("Error", "Server error"));

        using var syncCtx = CreateDbContext();
        var sut = CreateSut(syncCtx);
        var result = await sut.SyncCategoriesAsync();

        result.Success.Should().BeFalse();
        result.FailedCount.Should().BeGreaterThan(0);
    }

    // ── SyncDeletesAsync ──────────────────────────────────────────────────────

    [Fact]
    public async Task SyncDeletesAsync_WhenOffline_ReturnsOfflineResult()
    {
        SetOffline();
        using var ctx = CreateDbContext();
        var sut = CreateSut(ctx);

        var result = await sut.SyncDeletesAsync();

        result.Success.Should().BeFalse();
        result.Message.Should().Contain("No internet");
    }

    [Fact]
    public async Task SyncDeletesAsync_NoPendingDeletes_ReturnsSuccessWithZeroCounts()
    {
        SetOnline();
        using var ctx = CreateDbContext();
        var sut = CreateSut(ctx);

        var result = await sut.SyncDeletesAsync();

        result.Success.Should().BeTrue();
        result.SyncedCount.Should().Be(0);
    }

    [Fact]
    public async Task SyncDeletesAsync_PendingDelete_CallsApiDeleteAndRemovesTombstone()
    {
        SetOnline();

        using var seedCtx = CreateDbContext();
        seedCtx.DeletedRecords.Add(new DeletedRecord
        {
            EntityType = "Category",
            EntityId = "cat-1",
            ApiEndpoint = "/api/Category",
            DeletedAt = DateTime.UtcNow,
            IsSyncedToServer = false
        });
        await seedCtx.SaveChangesAsync();

        _apiClientMock
            .Setup(a => a.DeleteAsync(It.IsAny<string>()))
            .ReturnsAsync(Result<bool>.SuccessResult(true));

        using var syncCtx = CreateDbContext();
        var sut = CreateSut(syncCtx);
        var result = await sut.SyncDeletesAsync();

        result.Success.Should().BeTrue();
        result.SyncedCount.Should().Be(1);

        using var verifyCtx = CreateDbContext();
        verifyCtx.DeletedRecords.Should().BeEmpty();
    }

    // ── GetPendingCountAsync ──────────────────────────────────────────────────

    [Fact]
    public async Task GetPendingCountAsync_ReturnsCorrectCount()
    {
        using var seedCtx = CreateDbContext();
        var cat = Category.Create("Pending", "shop-1");
        cat.IsSyncedToServer = false;
        seedCtx.Categories.Add(cat);
        await seedCtx.SaveChangesAsync();

        using var ctx = CreateDbContext();
        var sut = CreateSut(ctx);

        var count = await sut.GetPendingCountAsync<Category>();

        count.Should().BeGreaterThanOrEqualTo(1);
    }
}
