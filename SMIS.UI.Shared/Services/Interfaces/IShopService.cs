using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Shops;

namespace SMIS.UI.Shared.Services.Interfaces;

public interface IShopService
{
    Task<Result<PagedList<ShopDto>>> GetAllAsync(int pageNumber = 1, int pageSize = 10, string? searchTerm = null);
    Task<Result<ShopDto>> GetByIdAsync(string id);
    Task<Result<ShopDto>> CreateAsync(ShopCreateDto dto);
    Task<Result<ShopDto>> UpdateAsync(string id, ShopUpdateDto dto);
    Task<Result<MediatR.Unit>> DeleteAsync(string id);
    Task<SyncResult> SyncAsync();
    Task<int> GetPendingCountAsync();
}
