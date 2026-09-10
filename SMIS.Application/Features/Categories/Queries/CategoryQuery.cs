using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Repositories.Categories;
using SMIS.Application.Services;

namespace SMIS.Application.Features.Categories.Queries;

public sealed class CategoryQueryCriteria
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? Code { get; set; }
    public string? Description { get; set; }
    public bool? IsActive { get; set; }
    public string? ShopId { get; set; }
}

public record CategoryQuery(EntityDropdown<CategoryQueryCriteria> Query)
    : IRequest<Result<PagedListNew<CategoryDto>>>;

internal sealed class CategoryQueryHandler
    : IRequestHandler<CategoryQuery, Result<PagedListNew<CategoryDto>>>
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IApplicationDbContext _context;

    public CategoryQueryHandler(
        ICategoryRepository categoryRepository,
        IApplicationDbContext context
    )
    {
        _categoryRepository = categoryRepository;
        _context = context;
    }

    public async Task<Result<PagedListNew<CategoryDto>>> Handle(
        CategoryQuery request,
        CancellationToken cancellationToken
    )
    {
        var query = _context.Categories
            .OrderBy(x => x.Name)
            .Select(x => new CategoryDto
            {
                Id = x.Id,
                Name = x.Name,
                Code = x.Code,
                Description = x.Description,
                IsActive = x.IsActive,
                ShopId = x.ShopId,
                CreatedDate = x.CreatedDate,
                CreatedBy = x.CreatedBy,
                UpdatedDate = x.UpdatedDate,
                UpdatedBy = x.UpdatedBy,
                ClientCreatedDate = x.ClientCreatedDate,
                ClientCreatedBy = x.ClientCreatedBy,
                ClientModifiedDate = x.ClientModifiedDate,
                ClientModifiedBy = x.ClientModifiedBy,
                LastModifiedUtc = x.LastModifiedUtc,
                IsDeleted = x.IsDeleted,
            });
        var pagedList = await query.Filter(request.Query.Criteria).Select(request.Query.Columns)
            .ToPagedList((int)request.Query.PageNumber!,
                (int)request.Query.PageSize!);

        // var pagedList = await query.ToPagedList(
        //     request.Query.GetPageNumber(),
        //     request.Query.GetPageSize());

        return Result<PagedListNew<CategoryDto>>.SuccessResult(pagedList);
    }
}