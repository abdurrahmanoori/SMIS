using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Services;

namespace SMIS.Application.Features.Categories.Queries;

public record CategoryQuery(EntityDropdown<CategoryQueryCriteria> Query)
    : IRequest<Result<PagedListNew<CategoryDto>>>;

internal sealed class CategoryQueryHandler
    : IRequestHandler<CategoryQuery, Result<PagedListNew<CategoryDto>>>
{
    private readonly IApplicationDbContext _context;

    public CategoryQueryHandler(
        IApplicationDbContext context
    )
    {
        _context = context;
    }

    public async Task<Result<PagedListNew<CategoryDto>>> Handle(
        CategoryQuery request,
        CancellationToken cancellationToken
    )
    {
        var query = _context.Categories
            .Select(category => new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                Code = category.Code,
                Description = category.Description,
                IsActive = category.IsActive,
                ShopId = category.ShopId,
                CreatedDate = category.CreatedDate,
                CreatedBy = category.CreatedBy,
                UpdatedDate = category.UpdatedDate,
                UpdatedBy = category.UpdatedBy,
                ClientModifiedDate = category.ClientModifiedDate,
                LastModifiedUtc = category.LastModifiedUtc,
                IsDeleted = category.IsDeleted
            })
            .OrderBy(category => category.Name);

        var pagedList = await query
            .Filter(request.Query.Criteria)
            .Select(request.Query.Columns)
            .ToPagedList(
                request.Query.GetPageNumber(),
                request.Query.GetPageSize(),
                cancellationToken);

        return Result<PagedListNew<CategoryDto>>.SuccessResult(pagedList);
    }
}