using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Infrastructure.Mobile.Services.Sync;

namespace SMIS.UI.Services.Interfaces;

public interface ICategoryService
{
    Task<Result<PagedList<CategoryDto>>> GetAllAsync(int pageNumber = 1, int pageSize = 10, string? searchTerm = null);
    Task<Result<CategoryDto>> GetByIdAsync(string id);
    Task<Result<CategoryDto>> CreateAsync(CategoryCreateDto dto);
    Task<Result<CategoryDto>> UpdateAsync(string id, CategoryUpdateDto dto);
    Task<Result<MediatR.Unit>> DeleteAsync(string id);
    Task<SyncResult> SyncAsync();
    Task<int> GetPendingCountAsync();
}
