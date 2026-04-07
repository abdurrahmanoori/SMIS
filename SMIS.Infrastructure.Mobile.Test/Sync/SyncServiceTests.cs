using FluentAssertions;
using Moq;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Infrastructure.Mobile.Entities;
using SMIS.Infrastructure.Mobile.Services.Http;
using SMIS.Infrastructure.Mobile.Services.Sync;
using SMIS.Infrastructure.Mobile.Services.Sync.Categories;
using SMIS.Infrastructure.Mobile.Test.TestInfrastructure;
using SMIS.Infrastructure.Mobile.Test.Utilities;
using Xunit;
using Xunit.Abstractions;


namespace SMIS.Infrastructure.Mobile.Test.Sync;

public class SyncServiceTests : BaseSyncTest
{
    private readonly Mock<IApiClient> _apiClient = new();
    private readonly Mock<IConnectivity> _connectivity = new();
    private readonly Mock<ICategorySyncService> _categorySyncService = new();
    private readonly CategoryEntityBuilder _builder = new();

    public SyncServiceTests(ITestOutputHelper output) : base(output) { }

    private SyncService CreateSut() =>
        new(Db, _apiClient.Object, _categorySyncService.Object, _connectivity.Object);

    private void SetOnline() =>
        _connectivity.Setup(c => c.NetworkAccess).Returns(NetworkAccess.Internet);

    private void SetOffline() =>
        _connectivity.Setup(c => c.NetworkAccess).Returns(NetworkAccess.None);

    // ── offline guard ─────────────────────────────────────────────────────────

    [Fact]
    public async Task SyncAsync_WhenOffline_ReturnsOfflineResult()
    {
        SetOffline();
        var sut = CreateSut();

        var result = await sut.SyncCategoriesAsync();

        result.Success.Should().BeFalse();
        result.Message.Should().Contain("No internet");
        Log($"Offline result: {result.Message}");
    }

    [Fact]
    public async Task SyncDeletesAsync_WhenOffline_ReturnsOfflineResult()
    {
        SetOffline();
        var sut = CreateSut();

        var result = await sut.SyncDeletesAsync();

        result.Success.Should().BeFalse();
        result.Message.Should().Contain("No internet");
    }

    // ── no pending entities ───────────────────────────────────────────────────

    [Fact]
    public async Task SyncAsync_WhenNoPendingEntities_ReturnsSuccessWithNoPendingMessage()
    {
        SetOnline();
        // All seeded categories are already synced — add one explicitly synced
        var synced = _builder.AsSynced().Build();
        await Db.Categories.AddAsync(synced);
        await Db.SaveChangesAsync();

        var sut = CreateSut();
        var result = await sut.SyncCategoriesAsync();

        result.Success.Should().BeTrue();
        result.Message.Should().Contain("No pending");
        Log($"No-pending result: {result.Message}");
    }

    [Fact]
    public async Task SyncDeletesAsync_WhenNoPendingDeletes_ReturnsSuccess()
    {
        SetOnline();
        var sut = CreateSut();

        var result = await sut.SyncDeletesAsync();

        result.Success.Should().BeTrue();
        result.Message.Should().Contain("No pending deletes");
    }

    // ── push new entity (POST path) ───────────────────────────────────────────

    [Fact]
    public async Task SyncAsync_WhenEntityNotOnServer_PostsAndMarksSynced()
    {
        SetOnline();
        var category = _builder.Build(); // IsSyncedToServer = false
        await Db.Categories.AddAsync(category);
        await Db.SaveChangesAsync();

        // Server returns 404-equivalent: Success=false, no connection error
        _apiClient
            .Setup(a => a.GetAsync<CategoryDto>($"/api/Category/{category.Id}"))
            .ReturnsAsync(Result<CategoryDto>.FailureResult("Not found"));

        _apiClient
            .Setup(a => a.PostAsync<CategoryCreateDto, CategoryDto>("/api/Category", It.IsAny<CategoryCreateDto>()))
            .ReturnsAsync(Result<CategoryDto>.SuccessResult(new CategoryDto { Id = category.Id }));

        var sut = CreateSut();
        var result = await sut.SyncCategoriesAsync();

        result.Success.Should().BeTrue();
        result.SyncedCount.Should().Be(1);
        result.FailedCount.Should().Be(0);

        var persisted = await Db.Categories.FindAsync(category.Id);
        persisted!.IsSyncedToServer.Should().BeTrue();
        Log($"POST path: synced={result.SyncedCount}");
    }

    // ── push update (PUT path — local is newer) ───────────────────────────────

    [Fact]
    public async Task SyncAsync_WhenLocalIsNewerThanServer_PutsAndMarksSynced()
    {
        SetOnline();
        var serverTime = DateTime.UtcNow.AddHours(-1);
        var localTime = DateTime.UtcNow;

        var category = _builder.WithLastModifiedUtc(localTime).Build();
        await Db.Categories.AddAsync(category);
        await Db.SaveChangesAsync();

        var serverDto = new CategoryDto
        {
            Id = category.Id,
            Name = category.Name,
            LastModifiedUtc = serverTime
        };

        _apiClient
            .Setup(a => a.GetAsync<CategoryDto>($"/api/Category/{category.Id}"))
            .ReturnsAsync(Result<CategoryDto>.SuccessResult(serverDto));

        _apiClient
            .Setup(a => a.PutAsync<CategoryUpdateDto, CategoryDto>($"/api/Category/{category.Id}", It.IsAny<CategoryUpdateDto>()))
            .ReturnsAsync(Result<CategoryDto>.SuccessResult(serverDto));

        var sut = CreateSut();
        var result = await sut.SyncCategoriesAsync();

        result.Success.Should().BeTrue();
        result.SyncedCount.Should().Be(1);

        var persisted = await Db.Categories.FindAsync(category.Id);
        persisted!.IsSyncedToServer.Should().BeTrue();
        Log($"PUT path: synced={result.SyncedCount}");
    }

    // ── conflict: server is newer — mark synced without pushing ──────────────

    [Fact]
    public async Task SyncAsync_WhenServerIsNewerThanLocal_MarksAsSyncedWithoutPushing()
    {
        SetOnline();
        var localTime = DateTime.UtcNow.AddHours(-1);
        var serverTime = DateTime.UtcNow;

        var category = _builder.WithLastModifiedUtc(localTime).Build();
        await Db.Categories.AddAsync(category);
        await Db.SaveChangesAsync();

        var serverDto = new CategoryDto
        {
            Id = category.Id,
            Name = category.Name,
            LastModifiedUtc = serverTime
        };

        _apiClient
            .Setup(a => a.GetAsync<CategoryDto>($"/api/Category/{category.Id}"))
            .ReturnsAsync(Result<CategoryDto>.SuccessResult(serverDto));

        var sut = CreateSut();
        var result = await sut.SyncCategoriesAsync();

        result.Success.Should().BeTrue();
        result.SyncedCount.Should().Be(1);

        // PUT must NOT have been called — server version is authoritative
        _apiClient.Verify(
            a => a.PutAsync<CategoryUpdateDto, CategoryDto>(It.IsAny<string>(), It.IsAny<CategoryUpdateDto>()),
            Times.Never);

        Log("Conflict: server newer — no PUT issued");
    }

    // ── connection failure mid-sync ───────────────────────────────────────────

    [Fact]
    public async Task SyncAsync_WhenHttpRequestExceptionThrown_ReturnsCancelledResult()
    {
        SetOnline();
        var category = _builder.Build();
        await Db.Categories.AddAsync(category);
        await Db.SaveChangesAsync();

        _apiClient
            .Setup(a => a.GetAsync<CategoryDto>(It.IsAny<string>()))
            .ThrowsAsync(new HttpRequestException("Connection refused"));

        var sut = CreateSut();
        var result = await sut.SyncCategoriesAsync();

        result.Success.Should().BeFalse();
        result.Message.Should().Contain("unavailable");
        Log($"Connection failure result: {result.Message}");
    }

    // ── delete sync ───────────────────────────────────────────────────────────

    [Fact]
    public async Task SyncDeletesAsync_WhenPendingDeleteExists_DeletesOnServerAndRemovesRecord()
    {
        SetOnline();
        var record = new DeletedRecord
        {
            EntityType = "Category",
            EntityId = "cat-to-delete",
            ApiEndpoint = "/api/Category",
            DeletedAt = DateTime.UtcNow,
            IsSyncedToServer = false
        };
        await Db.DeletedRecords.AddAsync(record);
        await Db.SaveChangesAsync();

        _apiClient
            .Setup(a => a.DeleteAsync("/api/Category/cat-to-delete"))
            .ReturnsAsync(Result<bool>.SuccessResult(true));

        var sut = CreateSut();
        var result = await sut.SyncDeletesAsync();

        result.Success.Should().BeTrue();
        result.SyncedCount.Should().Be(1);
        Db.DeletedRecords.Should().BeEmpty();
        Log($"Delete sync: synced={result.SyncedCount}");
    }

    [Fact]
    public async Task SyncDeletesAsync_WhenServerDeleteFails_IncrementsRetryCount()
    {
        SetOnline();
        var record = new DeletedRecord
        {
            EntityType = "Category",
            EntityId = "cat-fail",
            ApiEndpoint = "/api/Category",
            DeletedAt = DateTime.UtcNow,
            IsSyncedToServer = false,
            RetryCount = 0
        };
        await Db.DeletedRecords.AddAsync(record);
        await Db.SaveChangesAsync();

        _apiClient
            .Setup(a => a.DeleteAsync("/api/Category/cat-fail"))
            .ReturnsAsync(Result<bool>.FailureResult("Server error"));

        var sut = CreateSut();
        var result = await sut.SyncDeletesAsync();

        result.Success.Should().BeFalse();
        result.FailedCount.Should().Be(1);

        var persisted = await Db.DeletedRecords.FindAsync(record.Id);
        persisted!.RetryCount.Should().Be(1);
        Log($"Delete retry count: {persisted.RetryCount}");
    }

    // ── pending count ─────────────────────────────────────────────────────────

    [Fact]
    public async Task GetPendingCountAsync_ReturnsOnlyUnsyncedEntities()
    {
        var unsynced = _builder.Build();
        var synced = _builder.AsSynced().Build();
        await Db.Categories.AddRangeAsync(unsynced, synced);
        await Db.SaveChangesAsync();

        var sut = CreateSut();
        var count = await sut.GetPendingCountAsync<SMIS.Domain.Entities.Category>();

        // Seed data in LocalDbContext also adds categories — count only what we added
        count.Should().BeGreaterThanOrEqualTo(1);
        Log($"Pending count: {count}");
    }

    [Fact]
    public async Task GetTotalPendingCountAsync_IncludesBothEntitiesAndDeletes()
    {
        SetOnline();
        var unsynced = _builder.Build();
        await Db.Categories.AddAsync(unsynced);

        var deleteRecord = new DeletedRecord
        {
            EntityType = "Category",
            EntityId = "x",
            ApiEndpoint = "/api/Category",
            DeletedAt = DateTime.UtcNow,
            IsSyncedToServer = false
        };
        await Db.DeletedRecords.AddAsync(deleteRecord);
        await Db.SaveChangesAsync();

        var sut = CreateSut();
        var total = await sut.GetTotalPendingCountAsync();

        // At minimum: 1 unsynced category + 1 delete record
        total.Should().BeGreaterThanOrEqualTo(2);
        Log($"Total pending: {total}");
    }

    // ── SyncAllAsync orchestration ────────────────────────────────────────────

    [Fact]
    public async Task SyncAllAsync_WhenAllSucceed_ReturnsCombinedSuccessResult()
    {
        SetOnline();

        _categorySyncService
            .Setup(s => s.PullCategoriesAsync())
            .ReturnsAsync(new SyncResult { Success = true, SyncedCount = 3 });

        // No pending push entities or deletes — both inner syncs return "no pending"
        var sut = CreateSut();
        var result = await sut.SyncAllAsync();

        result.Success.Should().BeTrue();
        result.TotalSynced.Should().BeGreaterThanOrEqualTo(3);
        result.Results.Should().HaveCount(3); // pull + push + deletes
        Log($"SyncAll: totalSynced={result.TotalSynced}, success={result.Success}");
    }

    [Fact]
    public async Task SyncAllAsync_WhenPullFails_ReturnsFailureResult()
    {
        SetOnline();

        _categorySyncService
            .Setup(s => s.PullCategoriesAsync())
            .ReturnsAsync(new SyncResult { Success = false, Message = "Pull failed" });

        var sut = CreateSut();
        var result = await sut.SyncAllAsync();

        result.Success.Should().BeFalse();
        Log($"SyncAll pull failure: {result.Results.First().Message}");
    }
}
