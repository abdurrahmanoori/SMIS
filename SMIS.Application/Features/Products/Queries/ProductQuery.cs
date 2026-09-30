using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Application.DTO.Products;
using SMIS.Application.Services;

namespace SMIS.Application.Features.Products.Queries;

public record ProductQuery(
    EntityDropdown<ProductQueryCriteria> Query,
    bool IncludeCategory = false
)
    : IRequest<Result<PagedListNew<ProductDto>>>;

internal sealed class ProductQueryHandler
    : IRequestHandler<ProductQuery, Result<PagedListNew<ProductDto>>>
{
    private readonly IApplicationDbContext _context;

    public ProductQueryHandler(
        IApplicationDbContext context
    )
    {
        _context = context;
    }

    public async Task<Result<PagedListNew<ProductDto>>> Handle(
        ProductQuery request,
        CancellationToken cancellationToken
    )
    {
        var query = _context.Products
            .OrderBy(product => product.Name)
            .Select(product => new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                ShopId = product.ShopId,
                BaseUnitId = product.BaseUnitId,
                Description = product.Description,
                IsActive = product.IsActive,
                SKU = product.SKU,
                Barcode = product.Barcode,
                ImageUrl = product.ImageUrl,
                CategoryId = product.CategoryId,
                ReorderPointBase = product.ReorderPointBase,
                ReorderQuantityBase = product.ReorderQuantityBase,
                Category = request.IncludeCategory
                    ? _context.Categories
                        .Where(category => category.Id == product.CategoryId)
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
                        .FirstOrDefault()
                    : null,
                CreatedDate = product.CreatedDate,
                CreatedBy = product.CreatedBy,
                UpdatedDate = product.UpdatedDate,
                UpdatedBy = product.UpdatedBy,
                ClientModifiedDate = product.ClientModifiedDate,
                LastModifiedUtc = product.LastModifiedUtc,
                IsDeleted = product.IsDeleted
            });

        var pagedList = await query
            .Filter(request.Query.Criteria)
            .Select(request.Query.Columns)
            .ToPagedList(
                request.Query.GetPageNumber(),
                request.Query.GetPageSize(),
                cancellationToken);

        return Result<PagedListNew<ProductDto>>.SuccessResult(pagedList);
    }
}