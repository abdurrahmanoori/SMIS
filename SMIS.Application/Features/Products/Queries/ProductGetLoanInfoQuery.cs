using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Products;
using SMIS.Application.Repositories.Products;

namespace SMIS.Application.Features.Products.Queries;

public record ProductGetLoanInfoQuery(string ProductId) : IRequest<Result<ProductLoanInfoDto>>;

internal sealed class ProductGetLoanInfoQueryHandler : IRequestHandler<ProductGetLoanInfoQuery, Result<ProductLoanInfoDto>>
{
    private readonly IProductRepository _productRepository;

    public ProductGetLoanInfoQueryHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<Result<ProductLoanInfoDto>> Handle(ProductGetLoanInfoQuery request, CancellationToken cancellationToken)
    {
        var product = await _productRepository.GetFirstOrDefaultAsync(
            x => x.Id == request.ProductId,
            includeProperties: "UnitOfMeasure,ProductPrices.ProductUnit");

        if (product == null)
        {
            return Result<ProductLoanInfoDto>.NotFoundResult(nameof(ProductLoanInfoDto));
        }

        var baseUnitPrice = product.ProductPrices
            .Where(p => p.IsActive && 
                       p.ProductUnit != null && 
                       p.ProductUnit.UnitOfMeasureId == product.BaseUnitId &&
                       (p.EndDate == null || p.EndDate >= DateTime.UtcNow))
            .OrderByDescending(p => p.EffectiveDate)
            .FirstOrDefault();

        var dto = new ProductLoanInfoDto
        {
            ProductId = product.Id,
            ProductName = product.Name,
            BaseUnitId = product.BaseUnitId,
            BaseUnitName = product.UnitOfMeasure?.Name ?? string.Empty,
            LatestSellPrice = baseUnitPrice?.SellPrice ?? 0,
            LatestBuyPrice = baseUnitPrice?.BuyPrice ?? 0,
            PriceEffectiveDate = baseUnitPrice?.EffectiveDate,
            HasActivePrice = baseUnitPrice != null
        };

        return Result<ProductLoanInfoDto>.SuccessResult(dto);
    }
}
