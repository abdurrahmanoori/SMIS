using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Features.Categories.Commands;
using SMIS.Application.Features.Categories.Queries;
using SMIS.Infrastructure.Mobile.Services.Sync;
using SMIS.Infrastructure.Mobile.Services.Sync.Categories;
using SMIS.UI.Services.Base;
using SMIS.UI.Services.Interfaces;

namespace SMIS.UI.Services;

public class CategoryService : BaseService, ICategoryService
{
    private readonly ICategorySyncService _categorySyncService;

    public CategoryService(IMediator mediator, IConnectivity connectivity, ISyncService syncService, ICategorySyncService categorySyncService)
        : base(mediator, connectivity, syncService)
    {
        _categorySyncService = categorySyncService;
    }

    public async Task<Result<PagedList<CategoryDto>>> GetAllAsync(int pageNumber = 1, int pageSize = 10, string? searchTerm = null)
        => await SendAsync(new CategoryGetListQuery(pageNumber, pageSize, searchTerm));

    public async Task<Result<CategoryDto>> GetByIdAsync(string id)
        => await SendAsync(new CategoryGetByIdQuery(id));

    public async Task<Result<CategoryDto>> CreateAsync(CategoryCreateDto dto)
        => await SendAndSyncAsync(new CategoryCreateCommand(dto), SyncService.SyncCategoriesAsync);

    public async Task<Result<CategoryDto>> UpdateAsync(string id, CategoryUpdateDto dto)
        => await SendAndSyncAsync(new CategoryUpdateCommand(id, dto), SyncService.SyncCategoriesAsync);

    public async Task<Result<MediatR.Unit>> DeleteAsync(string id)
        => await SendAndSyncAsync(new CategoryDeleteCommand(id), SyncService.SyncDeletesAsync);

    public async Task<SyncResult> SyncAsync()
    {
        var pullResult = await _categorySyncService.PullCategoriesAsync();
        var pushResult = await SyncService.SyncCategoriesAsync();

        return new SyncResult
        {
            Success = pullResult.Success && pushResult.Success,
            Message = $"Pull: {pullResult.Message} | Push: {pushResult.Message}",
            SyncedCount = pullResult.SyncedCount + pushResult.SyncedCount,
            FailedCount = pushResult.FailedCount
        };
    }

    public async Task<int> GetPendingCountAsync()
        => await SyncService.GetPendingCountAsync<SMIS.Domain.Entities.Category>();
}
