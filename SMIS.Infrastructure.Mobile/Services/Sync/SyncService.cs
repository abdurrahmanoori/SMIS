using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Common.Interfaces;
using SMIS.Infrastructure.Mobile.Context;

namespace SMIS.Infrastructure.Mobile.Services.Sync;

public interface ISyncService
{
    Task<SyncResult> SyncAsync<TEntity, TCreateDto, TUpdateDto, TDto>(
        ISyncConfiguration<TEntity, TCreateDto, TUpdateDto, TDto> config)
        where TEntity : class, ISyncableEntity;
    Task<SyncResult> SyncCategoriesAsync();
    Task<SyncAllResult> SyncAllAsync();
}

public class SyncService : ISyncService
{
    private readonly LocalDbContext _localDb;
    private readonly IApiClient _apiClient;

    public SyncService(LocalDbContext localDb, IApiClient apiClient)
    {
        _localDb = localDb;
        _apiClient = apiClient;
    }

    public async Task<SyncResult> SyncAsync<TEntity, TCreateDto, TUpdateDto, TDto>(
        ISyncConfiguration<TEntity, TCreateDto, TUpdateDto, TDto> config)
        where TEntity : class, ISyncableEntity
    {
        var pendingEntities = await _localDb.Set<TEntity>()
            .Where(e => !e.IsSyncedToServer)
            .ToListAsync();

        if (!pendingEntities.Any())
            return new SyncResult { Success = true, Message = $"No pending {config.EntityName} to sync" };

        var synced = 0;
        var failed = 0;

        foreach (var entity in pendingEntities)
        {
            try
            {
                var existsOnServer = await _apiClient.GetAsync<TDto>($"{config.ApiEndpoint}/{entity.Id}");

                if (existsOnServer.Success && existsOnServer.Response != null)
                {
                    var serverDto = existsOnServer.Response as dynamic;
                    var serverTimestamp = (DateTimeOffset)serverDto.LastModifiedUtc;

                    if (entity.LastModifiedUtc > serverTimestamp)
                    {
                        var updateDto = config.MapToUpdateDto(entity);
                        var result = await _apiClient.PutAsync<TUpdateDto, TDto>(
                            $"{config.ApiEndpoint}/{entity.Id}", updateDto);

                        if (result.Success)
                        {
                            entity.IsSyncedToServer = true;
                            entity.LastSyncedAt = DateTime.UtcNow;
                            synced++;
                        }
                        else failed++;
                    }
                    else
                    {
                        entity.IsSyncedToServer = true;
                        entity.LastSyncedAt = DateTime.UtcNow;
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
                        entity.LastSyncedAt = DateTime.UtcNow;
                        synced++;
                    }
                    else failed++;
                }
            }
            catch
            {
                failed++;
            }
        }

        await _localDb.SaveChangesAsync();

        return new SyncResult
        {
            Success = failed == 0,
            Message = $"Synced {synced} {config.EntityName}(s), {failed} failed",
            SyncedCount = synced,
            FailedCount = failed
        };
    }

    public async Task<SyncResult> SyncCategoriesAsync()
    {
        return await SyncAsync(new CategorySyncConfiguration());
    }

    public async Task<SyncAllResult> SyncAllAsync()
    {
        var results = new List<SyncResult>
        {
            await SyncCategoriesAsync()
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

public interface IApiClient
{
    Task<ApiResponse<T>> GetAsync<T>(string endpoint);
    Task<ApiResponse<TResponse>> PostAsync<TRequest, TResponse>(string endpoint, TRequest data);
    Task<ApiResponse<TResponse>> PutAsync<TRequest, TResponse>(string endpoint, TRequest data);
}

public class ApiResponse<T>
{
    public bool Success { get; set; }
    public T? Response { get; set; }
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
