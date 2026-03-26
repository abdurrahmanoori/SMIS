using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Features.Categories.Commands;
using SMIS.Application.Features.Categories.Queries;
using SMIS.UI.Shared.Services.Base;

namespace SMIS.Web.Services;

// Server-side implementation — dispatches directly to MediatR handlers.
// No connectivity checks, no sync — the server is always the source of truth.
public class CategoryService : BaseService
{
    public CategoryService(IMediator mediator) : base(mediator) { }

    public Task<Result<PagedList<CategoryDto>>> GetAllAsync(int pageNumber = 1, int pageSize = 10, string? searchTerm = null)
        => SendAsync(new CategoryGetListQuery(pageNumber, pageSize, searchTerm));

    public Task<Result<CategoryDto>> GetByIdAsync(string id)
        => SendAsync(new CategoryGetByIdQuery(id));

    public Task<Result<CategoryDto>> CreateAsync(CategoryCreateDto dto)
        => SendAsync(new CategoryCreateCommand(dto));

    public Task<Result<CategoryDto>> UpdateAsync(string id, CategoryUpdateDto dto)
        => SendAsync(new CategoryUpdateCommand(id, dto));

    public Task<Result<Unit>> DeleteAsync(string id)
        => SendAsync(new CategoryDeleteCommand(id));
}
