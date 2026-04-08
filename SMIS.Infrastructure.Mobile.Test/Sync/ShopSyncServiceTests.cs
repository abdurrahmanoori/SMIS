using FluentAssertions;
using Moq;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Shops;
using SMIS.Domain.Enums;
using SMIS.Infrastructure.Mobile.Services.Http;
using SMIS.Infrastructure.Mobile.Services.Identity;
using SMIS.Infrastructure.Mobile.Services.Platform;
using SMIS.Infrastructure.Mobile.Services.Sync.Shops;
using SMIS.Infrastructure.Mobile.Test.TestInfrastructure;
using SMIS.Infrastructure.Mobile.Test.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.Infrastructure.Mobile.Test.Sync;

public class ShopSyncServiceTests : BaseSyncTest
{
    private readonly Mock<IApiClient> _apiClient = new();
    private readonly Mock<IConnectivity> _connectivity = new();
    private readonly Mock<IMobileCurrentUser> _currentUser = new();
    private readonly Mock<IPreferencesService> _preferences = new();
    private readonly ShopEntityBuilder _builder = new();

    public ShopSyncServiceTests(ITestOutputHelper output) : base(output)
    {
        // Default: authenticated user with a known shop
        _currentUser.Setup(u => u.GetShopId()).Returns("shop-1");

        // Default: preferences returns the epoch fallback so every test starts
        // with a clean pull cursor without hitting the real MAUI Preferences API.
        _preferences
            .Setup(p => p.Get(It.IsAny<string>(), It.IsAny<string>()))
            .Returns((string _, string def) => def);
    }

    /// <summary>
    /// Creates the ShopSyncService used in tests, injecting the test LocalDbContext
    /// and the configured mock dependencies.
    /// </summary>
    private ShopSyncService CreateSut() =>
        new(Db, _apiClient.Object, _currentUser.Object, _preferences.Object, _connectivity.Object);

    private void SetOnline() =>
        _connectivity.Setup(c => c.NetworkAccess).Returns(NetworkAccess.Internet);

    private void SetOffline() =>
        _connectivity.Setup(c => c.NetworkAccess).Returns(NetworkAccess.None);

    private void SetupPullResponse(List<ShopDto> items) =>
        _apiClient
            .Setup(a => a.GetAsync<List<ShopDto>>(It.Is<string>(s => s.Contains("/api/Shop/pull"))))
            .ReturnsAsync(Result<List<ShopDto>>.SuccessResult(items));

    // -- offline guard --

    [Fact]
    public async Task PullShopsAsync_WhenOffline_ReturnsOfflineResult()
    {
        SetOffline();
        var sut = CreateSut();
        var result = await sut.PullShopsAsync();
        result.Success.Should().BeFalse();
        result.Message.Should().Contain("No internet");
        Log($"Offline: {result.Message}");
    }

    // -- no changes from server --

    [Fact]
    public async Task PullShopsAsync_WhenServerReturnsEmptyList_ReturnsSuccessWithNoChanges()
    {
        SetOnline();
        SetupPullResponse([]);
        var sut = CreateSut();
        var result = await sut.PullShopsAsync();
        result.Success.Should().BeTrue();
        result.SyncedCount.Should().Be(0);
        result.Message.Should().Contain("No new changes");
        Log($"No changes: {result.Message}");
    }

    // -- insert new shop from server --

    [Fact]
    public async Task PullShopsAsync_WhenServerHasNewShop_InsertsLocally()
    {
        SetOnline();
        var serverDto = new ShopDto
        {
            Id = "server-shop-1",
            Name = "Main Store",
            ShopType = ShopType.RetailShop,
            Address = "Kabul Center",
            PhoneNumber = "0700000001",
            Email = "main@store.local",
            TaxNumber = "TAX001",
            IsActive = true,
            LastModifiedUtc = DateTime.UtcNow
        };
        SetupPullResponse([serverDto]);
        var sut = CreateSut();
        var result = await sut.PullShopsAsync();
        result.Success.Should().BeTrue();
        result.SyncedCount.Should().Be(1);
        var local = await Db.Shops.FindAsync("server-shop-1");
        local.Should().NotBeNull();
        local!.Name.Should().Be("Main Store");
        local.IsSyncedToServer.Should().BeTrue();
        Log($"Inserted: {local.Name}");
    }

    // -- server-wins update (server is newer) --

    [Fact]
    public async Task PullShopsAsync_WhenServerVersionIsNewer_OverwritesLocalData()
    {
        SetOnline();
        var localTime = DateTime.UtcNow.AddHours(-2);
        var serverTime = DateTime.UtcNow;
        var existing = _builder.WithName("Old Name").WithLastModifiedUtc(localTime).AsSynced().Build();
        await Db.Shops.AddAsync(existing);
        await Db.SaveChangesAsync();
        var serverDto = new ShopDto
        {
            Id = existing.Id,
            Name = "Updated Name",
            ShopType = ShopType.RetailShop,
            IsActive = true,
            LastModifiedUtc = serverTime
        };
        SetupPullResponse([serverDto]);
        var sut = CreateSut();
        var result = await sut.PullShopsAsync();
        result.Success.Should().BeTrue();
        result.SyncedCount.Should().Be(1);
        var updated = await Db.Shops.FindAsync(existing.Id);
        updated!.Name.Should().Be("Updated Name");
        Log($"Server-wins: name updated to '{updated.Name}'");
    }

    // -- local-wins (local is newer -- no overwrite) --

    [Fact]
    public async Task PullShopsAsync_WhenLocalVersionIsNewer_DoesNotOverwriteLocalData()
    {
        SetOnline();
        var localTime = DateTime.UtcNow;
        var serverTime = DateTime.UtcNow.AddHours(-2);
        var existing = _builder.WithName("Local Name").WithLastModifiedUtc(localTime).AsSynced().Build();
        await Db.Shops.AddAsync(existing);
        await Db.SaveChangesAsync();
        var serverDto = new ShopDto
        {
            Id = existing.Id,
            Name = "Server Name",
            ShopType = ShopType.RetailShop,
            IsActive = true,
            LastModifiedUtc = serverTime
        };
        SetupPullResponse([serverDto]);
        var sut = CreateSut();
        var result = await sut.PullShopsAsync();
        result.Success.Should().BeTrue();
        result.SyncedCount.Should().Be(0); // nothing upserted
        var unchanged = await Db.Shops.FindAsync(existing.Id);
        unchanged!.Name.Should().Be("Local Name");
        Log("Local-wins: name unchanged");
    }

    // -- server-deleted record --

    [Fact]
    public async Task PullShopsAsync_WhenServerMarksRecordDeleted_RemovesLocalRecord()
    {
        SetOnline();
        var existing = _builder.AsSynced().Build();
        await Db.Shops.AddAsync(existing);
        await Db.SaveChangesAsync();
        var serverDto = new ShopDto
        {
            Id = existing.Id,
            Name = existing.Name,
            ShopType = ShopType.RetailShop,
            IsDeleted = true,
            LastModifiedUtc = DateTime.UtcNow
        };
        SetupPullResponse([serverDto]);
        var sut = CreateSut();
        var result = await sut.PullShopsAsync();
        result.Success.Should().BeTrue();
        result.SyncedCount.Should().Be(1);
        var removed = await Db.Shops.FindAsync(existing.Id);
        removed.Should().BeNull();
        Log($"Server-deleted: local record removed for id={existing.Id}");
    }

    // -- server-deleted record that doesn't exist locally --

    [Fact]
    public async Task PullShopsAsync_WhenServerDeletesNonExistentLocal_SucceedsGracefully()
    {
        SetOnline();
        var serverDto = new ShopDto
        {
            Id = "ghost-id",
            Name = "Ghost",
            ShopType = ShopType.RetailShop,
            IsDeleted = true,
            LastModifiedUtc = DateTime.UtcNow
        };
        SetupPullResponse([serverDto]);
        var sut = CreateSut();
        var result = await sut.PullShopsAsync();
        result.Success.Should().BeTrue();
        result.SyncedCount.Should().Be(0); // nothing to remove
        Log("Ghost delete: no local record, no error");
    }

    // -- API failure --

    [Fact]
    public async Task PullShopsAsync_WhenApiReturnsFailure_ReturnsFailureResult()
    {
        SetOnline();
        _apiClient
            .Setup(a => a.GetAsync<List<ShopDto>>(It.IsAny<string>()))
            .ReturnsAsync(Result<List<ShopDto>>.FailureResult("Server error"));
        var sut = CreateSut();
        var result = await sut.PullShopsAsync();
        result.Success.Should().BeFalse();
        result.Message.Should().Contain("Pull failed");
        Log($"API failure: {result.Message}");
    }

    // -- multiple shops in one pull --

    [Fact]
    public async Task PullShopsAsync_WhenServerReturnsMultipleNewShops_InsertsAll()
    {
        SetOnline();
        var serverDtos = Enumerable.Range(1, 5).Select(i => new ShopDto
        {
            Id = $"server-shop-{i}",
            Name = $"Shop {i}",
            ShopType = ShopType.RetailShop,
            IsActive = true,
            LastModifiedUtc = DateTime.UtcNow
        }).ToList();
        SetupPullResponse(serverDtos);
        var sut = CreateSut();
        var result = await sut.PullShopsAsync();
        result.Success.Should().BeTrue();
        result.SyncedCount.Should().Be(5);
        Log($"Bulk insert: {result.SyncedCount} shops pulled");
    }
}
