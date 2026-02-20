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
            try
            {
                // Check if exists on server (for updates)
                var existsOnServer = await _apiClient.GetAsync<CategoryDto>($"/api/category/{category.Id}");

                if (existsOnServer.Success)
                {
                    // Update existing
                    var updateDto = new CategoryUpdateDto
                    {
                        Name = category.Name,
                        Code = category.Code,
                        Description = category.Description,
                        IsActive = category.IsActive
                    };

                    var result = await _apiClient.PutAsync<CategoryUpdateDto, CategoryDto>(
                        $"/api/category/{category.Id}", updateDto);

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
                else
                {
                    // Create new
                    var createDto = new CategoryCreateDto
                    {
                        Name = category.Name,
                        Code = category.Code,
                        Description = category.Description,
                        IsActive = category.IsActive,
                        ShopId = category.ShopId
                    };

                    var result = await _apiClient.PostAsync<CategoryCreateDto, CategoryDto>(
                        "/api/category", createDto);

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
