using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Products;
using SMIS.Application.DTO.ProductUnits;
using SMIS.Application.DTO.UnitOfMeasures;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Services;

namespace SMIS.Application.Features.ProductUnits.Queries;

public record ProductUnitQuery(
    EntityDropdown<ProductUnitQueryCriteria> Query,
    bool IncludeProduct = false,
    bool IncludeUnitOfMeasure = false
)
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
                Product = request.IncludeProduct
                    ? new ProductDto
                    {
                        Id = x.Product.Id,
                        Name = x.Product.Name,
                        ShopId = x.Product.ShopId,
                        BaseUnitId = x.Product.BaseUnitId,
                        Description = x.Product.Description,
                        IsActive = x.Product.IsActive,
                        SKU = x.Product.SKU,
                        Barcode = x.Product.Barcode,
                        ImageUrl = x.Product.ImageUrl,
                        CategoryId = x.Product.CategoryId,
                        ReorderPointBase = x.Product.ReorderPointBase,
                        ReorderQuantityBase = x.Product.ReorderQuantityBase,
                        CreatedDate = x.Product.CreatedDate,
                        CreatedBy = x.Product.CreatedBy,
                        UpdatedDate = x.Product.UpdatedDate,
                        UpdatedBy = x.Product.UpdatedBy,
                        ClientModifiedDate = x.Product.ClientModifiedDate,
                        LastModifiedUtc = x.Product.LastModifiedUtc,
                        IsDeleted = x.Product.IsDeleted
                    }
                    : null,
                UnitOfMeasure = request.IncludeUnitOfMeasure
                    ? new UnitOfMeasureDto
                    {
                        Id = x.UnitOfMeasure.Id,
                        Name = x.UnitOfMeasure.Name,
                        Symbol = x.UnitOfMeasure.Symbol,
                        Description = x.UnitOfMeasure.Description,
                        ClientModifiedDate = x.UnitOfMeasure.ClientModifiedDate,
                        LastModifiedUtc = x.UnitOfMeasure.LastModifiedUtc,
                        IsDeleted = x.UnitOfMeasure.IsDeleted
                    }
                    : null
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