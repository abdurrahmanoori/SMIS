using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Products;
using SMIS.Application.Repositories.Products;
using SMIS.Domain.Contracts;
using SMIS.Domain.Services;

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

        var activePrice = product.ProductPrices
            .Where(p => p.IsActive && 
                       p.ProductUnit != null &&
                       (p.EndDate == null || p.EndDate >= DateTimeService.Now))
            .OrderBy(p => p.ProductUnit.ConversionFactor) // Prefer base unit (ConversionFactor=1)
            .ThenByDescending(p => p.EffectiveDate)
            .FirstOrDefault();

        // Calculate base unit price from any ProductUnit using ConversionFactor
        var baseUnitSellPrice = activePrice != null && activePrice.ProductUnit != null
            ? (long)(activePrice.SellPrice / activePrice.ProductUnit.ConversionFactor)
            : 0;
        
        var baseUnitBuyPrice = activePrice != null && activePrice.ProductUnit != null
            ? (long)(activePrice.BuyPrice / activePrice.ProductUnit.ConversionFactor)
            : 0;

        var dto = new ProductLoanInfoDto
        {
            ProductId = product.Id,
            ProductName = product.Name,
            BaseUnitId = product.BaseUnitId,
            BaseUnitName = product.UnitOfMeasure?.Name ?? string.Empty,
            LatestSellPrice = baseUnitSellPrice,
            LatestBuyPrice = baseUnitBuyPrice,
            PriceEffectiveDate = activePrice?.EffectiveDate,
            HasActivePrice = activePrice != null
        };

        return Result<ProductLoanInfoDto>.SuccessResult(dto);
    }
}
