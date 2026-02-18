using Microsoft.EntityFrameworkCore;
using SMIS.Application.DTO.Categories;
using SMIS.UI.Data;
using SMIS.UI.Services.Http;

namespace SMIS.UI.Services.Sync;

public class SyncService
{
    private readonly LocalDbContext _localDb;
    private readonly IApiClient _apiClient;
    private readonly IConnectivity _connectivity;

    public SyncService(LocalDbContext localDb, IApiClient apiClient, IConnectivity connectivity)
    {
        _localDb = localDb;
        _apiClient = apiClient;
        _connectivity = connectivity;
    }

    public async Task<SyncResult> SyncCategoriesAsync()
    {
        if (_connectivity.NetworkAccess != NetworkAccess.Internet)
            return new SyncResult { Success = false, Message = "No internet connection" };

        var pendingCategories = await _localDb.Categories
            .Where(c => !c.IsSyncedToServer)
            .ToListAsync();

        var synced = 0;
        var failed = 0;

        foreach (var category in pendingCategories)
        {
            var dto = new CategoryCreateDto
            {
                Id = category.Id, // Send client-generated Id
                Name = category.Name,
                Code = category.Code,
                Description = category.Description,
                IsActive = category.IsActive,
                ShopId = category.ShopId
            };

            // POST to create on server with client Id
            var result = await _apiClient.PostAsync<CategoryCreateDto, CategoryDto>(
                "/api/categories", dto);

            if (result.Success)
            {
                category.IsSyncedToServer = true;
                category.LastSyncedAt = DateTime.UtcNow;
                synced++;
            }
            else
            {
                failed++;
            }
        }

        await _localDb.SaveChangesAsync();

        return new SyncResult
        {
            Success = failed == 0,
            Message = $"Synced {synced} categories, {failed} failed",
            SyncedCount = synced,
            FailedCount = failed
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
