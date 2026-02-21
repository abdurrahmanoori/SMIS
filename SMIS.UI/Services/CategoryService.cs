using MediatR;
using SMIS.Application.Common;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Features.Categories.Commands;
using SMIS.Application.Features.Categories.Queries;
using SMIS.Infrastructure.Mobile.Services.Sync;
using SMIS.UI.Services.Base;
//using UiApiResponse = SMIS.UI.Models.ApiResponse<T>;

namespace SMIS.UI.Services;

public class CategoryService : BaseService
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

    public async Task<Models.ApiResponse<PagedList<CategoryDto>>> GetAllAsync(int pageNumber = 0, int pageSize = 0)
    {
        pageNumber = pageNumber > 0 ? pageNumber : PagedList<CategoryDto>.DefaultPageNumber;
        pageSize = pageSize > 0 ? pageSize : PagedList<CategoryDto>.DefaultPageSize;

        var query = new CategoryGetListQuery(pageNumber, pageSize);
        var result = await _mediator.Send(query);

        return new Models.ApiResponse<PagedList<CategoryDto>>
        {
            Success = result.Success,
            Response = result.Response,
            Message = result.Message
        };
    }

    public async Task<Models.ApiResponse<CategoryDto>> GetByIdAsync(string id)
    {
        var query = new CategoryGetByIdQuery(id);
        var result = await _mediator.Send(query);

        return new Models.ApiResponse<CategoryDto>
        {
            Success = result.Success,
            Response = result.Response,
            Message = result.Message
        };
    }

    public async Task<Models.ApiResponse<CategoryDto>> CreateAsync(CategoryCreateDto dto)
    {
        var command = new CategoryCreateCommand(dto);
        var result = await _mediator.Send(command);

        // Sync in background if online
        if (result.Success && _connectivity.NetworkAccess == NetworkAccess.Internet)
        {
            _ = Task.Run(() => _syncService.SyncCategoriesAsync());
        }

        return new Models.ApiResponse<CategoryDto>
        {
            Success = result.Success,
            Response = result.Response,
            Message = result.Message ?? (_connectivity.NetworkAccess != NetworkAccess.Internet 
                ? "Created offline - will sync when online" 
                : "Created successfully")
        };
    }

    public async Task<Models.ApiResponse<CategoryDto>> UpdateAsync(string id, CategoryUpdateDto dto)
    {
        var updateDto = new CategoryCreateDto
        {
            Name = dto.Name,
            Code = dto.Code,
            Description = dto.Description,
            IsActive = dto.IsActive
        };
        
        var command = new CategoryUpdateCommand(id, updateDto);
        var result = await _mediator.Send(command);

        // Sync in background if online
        if (result.Success && _connectivity.NetworkAccess == NetworkAccess.Internet)
        {
            _ = Task.Run(() => _syncService.SyncCategoriesAsync());
        }

        return new Models.ApiResponse<CategoryDto>
        {
            Success = result.Success,
            Response = result.Response,
            Message = result.Message ?? (_connectivity.NetworkAccess != NetworkAccess.Internet 
                ? "Updated offline - will sync when online" 
                : "Updated successfully")
        };
    }

    public async Task<SyncResult> SyncAsync()
    {
        return await _syncService.SyncCategoriesAsync();
    }
}
