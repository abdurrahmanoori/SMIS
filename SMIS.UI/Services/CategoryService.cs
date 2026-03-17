using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Features.Categories.Commands;
using SMIS.Application.Features.Categories.Queries;
using SMIS.Infrastructure.Mobile.Services.Sync;
using SMIS.UI.Services.Base;

namespace SMIS.UI.Services;

public class CategoryService : BaseService
{
    public CategoryService(IMediator mediator, IConnectivity connectivity, ISyncService syncService)
        : base(mediator, connectivity, syncService) { }

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
        => await SyncService.SyncCategoriesAsync();

    public async Task<int> GetPendingCountAsync()
        => await SyncService.GetPendingCountAsync<SMIS.Domain.Entities.Category>();
}
