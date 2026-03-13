using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Features.Categories.Commands;
using SMIS.Application.Features.Categories.Queries;
using SMIS.Infrastructure.Mobile.Services.Sync;
using AppPagedList = SMIS.Application.Common.PagedList<SMIS.Application.DTO.Categories.CategoryDto>;

namespace SMIS.UI2.Services;

public class CategoryService
{
    private readonly IMediator _mediator;
    private readonly ISyncService _syncService;
    private readonly IConnectivity _connectivity;

    public CategoryService(IMediator mediator, ISyncService syncService, IConnectivity connectivity)
    {
        _mediator = mediator;
        _syncService = syncService;
        _connectivity = connectivity;
    }

    public async Task<Result<AppPagedList>> GetAllAsync(int pageNumber = 0, int pageSize = 10)
    {
        pageNumber = pageNumber > 0 ? pageNumber : AppPagedList.DefaultPageNumber;
        pageSize = pageSize > 0 ? pageSize : AppPagedList.DefaultPageSize;

        var query = new CategoryGetListQuery(pageNumber, pageSize);
        return await _mediator.Send(query);
    }

    public async Task<Result<CategoryDto>> GetByIdAsync(string id)
    {
        var query = new CategoryGetByIdQuery(id);
        return await _mediator.Send(query);
    }

    public async Task<Result<CategoryDto>> CreateAsync(CategoryCreateDto dto)
    {
        var command = new CategoryCreateCommand(dto);
        var result = await _mediator.Send(command);

        if (result.Success && _connectivity.NetworkAccess == NetworkAccess.Internet)
        {
            var syncResult = await _syncService.SyncCategoriesAsync();
            if (!syncResult.Success)
            {
                result.Message = $"{result.Message} (Sync: {syncResult.Message})";
            }
        }

        return result;
    }

    public async Task<Result<CategoryDto>> UpdateAsync(string id, CategoryUpdateDto dto)
    {
        var command = new CategoryUpdateCommand(id, dto);
        var result = await _mediator.Send(command);

        if (result.Success && _connectivity.NetworkAccess == NetworkAccess.Internet)
        {
            var syncResult = await _syncService.SyncCategoriesAsync();
            if (!syncResult.Success)
            {
                result.Message = $"{result.Message} (Sync: {syncResult.Message})";
            }
        }

        return result;
    }

    public async Task<SyncResult> SyncAsync()
    {
        return await _syncService.SyncCategoriesAsync();
    }
}
