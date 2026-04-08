using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Services;
using SMIS.Infrastructure.Mobile.Context;
using SMIS.Infrastructure.Mobile.Services.Http;
using SMIS.Infrastructure.Mobile.Services.Sync.Categories;
using SMIS.Infrastructure.Mobile.Services.Sync.Shops;

namespace SMIS.Infrastructure.Mobile.Services.Sync;

public interface ISyncEngine
{
    Task<SyncResult> SyncAsync<TEntity, TCreateDto, TUpdateDto, TDto>(
        ISyncConfiguration<TEntity, TCreateDto, TUpdateDto, TDto> config)
        where TEntity : class, ISyncableEntity;
}

public interface ISyncService : ISyncEngine
{
    Task<SyncResult> SyncDeletesAsync();
    Task<SyncResult> SyncCategoriesAsync();
    Task<SyncResult> SyncShopsAsync();
    Task<SyncAllResult> SyncAllAsync();
    Task<int> GetPendingCountAsync<TEntity>() where TEntity : class, ISyncableEntity;
    Task<int> GetTotalPendingCountAsync();
}

public class SyncService : ISyncService
{
    private readonly LocalDbContext _localDb;
    private readonly IApiClient _apiClient;
    private readonly IConnectivity? _connectivity;
    private readonly ICategorySyncService _categorySyncService;
    private readonly IShopSyncService _shopSyncService;

    public SyncService(
        LocalDbContext localDb,
        IApiClient apiClient,
        ICategorySyncService categorySyncService,
        IShopSyncService shopSyncService,
        IConnectivity? connectivity = null)
    {
        _localDb = localDb;
        _apiClient = apiClient;
        _categorySyncService = categorySyncService;
        _shopSyncService = shopSyncService;
        _connectivity = connectivity;
    }

    public async Task<SyncResult> SyncAsync<TEntity, TCreateDto, TUpdateDto, TDto>(
        ISyncConfiguration<TEntity, TCreateDto, TUpdateDto, TDto> config)
        where TEntity : class, ISyncableEntity
    {
        if (!ConnectivityGuard.IsConnected(_connectivity)) return ConnectivityGuard.OfflineResult();

        var pendingEntities = await _localDb.Set<TEntity>()
            .Where(e => !e.IsSyncedToServer)
            .ToListAsync();

        if (!pendingEntities.Any())
            return new SyncResult { Success = true, Message = $"No pending {config.EntityName} to sync" };

        var synced = 0;
        var failed = 0;
        var connectionFailed = false;

        foreach (var entity in pendingEntities)
        {
            if (connectionFailed) break;

            try
            {
                var existsOnServer = await _apiClient.GetAsync<TDto>($"{config.ApiEndpoint}/{entity.Id}");

                if (!existsOnServer.Success && existsOnServer.Errors?.Any(e => e.Code == "Error") == true)
                {
                    connectionFailed = true;
                    failed = pendingEntities.Count;
                    break;
                }

                if (existsOnServer.Success && existsOnServer.Response != null)
                {
                    var serverDto = existsOnServer.Response as dynamic;
                    var serverTimestamp = (DateTime)serverDto.LastModifiedUtc;

                    if (entity.LastModifiedUtc > serverTimestamp)
                    {
                        // Local is newer — push local version to server.
                        var updateDto = config.MapToUpdateDto(entity);
                        var result = await _apiClient.PutAsync<TUpdateDto, TDto>(
                            $"{config.ApiEndpoint}/{entity.Id}", updateDto);

                        if (result.Success)
                        {
                            entity.IsSyncedToServer = true;
                            entity.LastSyncedAt = DateTimeService.UtcNow;
                            await _localDb.SaveChangesAsync();
                            synced++;
                        }
                        else failed++;
                    }
                    else
                    {
                        // Server is newer or equal — this entity was already pushed by another
                        // path (e.g. another device) or clocks are in sync. Mark as synced locally
                        // without pushing to avoid overwriting a more recent server version.
                        // Pull will have already applied the server version in the same sync cycle.
                        entity.IsSyncedToServer = true;
                        entity.LastSyncedAt = DateTimeService.UtcNow;
                        await _localDb.SaveChangesAsync();
                        synced++;
                    }
                }
                else
                {
                    var createDto = config.MapToCreateDto(entity);
                    var result = await _apiClient.PostAsync<TCreateDto, TDto>(config.ApiEndpoint, createDto);

                    if (result.Success)
                    {
                        entity.IsSyncedToServer = true;
                        entity.LastSyncedAt = DateTimeService.UtcNow;
                        await _localDb.SaveChangesAsync();
                        synced++;
                    }
                    else failed++;
                }
            }
            catch (HttpRequestException)
            {
                connectionFailed = true;
                failed = pendingEntities.Count;
                break;
            }
            catch
            {
                failed++;
            }
        }

        if (connectionFailed)
        {
            return new SyncResult
            {
                Success = false,
                Message = "Server unavailable - sync cancelled",
                FailedCount = pendingEntities.Count
            };
        }

        return new SyncResult
        {
            Success = failed == 0,
            Message = $"Synced {synced} {config.EntityName}(s), {failed} failed",
            SyncedCount = synced,
            FailedCount = failed
        };
    }

    public async Task<SyncResult> SyncDeletesAsync()
    {
        if (!ConnectivityGuard.IsConnected(_connectivity))
            return ConnectivityGuard.OfflineResult();

        var pendingDeletes = await _localDb.DeletedRecords
            .Where(d => !d.IsSyncedToServer)
            .ToListAsync();

        if (!pendingDeletes.Any())
            return new SyncResult { Success = true, Message = "No pending deletes to sync" };

        var synced = 0;
        var failed = 0;
        var connectionFailed = false;

        foreach (var record in pendingDeletes)
        {
            if (connectionFailed) break;
            try
            {
                var result = await _apiClient.DeleteAsync($"{record.ApiEndpoint}/{record.EntityId}");

                if (result.Success)
                {
                    _localDb.DeletedRecords.Remove(record);
                    await _localDb.SaveChangesAsync();
                    synced++;
                }
                else
                {
                    record.RetryCount++;
                    await _localDb.SaveChangesAsync();
                    failed++;
                }
            }
            catch (HttpRequestException)
            {
                connectionFailed = true;
                failed = pendingDeletes.Count;
                break;
            }
            catch
            {
                record.RetryCount++;
                await _localDb.SaveChangesAsync();
                failed++;
            }
        }

        if (connectionFailed)
            return new SyncResult { Success = false, Message = "Server unavailable - delete sync cancelled", FailedCount = pendingDeletes.Count };

        return new SyncResult
        {
            Success = failed == 0,
            Message = $"Deleted {synced} record(s) on server, {failed} failed",
            SyncedCount = synced,
            FailedCount = failed
        };
    }

    public async Task<int> GetPendingCountAsync<TEntity>() where TEntity : class, ISyncableEntity
    {
        return await _localDb.Set<TEntity>()
            .CountAsync(e => !e.IsSyncedToServer);
    }

    public async Task<int> GetTotalPendingCountAsync()
    {
        var categoryPending = await GetPendingCountAsync<SMIS.Domain.Entities.Category>();
        var shopPending = await GetPendingCountAsync<SMIS.Domain.Entities.Shop>();
        var deletePending = await _localDb.DeletedRecords
            .CountAsync(d => !d.IsSyncedToServer);
        return categoryPending + shopPending + deletePending;
    }

    public Task<SyncResult> SyncCategoriesAsync()
        => SyncAsync(new CategorySyncConfiguration());

    public Task<SyncResult> SyncShopsAsync()
        => SyncAsync(new ShopSyncConfiguration());

    public async Task<SyncAllResult> SyncAllAsync()
    {
        var results = new List<SyncResult>
        {
            await _categorySyncService.PullCategoriesAsync(),
            await _shopSyncService.PullShopsAsync(),
            await SyncAsync(new CategorySyncConfiguration()),
            await SyncAsync(new ShopSyncConfiguration()),
            await SyncDeletesAsync()
        };

        return new SyncAllResult
        {
            Success = results.All(r => r.Success),
            Results = results,
            TotalSynced = results.Sum(r => r.SyncedCount),
            TotalFailed = results.Sum(r => r.FailedCount)
        };
    }
}

// SyncResult and SyncAllResult have been moved to SMIS.Application.Common.Response.SyncResult
