using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Shops;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;
using SMIS.Infrastructure.Mobile.Context;
using SMIS.Infrastructure.Mobile.Services.Http;
using SMIS.Infrastructure.Mobile.Services.Identity;
using SMIS.Infrastructure.Mobile.Services.Platform;

namespace SMIS.Infrastructure.Mobile.Services.Sync.Shops;

public interface IShopSyncService
{
    Task<SyncResult> PullShopsAsync();
}

public class ShopSyncService : IShopSyncService
{
    private readonly LocalDbContext _localDb;
    private readonly IApiClient _apiClient;
    private readonly IConnectivity? _connectivity;
    private readonly IMobileCurrentUser _currentUser;
    private readonly IPreferencesService _preferences;

    private const string PullTimestampKeyPrefix = "shop_pull_";

    public ShopSyncService(
        LocalDbContext localDb,
        IApiClient apiClient,
        IMobileCurrentUser currentUser,
        IPreferencesService preferences,
        IConnectivity? connectivity = null)
    {
        _localDb = localDb;
        _apiClient = apiClient;
        _currentUser = currentUser;
        _preferences = preferences;
        _connectivity = connectivity;
    }

    public async Task<SyncResult> PullShopsAsync()
    {
        if (!ConnectivityGuard.IsConnected(_connectivity))
            return ConnectivityGuard.OfflineResult();

        var shopId = _currentUser.GetShopId();
        var timestampKey = $"{PullTimestampKeyPrefix}{shopId}";

        var lastPull = DateTime.Parse(
            _preferences.Get(timestampKey, DateTime.MinValue.ToString("yyyy-MM-ddTHH:mm:ss")));
        var response = await _apiClient.GetAsync<List<ShopDto>>(
            $"/api/Shop/pull?changedSince={lastPull:yyyy-MM-ddTHH:mm:ss}");

        if (!response.Success)
            return new SyncResult { Success = false, Message = response.Message ?? "Pull failed" };

        var serverShops = response.Response ?? new List<ShopDto>();

        var upserted = 0;
        foreach (var dto in serverShops)
        {
            var local = await _localDb.Shops
                .FirstOrDefaultAsync(c => c.Id == dto.Id);

            if (dto.IsDeleted)
            {
                if (local != null)
                {
                    local.IsSyncedToServer = false;
                    _localDb.Shops.Remove(local);
                    upserted++;
                }
                continue;
            }

            if (local == null)
            {
                var newShop = Shop.Create(dto.Name, dto.ShopType, dto.Address, dto.PhoneNumber, dto.Email, dto.TaxNumber, dto.IsActive);
                newShop.Id = dto.Id;
                newShop.LastModifiedUtc = dto.LastModifiedUtc;
                newShop.IsSyncedToServer = true;
                newShop.LastSyncedAt = DateTimeService.UtcNow;

                await _localDb.Shops.AddAsync(newShop);
                upserted++;
            }
            else if (dto.LastModifiedUtc > local.LastModifiedUtc)
            {
                local.SetName(dto.Name);
                local.SetShopType(dto.ShopType);
                local.SetAddress(dto.Address);
                local.SetPhoneNumber(dto.PhoneNumber);
                local.SetEmail(dto.Email);
                local.SetTaxNumber(dto.TaxNumber);
                if (dto.IsActive) local.Activate(); else local.Deactivate();

                local.LastModifiedUtc = dto.LastModifiedUtc;
                local.IsSyncedToServer = true;
                local.LastSyncedAt = DateTimeService.UtcNow;
                upserted++;
            }
        }

        await _localDb.SaveChangesAsync();

        _preferences.Set(timestampKey, DateTimeService.UtcNow.ToString("o"));

        return new SyncResult
        {
            Success = true,
            Message = upserted == 0 ? "No new changes from server" : $"Pulled {upserted} shop(s) from server",
            SyncedCount = upserted
        };
    }
}
