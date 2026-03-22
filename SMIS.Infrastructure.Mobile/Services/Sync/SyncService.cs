using Microsoft.EntityFrameworkCore;
using SMIS.Application.DTO.Categories;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;
using SMIS.Infrastructure.Mobile.Context;
using SMIS.Infrastructure.Mobile.Services.Http;
using SMIS.Infrastructure.Mobile.Services.Identity;

namespace SMIS.Infrastructure.Mobile.Services.Sync;

public interface ISyncService
{
    Task<SyncResult> SyncAsync<TEntity, TCreateDto, TUpdateDto, TDto>(
        ISyncConfiguration<TEntity, TCreateDto, TUpdateDto, TDto> config)
        where TEntity : class, ISyncableEntity;
    Task<SyncResult> SyncCategoriesAsync();
    Task<SyncResult> PullCategoriesAsync();
    Task<SyncResult> SyncDeletesAsync();
    Task<SyncAllResult> SyncAllAsync();
    Task<int> GetPendingCountAsync<TEntity>() where TEntity : class, ISyncableEntity;
    Task<int> GetTotalPendingCountAsync();
}

public class SyncService : ISyncService
{
    private readonly LocalDbContext _localDb;
    private readonly IApiClient _apiClient;
    private readonly IConnectivity? _connectivity;
    private readonly IMobileCurrentUser _currentUser;
    private const string PullTimestampKeyPrefix = "category_pull_";

    public SyncService(LocalDbContext localDb, IApiClient apiClient, IMobileCurrentUser currentUser, IConnectivity? connectivity = null)
    {
        _localDb = localDb;
        _apiClient = apiClient;
        _currentUser = currentUser;
        _connectivity = connectivity;
    }

    public async Task<SyncResult> SyncAsync<TEntity, TCreateDto, TUpdateDto, TDto>(
        ISyncConfiguration<TEntity, TCreateDto, TUpdateDto, TDto> config)
        where TEntity : class, ISyncableEntity
    {
        if (_connectivity?.NetworkAccess != NetworkAccess.Internet)
            return new SyncResult { Success = false, Message = "No internet connection" };

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
            catch (HttpRequestException ex)
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

    public async Task<SyncResult> PullCategoriesAsync()
    {
        if (_connectivity?.NetworkAccess != NetworkAccess.Internet)
            return new SyncResult { Success = false, Message = "No internet connection" };

        var shopId = _currentUser.GetShopId();

        // Scope the timestamp key per shop so different shops on the same device
        // each maintain their own independent pull cursor.
        var timestampKey = $"{PullTimestampKeyPrefix}{shopId}";

        // Read the last successful pull time from device storage.
        // On the very first pull, DateTime.MinValue is used as fallback,
        // which tells the server "give me everything from the beginning".
        var lastPull = DateTime.Parse(
            Preferences.Get(timestampKey, DateTime.MinValue.ToString("o")),
            null,
            System.Globalization.DateTimeStyles.RoundtripKind);
        //var datee = lastPull.ToUniversalTime();
        var response = await _apiClient.GetAsync<List<CategoryDto>>(
            $"/api/Category/pull?changedSince={lastPull.ToUniversalTime():yyyy-MM-ddTHH:mm:ss}");

        if (!response.Success)
            return new SyncResult { Success = false, Message = response.Message ?? "Pull failed" };

        // Response.Response can be null if the server returned an empty body.
        // Falling back to an empty list keeps the rest of the logic uniform.
        var serverCategories = response.Response ?? new List<CategoryDto>();

        var upserted = 0;
        foreach (var dto in serverCategories)
        {
            // Check whether this server record already exists in the local DB.
            var local = await _localDb.Categories
                .FirstOrDefaultAsync(c => c.Id == dto.Id);

            if (local == null)
            {
                // This category does not exist locally — it was created by another
                // user on the same shop. Use the domain factory to respect all validation rules.
                var newCategory = Category.Create(dto.Name, dto.ShopId, dto.Code, dto.Description, dto.IsActive);
                newCategory.Id = dto.Id;
                newCategory.LastModifiedUtc = dto.LastModifiedUtc;
                newCategory.IsSyncedToServer = true;
                newCategory.LastSyncedAt = DateTimeService.UtcNow;

                await _localDb.Categories.AddAsync(newCategory);
                upserted++;
            }
            else if (dto.LastModifiedUtc > local.LastModifiedUtc)
            {
                // The record exists locally but the server version is newer.
                // This happens when another user on the same shop edited this category
                // after our last pull. Server wins — overwrite local with server data.
                local.SetName(dto.Name);
                local.SetCode(dto.Code);
                local.SetDescription(dto.Description);
                if (dto.IsActive) local.Activate(); else local.Deactivate();

                local.LastModifiedUtc = dto.LastModifiedUtc;
                local.IsSyncedToServer = true;
                local.LastSyncedAt = DateTimeService.UtcNow;
                upserted++;
            }
            // Local is newer than server — local wins, nothing to do here.
            // SyncCategoriesAsync (push) will upload the local version to the server
            // in the same sync cycle.
        }

        // Persist all inserts and updates in a single transaction.
        await _localDb.SaveChangesAsync();

        // Advance the pull cursor so the next pull only fetches changes after this moment.
        Preferences.Set(timestampKey, DateTimeService.UtcNow.ToString("o"));

        return new SyncResult
        {
            Success = true,
            Message = upserted == 0 ? "No new changes from server" : $"Pulled {upserted} category change(s) from server",
            SyncedCount = upserted
        };
    }

    public async Task<SyncResult> SyncCategoriesAsync()
    {
        return await SyncAsync(new CategorySyncConfiguration());
    }

    public async Task<SyncResult> SyncDeletesAsync()
    {
        if (_connectivity?.NetworkAccess != NetworkAccess.Internet)
            return new SyncResult { Success = false, Message = "No internet connection" };

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
        var entityPending = await _localDb.Set<SMIS.Domain.Entities.Category>()
            .CountAsync(e => !e.IsSyncedToServer);
        var deletePending = await _localDb.DeletedRecords
            .CountAsync(d => !d.IsSyncedToServer);
        return entityPending + deletePending;
    }

    public async Task<SyncAllResult> SyncAllAsync()
    {
        var results = new List<SyncResult>
        {
            await PullCategoriesAsync(),
            await SyncCategoriesAsync(),
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

public class SyncResult
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public int SyncedCount { get; set; }
    public int FailedCount { get; set; }
}

public class SyncAllResult
{
    public bool Success { get; set; }
    public List<SyncResult> Results { get; set; } = new();
    public int TotalSynced { get; set; }
    public int TotalFailed { get; set; }
}
