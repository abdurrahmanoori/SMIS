using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;
using SMIS.Infrastructure.Mobile.Context;
using SMIS.Infrastructure.Mobile.Services.Http;
using SMIS.Infrastructure.Mobile.Services.Identity;
using SMIS.Infrastructure.Mobile.Services.Sync;

namespace SMIS.Infrastructure.Mobile.Services.Sync.Categories;

public interface ICategorySyncService
{
    Task<SyncResult> PullCategoriesAsync();
}

public class CategorySyncService : ICategorySyncService
{
    private readonly LocalDbContext _localDb;
    private readonly IApiClient _apiClient;
    private readonly IConnectivity? _connectivity;
    private readonly IMobileCurrentUser _currentUser;

    // Scope the timestamp key per shop so different shops on the same device
    // each maintain their own independent pull cursor.
    private const string PullTimestampKeyPrefix = "category_pull_";

    public CategorySyncService(
        LocalDbContext localDb,
        IApiClient apiClient,
        IMobileCurrentUser currentUser,
        IConnectivity? connectivity = null)
    {
        _localDb = localDb;
        _apiClient = apiClient;
        _currentUser = currentUser;
        _connectivity = connectivity;
    }

    public async Task<SyncResult> PullCategoriesAsync()
    {
        if (!ConnectivityGuard.IsConnected(_connectivity))
            return ConnectivityGuard.OfflineResult();

        var shopId = _currentUser.GetShopId();
        var timestampKey = $"{PullTimestampKeyPrefix}{shopId}";

        // Read the last successful pull time from device storage.
        // On the very first pull, DateTime.MinValue is used as fallback,
        // which tells the server "give me everything from the beginning".
        var lastPull = DateTime.Parse(
            Preferences.Get(timestampKey, DateTime.MinValue.ToString("yyyy-MM-ddTHH:mm:ss")));
        var response = await _apiClient.GetAsync<List<CategoryDto>>(
            $"/api/Category/pull?changedSince={lastPull:yyyy-MM-ddTHH:mm:ss}");
        /*
            var lastPull = DateTime.Parse(
            Preferences.Get(timestampKey, DateTime.MinValue.ToString("o")),
            null, System.Globalization.DateTimeStyles.RoundtripKind);
            var response = await _apiClient.GetAsync<List<CategoryDto>>(
            $"/api/Category/pull?changedSince={lastPull:o}");
         */
        if (!response.Success)
            return new SyncResult { Success = false, Message = response.Message ?? "Pull failed" };

        // Response.Response can be null if the server returned an empty body.
        // Falling back to an empty list keeps the rest of the logic uniform.
        var serverCategories = response.Response ?? new List<CategoryDto>();

        var upserted = 0;
        foreach (var dto in serverCategories)
        {
            var local = await _localDb.Categories
                .FirstOrDefaultAsync(c => c.Id == dto.Id);

            // Server says this record was deleted — remove it locally if it exists.
            if (dto.IsDeleted)
            {
                if (local != null)
                {
                    // Mark as never synced before removing so TombstoneInterceptor
                    // does not write a DeletedRecord — the server already deleted this,
                    // we must not push a redundant DELETE back.
                    local.IsSyncedToServer = false;
                    _localDb.Categories.Remove(local);
                    upserted++;
                }
                continue;
            }

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

}
