using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Features.Categories.Commands;
using SMIS.Application.Features.Categories.Queries;
using SMIS.UI.Shared.Services.Base;
using SMIS.UI.Shared.Services.Interfaces;

namespace SMIS.WebMaui.Services;

public class WebCategoryService : BaseService, ICategoryService
{
    public WebCategoryService(IMediator mediator) : base(mediator) { }

    public async Task<Result<PagedList<CategoryDto>>> GetAllAsync(int pageNumber = 1, int pageSize = 10, string? searchTerm = null)
        => await SendAsync(new CategoryGetListQuery(pageNumber, pageSize, searchTerm));

    public async Task<Result<CategoryDto>> GetByIdAsync(string id)
        => await SendAsync(new CategoryGetByIdQuery(id));

    public async Task<Result<CategoryDto>> CreateAsync(CategoryCreateDto dto)
        => await SendAsync(new CategoryCreateCommand(dto));

    public async Task<Result<CategoryDto>> UpdateAsync(string id, CategoryUpdateDto dto)
        => await SendAsync(new CategoryUpdateCommand(id, dto));

    public async Task<Result<MediatR.Unit>> DeleteAsync(string id)
        => await SendAsync(new CategoryDeleteCommand(id));

    // No offline sync in web — no-op
    public Task<SyncResult> SyncAsync()
        => Task.FromResult(new SyncResult { Success = true, Message = "N/A", SyncedCount = 0, FailedCount = 0 });

    // No pending queue in web
    public Task<int> GetPendingCountAsync()
        => Task.FromResult(0);
}
