using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Identity.IServices;
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
    private readonly IApplicationDbContext _context;
    private readonly ICurrentUser _currentUser;

    public CategoryQueryHandler(
        IApplicationDbContext context,
        ICurrentUser currentUser
    )
    {
        _context = context;
        _currentUser = currentUser;
    }

    public async Task<Result<PagedListNew<CategoryDto>>> Handle(
        CategoryQuery request,
        CancellationToken cancellationToken
    )
    {
        var query = _context.Categories
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
                ClientModifiedDate = x.ClientModifiedDate,
                LastModifiedUtc = x.LastModifiedUtc,
                IsDeleted = x.IsDeleted
            })
            .OrderBy(x => x.Name);

        var pagedList = await query
            .Filter(request.Query.Criteria)
            .Select(request.Query.Columns)
            .ToPagedList(
                (int)request.Query.PageNumber!,
                (int)request.Query.PageSize!,
                cancellationToken);

        return Result<PagedListNew<CategoryDto>>.SuccessResult(pagedList);
    }
}
