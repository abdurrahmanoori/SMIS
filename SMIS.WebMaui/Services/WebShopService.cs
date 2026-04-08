using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Shops;
using SMIS.Application.Features.Shops.Commands;
using SMIS.Application.Features.Shops.Queries;
using SMIS.UI.Shared.Services.Base;
using SMIS.UI.Shared.Services.Interfaces;

namespace SMIS.WebMaui.Services;

public class WebShopService : BaseService, IShopService
{
    public WebShopService(IMediator mediator) : base(mediator) { }

    public async Task<Result<PagedList<ShopDto>>> GetAllAsync(int pageNumber = 1, int pageSize = 10, string? searchTerm = null)
        => await SendAsync(new ShopGetListQuery(pageNumber, pageSize, searchTerm));

    public async Task<Result<ShopDto>> GetByIdAsync(string id)
        => await SendAsync(new ShopGetByIdQuery(id));

    public async Task<Result<ShopDto>> CreateAsync(ShopCreateDto dto)
        => await SendAsync(new ShopCreateCommand(dto));

    public async Task<Result<ShopDto>> UpdateAsync(string id, ShopUpdateDto dto)
        => await SendAsync(new ShopUpdateCommand(id, dto));

    public async Task<Result<MediatR.Unit>> DeleteAsync(string id)
        => await SendAsync(new ShopDeleteCommand(id));

    // No offline sync in web — no-op
    public Task<SyncResult> SyncAsync()
        => Task.FromResult(new SyncResult { Success = true, Message = "N/A", SyncedCount = 0, FailedCount = 0 });

    // No pending queue in web
    public Task<int> GetPendingCountAsync()
        => Task.FromResult(0);
}
