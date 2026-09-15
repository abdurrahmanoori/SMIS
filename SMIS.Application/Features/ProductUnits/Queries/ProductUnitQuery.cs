using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.ProductUnits;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Services;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.ProductUnits.Queries;

public sealed class ProductUnitQueryCriteria
{
    public string? Id { get; set; }
    public string? ProductId { get; set; }
    public string? UnitOfMeasureId { get; set; }
    public decimal? ConversionFactor { get; set; }
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
        var isSuperAdmin = _currentUser.IsSuperAdmin();
        var query = _context.ProductUnits
            .Where(x => isSuperAdmin || x.Product.ShopId == shopId)
            .OrderBy(x => x.Product.Name)
            .ThenBy(x => x.UnitOfMeasure.Name)
            .Select(x => new ProductUnitDto
            {
                Id = x.Id,
                ProductId = x.ProductId,
                UnitOfMeasureId = x.UnitOfMeasureId,
                ConversionFactor = x.ConversionFactor,
                ClientCreatedDate = x.ClientCreatedDate,
                ClientCreatedBy = x.ClientCreatedBy,
                ClientModifiedDate = x.ClientModifiedDate,
                ClientModifiedBy = x.ClientModifiedBy,
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

        foreach (var item in pagedList.Items)
        {
            item.ConflictModifiedUtc = DateTimeService.NormalizeUtc(
                item.ClientModifiedDate ?? item.LastModifiedUtc);
        }

        return Result<PagedListNew<ProductUnitDto>>.SuccessResult(pagedList);
    }
}
