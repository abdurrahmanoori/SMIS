using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.ProductUnits;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Services;

namespace SMIS.Application.Features.ProductUnits.Queries;

public sealed class ProductUnitQueryCriteria
{
    public string? Id { get; set; }
    public string? ProductId { get; set; }
    public string? UnitOfMeasureId { get; set; }
    public decimal? BaseUnitQuantity { get; set; }
}

public record ProductUnitQuery(EntityDropdown<ProductUnitQueryCriteria> Query)
    : IRequest<Result<PagedListNew<ProductUnitDto>>>;

internal sealed class ProductUnitQueryHandler
    : IRequestHandler<ProductUnitQuery, Result<PagedListNew<ProductUnitDto>>>
{
    private readonly IApplicationDbContext _context;
    private readonly ICurrentUser _currentUser;

    public ProductUnitQueryHandler(
        IApplicationDbContext context,
        ICurrentUser currentUser
    ) => (_context, _currentUser) = (context, currentUser);

    public async Task<Result<PagedListNew<ProductUnitDto>>> Handle(
        ProductUnitQuery request,
        CancellationToken cancellationToken
    )
    {
        var shopId = _currentUser.GetShopId();
        var query = _context.ProductUnits
            .Where(x => x.Product.ShopId == shopId)
            .OrderBy(x => x.Product.Name)
            .ThenBy(x => x.UnitOfMeasure.Name)
            .Select(x => new ProductUnitDto
            {
                Id = x.Id,
                ProductId = x.ProductId,
                UnitOfMeasureId = x.UnitOfMeasureId,
                BaseUnitQuantity = x.BaseUnitQuantity,
                ClientModifiedDate = x.ClientModifiedDate,
                LastModifiedUtc = x.LastModifiedUtc,
                IsDeleted = x.IsDeleted,
            });

        var pagedList = await query
            .Filter(request.Query.Criteria)
            .Select(request.Query.Columns)
            .ToPagedList(
                request.Query.GetPageNumber(),
                request.Query.GetPageSize(),
                cancellationToken);

        return Result<PagedListNew<ProductUnitDto>>.SuccessResult(pagedList);
    }
}