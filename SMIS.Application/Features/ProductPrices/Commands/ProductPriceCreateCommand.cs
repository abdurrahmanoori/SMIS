using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.ProductPrices;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.ProductPrices;
using SMIS.Application.Repositories.ProductUnits;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.ProductPrices.Commands;

public record ProductPriceCreateCommand(ProductPriceCreateDto ProductPriceCreateDto) : IRequest<Result<ProductPriceDto>>;

internal sealed class ProductPriceCreateCommandHandler : IRequestHandler<ProductPriceCreateCommand, Result<ProductPriceDto>>
{
    private readonly IProductPriceRepository _productPriceRepository;
    private readonly IProductUnitRepository _productUnitRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICurrentUser _currentUser;
    private readonly IMapper _mapper;

    public ProductPriceCreateCommandHandler(
        IUnitOfWork unitOfWork,
        IMapper mapper,
        IProductPriceRepository productPriceRepository,
        IProductUnitRepository productUnitRepository,
        ICurrentUser currentUser)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _productPriceRepository = productPriceRepository;
        _productUnitRepository = productUnitRepository;
        _currentUser = currentUser;
    }

    public async Task<Result<ProductPriceDto>> Handle(ProductPriceCreateCommand request, CancellationToken cancellationToken)
    {
        var dto = request.ProductPriceCreateDto;
        var productUnit = await ProductPriceCommandRules.GetAccessibleProductUnitAsync(
            dto.ProductUnitId,
            _productUnitRepository,
            _currentUser);

        if (productUnit is null)
            return ProductPriceCommandRules.ProductUnitNotFoundOrForbidden();

        var latest = await _productPriceRepository.GetLatestForProductUnitAsync(dto.ProductUnitId, cancellationToken);
        var timelineError = ProductPriceCommandRules.ValidateAndCloseLatest(latest, dto.EffectiveDate);
        if (timelineError is not null) return timelineError;

        var entity = ProductPrice.Create(dto.ProductUnitId, dto.SellPrice, dto.EffectiveDate);
        entity.SetEndDate(dto.EndDate);

        await _productPriceRepository.AddAsync(entity);
        await _unitOfWork.SaveChanges(cancellationToken);

        return Result<ProductPriceDto>.SuccessResult(_mapper.Map<ProductPriceDto>(entity));
    }
}

internal static class ProductPriceCommandRules
{
    /// <summary>
    /// Loads the ProductUnit together with its Product and verifies tenant ownership.
    /// ProductPrice itself does not contain ShopId, so authorization is inherited through ProductUnit -> Product.
    /// </summary>
    public static async Task<ProductUnit?> GetAccessibleProductUnitAsync(
        string productUnitId,
        IProductUnitRepository productUnits,
        ICurrentUser currentUser)
    {
        var productUnit = await productUnits.GetFirstOrDefaultAsync(
            item => item.Id == productUnitId,
            includeProperties: "Product");

        if (productUnit?.Product is null) return null;
        return productUnit.Product.ShopId == currentUser.GetShopId()
            ? productUnit
            : null;
    }

    public static Result<ProductPriceDto>? ValidateAndCloseLatest(
        ProductPrice? latest,
        DateTime newEffectiveDate)
    {
        if (latest is null) return null;

        // Price history is append-only in chronological order. Reusing or backdating an
        // effective timestamp would create overlapping/ambiguous price periods.
        if (newEffectiveDate <= latest.EffectiveDate)
        {
            return Result<ProductPriceDto>.FailureResult(
                "PriceEffectiveDateOutOfOrder",
                "A new price must become effective after the latest price for this product unit.");
        }

        if (!latest.EndDate.HasValue || latest.EndDate.Value >= newEffectiveDate)
            // Close the previous period immediately before the successor begins.
            // AddTicks(-1) preserves a non-overlapping inclusive date-range model.
            latest.SetEndDate(newEffectiveDate.AddTicks(-1));

        return null;
    }

    public static Result<ProductPriceDto> ProductUnitNotFoundOrForbidden() =>
        Result<ProductPriceDto>.FailureResult(
            "ProductUnitNotFoundOrForbidden",
            "The selected product unit does not exist or does not belong to your shop.");

    public static Result<ProductPriceDto> ProductUnitCannotChange() =>
        Result<ProductPriceDto>.FailureResult(
            "ProductPriceUnitCannotChange",
            "A historical price cannot be moved to another product unit. Create a price for that product unit instead.");

    public static Result<ProductPriceDto> HistoricalPriceImmutable() =>
        Result<ProductPriceDto>.FailureResult(
            "HistoricalPriceImmutable",
            "Historical prices cannot be rewritten. Add a new effective price instead.");
}
