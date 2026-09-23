using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.ProductPrices;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.ProductPrices;
using SMIS.Application.Repositories.ProductUnits;
using SMIS.Application.Services;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.ProductPrices.Commands;

public record ProductPriceSyncCreateCommand(ProductPriceSyncCreateDto Dto) : IRequest<Result<ProductPriceDto>>;

public record ProductPriceSyncUpdateCommand(string Id, ProductPriceSyncUpdateDto Dto)
    : IRequest<Result<ProductPriceDto>>;

public record ProductPriceSyncDeleteCommand(string Id, ProductPriceSyncDeleteDto Dto)
    : IRequest<Result<ProductPriceDto>>;

internal sealed class
    ProductPriceSyncCreateCommandHandler : IRequestHandler<ProductPriceSyncCreateCommand, Result<ProductPriceDto>>
{
    private readonly IProductPriceRepository _repository;
    private readonly IApplicationDbContext _db;
    private readonly IProductUnitRepository _productUnits;
    private readonly ICurrentUser _user;
    private readonly IMapper _mapper;

    public ProductPriceSyncCreateCommandHandler(
        IProductPriceRepository repository,
        IApplicationDbContext db,
        IProductUnitRepository productUnits,
        ICurrentUser user,
        IMapper mapper
    )
    {
        _repository = repository;
        _db = db;
        _productUnits = productUnits;
        _user = user;
        _mapper = mapper;
    }

    public async Task<Result<ProductPriceDto>> Handle(
        ProductPriceSyncCreateCommand request,
        CancellationToken ct
    )
    {
        if (!ProductPriceSyncRules.User(request.Dto.ClientCreatedBy, _user) ||
            !ProductPriceSyncRules.User(request.Dto.ClientModifiedBy, _user))
            return ProductPriceSyncRules.InvalidUser();

        var id = ProductPriceSyncRules.Id(request.Dto.Id);
        var existing = await _db.ProductPrices
            .IgnoreQueryFilters()
            .FirstOrDefaultAsync(price => price.Id == id, ct);
        if (existing is not null)
            return Result<ProductPriceDto>.SuccessResult(_mapper.Map<ProductPriceDto>(existing));

        var productUnit = await ProductPriceCommandRules.GetAccessibleProductUnitAsync(
            request.Dto.ProductUnitId,
            _productUnits,
            _user);
        if (productUnit is null) return ProductPriceCommandRules.ProductUnitNotFoundOrForbidden();

        var latest = await _repository.GetLatestForProductUnitAsync(request.Dto.ProductUnitId, ct);
        var timelineError = ProductPriceCommandRules.ValidateAndCloseLatest(latest, request.Dto.EffectiveDate);
        if (timelineError is not null) return timelineError;

        var value = ProductPrice.Create(request.Dto.ProductUnitId, request.Dto.SellPrice, request.Dto.EffectiveDate);
        value.Id = id;
        value.SetEndDate(request.Dto.EndDate);
        value.SetClientCreationMetadata(request.Dto.ClientCreatedDate, request.Dto.ClientCreatedBy);
        value.SetClientModificationMetadata(request.Dto.ClientModifiedDate, request.Dto.ClientModifiedBy);
        await _repository.AddAsync(value);
        await _db.SaveChangesAsync(ct);
        return Result<ProductPriceDto>.SuccessResult(_mapper.Map<ProductPriceDto>(value));
    }
}

internal sealed class
    ProductPriceSyncUpdateCommandHandler : IRequestHandler<ProductPriceSyncUpdateCommand, Result<ProductPriceDto>>
{
    private readonly IProductPriceRepository _repository;
    private readonly IApplicationDbContext _db;
    private readonly IProductUnitRepository _productUnits;
    private readonly ICurrentUser _user;
    private readonly IMapper _mapper;

    public ProductPriceSyncUpdateCommandHandler(
        IProductPriceRepository repository,
        IApplicationDbContext db,
        IProductUnitRepository productUnits,
        ICurrentUser user,
        IMapper mapper
    )
    {
        _repository = repository;
        _db = db;
        _productUnits = productUnits;
        _user = user;
        _mapper = mapper;
    }

    public async Task<Result<ProductPriceDto>> Handle(
        ProductPriceSyncUpdateCommand request,
        CancellationToken ct
    )
    {
        if (!ProductPriceSyncRules.User(request.Dto.ClientModifiedBy, _user))
            return ProductPriceSyncRules.InvalidUser();

        var id = ProductPriceSyncRules.Id(request.Id);
        var existing = await _db.ProductPrices
            .IgnoreQueryFilters()
            .FirstOrDefaultAsync(price => price.Id == id, ct);
        if (existing is null) return Result<ProductPriceDto>.NotFoundResult(request.Id);
        if (!string.Equals(existing.ProductUnitId, request.Dto.ProductUnitId, StringComparison.Ordinal))
            return ProductPriceCommandRules.ProductUnitCannotChange();

        var productUnit = await ProductPriceCommandRules.GetAccessibleProductUnitAsync(
            existing.ProductUnitId,
            _productUnits,
            _user);
        if (productUnit is null) return ProductPriceCommandRules.ProductUnitNotFoundOrForbidden();

        var latest = await _repository.GetLatestForProductUnitAsync(existing.ProductUnitId, ct);
        // Historical prices are immutable. A sync "update" is allowed only against
        // the latest row and is implemented by adding a successor price below.
        if (latest is null || !string.Equals(latest.Id, existing.Id, StringComparison.Ordinal))
            return ProductPriceCommandRules.HistoricalPriceImmutable();

        var timelineError = ProductPriceCommandRules.ValidateAndCloseLatest(latest, request.Dto.EffectiveDate);
        if (timelineError is not null) return timelineError;

        var successor = ProductPrice.Create(existing.ProductUnitId, request.Dto.SellPrice, request.Dto.EffectiveDate);
        successor.SetEndDate(request.Dto.EndDate);
        successor.SetClientModificationMetadata(request.Dto.ClientModifiedDate, request.Dto.ClientModifiedBy);
        await _repository.AddAsync(successor);
        await _db.SaveChangesAsync(ct);
        return Result<ProductPriceDto>.SuccessResult(_mapper.Map<ProductPriceDto>(successor));
    }
}

internal sealed class
    ProductPriceSyncDeleteCommandHandler : IRequestHandler<ProductPriceSyncDeleteCommand, Result<ProductPriceDto>>
{
    private readonly IProductPriceRepository _repository;
    private readonly IApplicationDbContext _db;
    private readonly IProductUnitRepository _productUnits;
    private readonly ICurrentUser _user;
    private readonly IMapper _mapper;

    public ProductPriceSyncDeleteCommandHandler(
        IProductPriceRepository repository,
        IApplicationDbContext db,
        IProductUnitRepository productUnits,
        ICurrentUser user,
        IMapper mapper
    )
    {
        _repository = repository;
        _db = db;
        _productUnits = productUnits;
        _user = user;
        _mapper = mapper;
    }

    public async Task<Result<ProductPriceDto>> Handle(
        ProductPriceSyncDeleteCommand request,
        CancellationToken ct
    )
    {
        if (!ProductPriceSyncRules.User(request.Dto.ClientModifiedBy, _user))
            return ProductPriceSyncRules.InvalidUser();

        var id = ProductPriceSyncRules.Id(request.Id);
        var value = await _db.ProductPrices
            .IgnoreQueryFilters()
            .FirstOrDefaultAsync(price => price.Id == id, ct);
        if (value is null) return Result<ProductPriceDto>.NotFoundResult(request.Id);

        var productUnit = await ProductPriceCommandRules.GetAccessibleProductUnitAsync(
            value.ProductUnitId,
            _productUnits,
            _user);
        if (productUnit is null) return ProductPriceCommandRules.ProductUnitNotFoundOrForbidden();

        var modified = DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate);
        if (modified < value.GetConflictModifiedUtc())
            return Result<ProductPriceDto>.SuccessResult(_mapper.Map<ProductPriceDto>(value));

        value.SetClientModificationMetadata(modified, request.Dto.ClientModifiedBy);
        await _repository.RemoveAsync(value);
        await _db.SaveChangesAsync(ct);
        return Result<ProductPriceDto>.SuccessResult(_mapper.Map<ProductPriceDto>(value));
    }
}

internal static class ProductPriceSyncRules
{
    // Keep client/server identity stable by normalizing rather than regenerating the GUID.
    public static string Id(
        string value
    ) => Guid.Parse(value).ToString("D");

    // Audit metadata is optional for backwards compatibility, but a supplied user ID
    // must match the authenticated principal to prevent cross-user sync impersonation.
    public static bool User(
        string? value,
        ICurrentUser user
    ) =>
        string.IsNullOrWhiteSpace(value) ||
        string.Equals(value.Trim(), user.GetId(), StringComparison.Ordinal);

    public static Result<ProductPriceDto> InvalidUser() =>
        Result<ProductPriceDto>.FailureResult(
            "InvalidClientUser",
            "Client user metadata must match the authenticated user.");
}