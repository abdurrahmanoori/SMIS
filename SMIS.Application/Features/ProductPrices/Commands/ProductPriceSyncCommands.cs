using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.ProductPrices;
using SMIS.Application.Features.ProductPrices;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.ProductPrices;
using SMIS.Application.Repositories.ProductUnits;
using SMIS.Application.Services;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.ProductPrices.Commands;

public record ProductPriceSyncCreateCommand(ProductPriceSyncCreateDto Dto) : IRequest<Result<ProductPriceDto>>;
public record ProductPriceSyncUpdateCommand(string Id, ProductPriceSyncUpdateDto Dto) : IRequest<Result<ProductPriceDto>>;
public record ProductPriceSyncDeleteCommand(string Id, ProductPriceSyncDeleteDto Dto) : IRequest<Result<ProductPriceDto>>;

internal sealed class ProductPriceSyncCreateCommandHandler
    : IRequestHandler<ProductPriceSyncCreateCommand, Result<ProductPriceDto>>
{
    private readonly IProductPriceRepository _repository;
    private readonly IApplicationDbContext _db;
    private readonly IProductUnitRepository _productUnits;
    private readonly ICurrentUser _user;

    public ProductPriceSyncCreateCommandHandler(
        IProductPriceRepository repository,
        IApplicationDbContext db,
        IProductUnitRepository productUnits,
        ICurrentUser user)
    {
        _repository = repository;
        _db = db;
        _productUnits = productUnits;
        _user = user;
    }

    public async Task<Result<ProductPriceDto>> Handle(ProductPriceSyncCreateCommand request, CancellationToken ct)
    {
        var id = ProductPriceSyncRules.Id(request.Dto.Id);
        var existing = await _db.ProductPrices.IgnoreQueryFilters()
            .FirstOrDefaultAsync(price => price.Id == id, ct);
        if (existing is not null)
            return Result<ProductPriceDto>.SuccessResult(ProductPriceMapping.ToDto(existing));

        var productUnit = await ProductPriceCommandRules.GetAccessibleProductUnitAsync(
            request.Dto.ProductUnitId, _productUnits, _user);
        if (productUnit is null) return ProductPriceCommandRules.ProductUnitNotFoundOrForbidden();

        var latest = await _repository.GetLatestForProductUnitAsync(request.Dto.ProductUnitId, ct);
        var timelineError = ProductPriceCommandRules.ValidateAndCloseLatest(latest, request.Dto.EffectiveDate);
        if (timelineError is not null) return timelineError;

        var value = ProductPrice.Create(request.Dto.ProductUnitId, request.Dto.SellPrice, request.Dto.EffectiveDate);
        value.Id = id;
        value.SetEndDate(request.Dto.EndDate);
        value.SetClientModificationMetadata(request.Dto.ClientModifiedDate);
        await _repository.AddAsync(value);
        await _db.SaveChangesAsync(ct);
        return Result<ProductPriceDto>.SuccessResult(ProductPriceMapping.ToDto(value));
    }
}

internal sealed class ProductPriceSyncUpdateCommandHandler
    : IRequestHandler<ProductPriceSyncUpdateCommand, Result<ProductPriceDto>>
{
    private readonly IProductPriceRepository _repository;
    private readonly IApplicationDbContext _db;
    private readonly IProductUnitRepository _productUnits;
    private readonly ICurrentUser _user;

    public ProductPriceSyncUpdateCommandHandler(
        IProductPriceRepository repository,
        IApplicationDbContext db,
        IProductUnitRepository productUnits,
        ICurrentUser user)
    {
        _repository = repository;
        _db = db;
        _productUnits = productUnits;
        _user = user;
    }

    public async Task<Result<ProductPriceDto>> Handle(ProductPriceSyncUpdateCommand request, CancellationToken ct)
    {
        var id = ProductPriceSyncRules.Id(request.Id);
        var existing = await _db.ProductPrices.IgnoreQueryFilters()
            .FirstOrDefaultAsync(price => price.Id == id, ct);
        if (existing is null) return Result<ProductPriceDto>.NotFoundResult(request.Id);
        if (!string.Equals(existing.ProductUnitId, request.Dto.ProductUnitId, StringComparison.Ordinal))
            return ProductPriceCommandRules.ProductUnitCannotChange();

        var productUnit = await ProductPriceCommandRules.GetAccessibleProductUnitAsync(
            existing.ProductUnitId, _productUnits, _user);
        if (productUnit is null) return ProductPriceCommandRules.ProductUnitNotFoundOrForbidden();

        var latest = await _repository.GetLatestForProductUnitAsync(existing.ProductUnitId, ct);
        if (request.Dto.EffectiveDate == existing.EffectiveDate && request.Dto.SellPrice == existing.SellPrice)
        {
            if (!request.Dto.EndDate.HasValue || request.Dto.EndDate.Value < existing.EffectiveDate)
                return Result<ProductPriceDto>.FailureResult(
                    "InvalidPriceEndDate",
                    "The price end date must be on or after its effective date.");

            existing.SetEndDate(request.Dto.EndDate);
            existing.SetClientModificationMetadata(request.Dto.ClientModifiedDate);
            await _db.SaveChangesAsync(ct);
            return Result<ProductPriceDto>.SuccessResult(ProductPriceMapping.ToDto(existing));
        }

        if (latest is null || !string.Equals(latest.Id, existing.Id, StringComparison.Ordinal))
            return ProductPriceCommandRules.HistoricalPriceImmutable();

        var timelineError = ProductPriceCommandRules.ValidateAndCloseLatest(latest, request.Dto.EffectiveDate);
        if (timelineError is not null) return timelineError;

        var successor = ProductPrice.Create(existing.ProductUnitId, request.Dto.SellPrice, request.Dto.EffectiveDate);
        successor.SetEndDate(request.Dto.EndDate);
        successor.SetClientModificationMetadata(request.Dto.ClientModifiedDate);
        await _repository.AddAsync(successor);
        await _db.SaveChangesAsync(ct);
        return Result<ProductPriceDto>.SuccessResult(ProductPriceMapping.ToDto(successor));
    }
}

internal sealed class ProductPriceSyncDeleteCommandHandler
    : IRequestHandler<ProductPriceSyncDeleteCommand, Result<ProductPriceDto>>
{
    private readonly IProductPriceRepository _repository;
    private readonly IApplicationDbContext _db;
    private readonly IProductUnitRepository _productUnits;
    private readonly ICurrentUser _user;

    public ProductPriceSyncDeleteCommandHandler(
        IProductPriceRepository repository,
        IApplicationDbContext db,
        IProductUnitRepository productUnits,
        ICurrentUser user)
    {
        _repository = repository;
        _db = db;
        _productUnits = productUnits;
        _user = user;
    }

    public async Task<Result<ProductPriceDto>> Handle(ProductPriceSyncDeleteCommand request, CancellationToken ct)
    {
        var id = ProductPriceSyncRules.Id(request.Id);
        var value = await _db.ProductPrices.IgnoreQueryFilters()
            .FirstOrDefaultAsync(price => price.Id == id, ct);
        if (value is null) return Result<ProductPriceDto>.NotFoundResult(request.Id);

        var productUnit = await ProductPriceCommandRules.GetAccessibleProductUnitAsync(
            value.ProductUnitId, _productUnits, _user);
        if (productUnit is null) return ProductPriceCommandRules.ProductUnitNotFoundOrForbidden();

        var modified = DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate);
        if (modified < value.GetConflictModifiedUtc())
            return Result<ProductPriceDto>.SuccessResult(ProductPriceMapping.ToDto(value));

        value.SetClientModificationMetadata(modified);
        await _repository.RemoveAsync(value);
        await _db.SaveChangesAsync(ct);
        return Result<ProductPriceDto>.SuccessResult(ProductPriceMapping.ToDto(value));
    }
}

internal static class ProductPriceSyncRules
{
    public static string Id(string value) => Guid.Parse(value).ToString("D");
}
