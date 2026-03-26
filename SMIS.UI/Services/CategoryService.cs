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
    private readonly IConnectivity _connectivity;
    private readonly ISyncService _syncService;
    private readonly ICategorySyncService _categorySyncService;

    public CategoryService(
        IMediator mediator,
        IConnectivity connectivity,
        ISyncService syncService,
        ICategorySyncService categorySyncService)
        : base(mediator)
    {
        _connectivity = connectivity;
        _syncService = syncService;
        _categorySyncService = categorySyncService;
    }

    public async Task<Result<PagedList<CategoryDto>>> GetAllAsync(int pageNumber = 1, int pageSize = 10, string? searchTerm = null)
        => await SendAsync(new CategoryGetListQuery(pageNumber, pageSize, searchTerm));

    public async Task<Result<CategoryDto>> GetByIdAsync(string id)
        => await SendAsync(new CategoryGetByIdQuery(id));

    public async Task<Result<CategoryDto>> CreateAsync(CategoryCreateDto dto)
        => await SendAndSyncAsync(new CategoryCreateCommand(dto), _syncService.SyncCategoriesAsync);

    public async Task<Result<CategoryDto>> UpdateAsync(string id, CategoryUpdateDto dto)
        => await SendAndSyncAsync(new CategoryUpdateCommand(id, dto), _syncService.SyncCategoriesAsync);

    public async Task<Result<MediatR.Unit>> DeleteAsync(string id)
        => await SendAndSyncAsync(new CategoryDeleteCommand(id), _syncService.SyncDeletesAsync);

    public async Task<SyncResult> SyncAsync()
    {
        var pullResult = await _categorySyncService.PullCategoriesAsync();
        var pushResult = await _syncService.SyncCategoriesAsync();

        return new SyncResult
        {
            Success = pullResult.Success && pushResult.Success,
            Message = $"Pull: {pullResult.Message} | Push: {pushResult.Message}",
            SyncedCount = pullResult.SyncedCount + pushResult.SyncedCount,
            FailedCount = pushResult.FailedCount
        };
    }

    public async Task<int> GetPendingCountAsync()
        => await _syncService.GetPendingCountAsync<SMIS.Domain.Entities.Category>();

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
