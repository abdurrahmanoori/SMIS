using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Products;
using SMIS.Application.Repositories.Products;
using SMIS.Application.Repositories.StockBatches;
using SMIS.Domain.Contracts;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.Products.Queries;

public record ProductGetLoanInfoQuery(string ProductId) : IRequest<Result<ProductLoanInfoDto>>;

internal sealed class ProductGetLoanInfoQueryHandler : IRequestHandler<ProductGetLoanInfoQuery, Result<ProductLoanInfoDto>>
{
    private readonly IProductRepository _productRepository;
    private readonly IStockBatchRepository _stockBatchRepository;

    public ProductGetLoanInfoQueryHandler(
        IProductRepository productRepository,
        IStockBatchRepository stockBatchRepository)
    {
        _productRepository = productRepository;
        _stockBatchRepository = stockBatchRepository;
    }

    public async Task<Result<ProductLoanInfoDto>> Handle(ProductGetLoanInfoQuery request, CancellationToken cancellationToken)
    {
        var product = await _productRepository.GetFirstOrDefaultAsync(
            x => x.Id == request.ProductId,
            includeProperties: "UnitOfMeasure,ProductUnits.ProductPrices");

        if (product == null)
        {
            return Result<ProductLoanInfoDto>.NotFoundResult(nameof(ProductLoanInfoDto));
        }

        var now = DateTimeService.NowLocal;
        var activePrice = product.ProductUnits
            .SelectMany(productUnit => productUnit.ProductPrices
                .Where(price => price.EffectiveDate <= now &&
                                (price.EndDate == null || price.EndDate >= now))
                .Select(price => new { Price = price, ProductUnit = productUnit }))
            .OrderBy(item => item.ProductUnit.BaseUnitQuantity)
            .ThenByDescending(item => item.Price.EffectiveDate)
            .FirstOrDefault();

        // Calculate base unit price from any ProductUnit using BaseUnitQuantity
        var baseUnitSellPrice = activePrice != null
            ? (long)(activePrice.Price.SellPrice / activePrice.ProductUnit.BaseUnitQuantity)
            : 0;

        var latestBatch = await _stockBatchRepository
            .GetAllQueryable(batch => batch.ProductId == product.Id)
            .OrderByDescending(batch => batch.ReceivedDate)
            .FirstOrDefaultAsync(cancellationToken);

        var dto = new ProductLoanInfoDto
        {
            ProductId = product.Id,
            ProductName = product.Name,
            BaseUnitId = product.BaseUnitId,
            BaseUnitName = product.UnitOfMeasure?.Name ?? string.Empty,
            LatestSellPrice = baseUnitSellPrice,
            LatestBuyPrice = latestBatch?.PurchasePrice ?? 0,
            PriceEffectiveDate = activePrice?.Price.EffectiveDate,
            HasActivePrice = activePrice != null
        };

        return Result<ProductLoanInfoDto>.SuccessResult(dto);
    }
}
