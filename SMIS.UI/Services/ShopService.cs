using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Shops;
using SMIS.Application.Features.Shops.Commands;
using SMIS.Application.Features.Shops.Queries;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Mobile.Services.Sync;
using SMIS.Infrastructure.Mobile.Services.Sync.Shops;
using SMIS.UI.Shared.Services.Base;
using SMIS.UI.Shared.Services.Interfaces;

namespace SMIS.UI.Services;

public class ShopService : BaseService, IShopService
{
    private readonly IConnectivity _connectivity;
    private readonly ISyncService _syncService;
    private readonly IShopSyncService _shopSyncService;

    public ShopService(
        IMediator mediator,
        IConnectivity connectivity,
        ISyncService syncService,
        IShopSyncService shopSyncService)
        : base(mediator)
    {
        _connectivity = connectivity;
        _syncService = syncService;
        _shopSyncService = shopSyncService;
    }

    public async Task<Result<PagedList<ShopDto>>> GetAllAsync(int pageNumber = 1, int pageSize = 10, string? searchTerm = null)
        => await SendAsync(new ShopGetListQuery(pageNumber, pageSize, searchTerm));

    public async Task<Result<ShopDto>> GetByIdAsync(string id)
        => await SendAsync(new ShopGetByIdQuery(id));

    public async Task<Result<ShopDto>> CreateAsync(ShopCreateDto dto)
        => await SendAndSyncAsync(new ShopCreateCommand(dto), _syncService.SyncShopsAsync);

    public async Task<Result<ShopDto>> UpdateAsync(string id, ShopUpdateDto dto)
        => await SendAndSyncAsync(new ShopUpdateCommand(id, dto), _syncService.SyncShopsAsync);

    public async Task<Result<MediatR.Unit>> DeleteAsync(string id)
        => await SendAndSyncAsync(new ShopDeleteCommand(id), _syncService.SyncDeletesAsync);

    public async Task<SyncResult> SyncAsync()
    {
        var pullResult = await _shopSyncService.PullShopsAsync();
        var pushResult = await _syncService.SyncShopsAsync();

        return new SyncResult
        {
            Success = pullResult.Success && pushResult.Success,
            Message = $"Pull: {pullResult.Message} | Push: {pushResult.Message}",
            SyncedCount = pullResult.SyncedCount + pushResult.SyncedCount,
            FailedCount = pushResult.FailedCount
        };
    }

    public async Task<int> GetPendingCountAsync()
        => await _syncService.GetPendingCountAsync<Shop>();

    // Executes the command then triggers sync if connected — MAUI-specific behaviour
    private async Task<Result<T>> SendAndSyncAsync<T>(IRequest<Result<T>> request, Func<Task<SyncResult>> syncFunc)
    {
        var result = await Mediator.Send(request);

        if (result.Success && _connectivity.NetworkAccess == NetworkAccess.Internet)
        {
            var syncResult = await syncFunc();
            if (!syncResult.Success)
                result.Message = string.IsNullOrEmpty(result.Message)
                    ? $"Sync: {syncResult.Message}"
                    : $"{result.Message} (Sync: {syncResult.Message})";
        }

        return result;
    }
}
