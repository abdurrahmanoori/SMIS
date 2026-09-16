using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Products;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Products;
using SMIS.Application.Repositories.ProductUnits;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.Products.Commands;

public record ProductSyncCreateCommand(ProductSyncCreateDto Dto) : IRequest<Result<ProductDto>>;

public record ProductSyncUpdateCommand(string Id, ProductSyncUpdateDto Dto) : IRequest<Result<ProductDto>>;

public record ProductSyncDeleteCommand(string Id, ProductSyncDeleteDto Dto) : IRequest<Result<ProductDto>>;

internal sealed class ProductSyncCreateCommandHandler : IRequestHandler<ProductSyncCreateCommand, Result<ProductDto>>
{
    private readonly IProductRepository _repository;
    private readonly IProductUnitRepository _productUnitRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICurrentUser _currentUser;
    private readonly IMapper _mapper;

    public ProductSyncCreateCommandHandler(
        IProductRepository repository,
        IProductUnitRepository productUnitRepository,
        IUnitOfWork unitOfWork,
        ICurrentUser currentUser,
        IMapper mapper
    ) => (_repository, _productUnitRepository, _unitOfWork, _currentUser, _mapper) =
        (repository, productUnitRepository, unitOfWork, currentUser, mapper);

    public async Task<Result<ProductDto>> Handle(
        ProductSyncCreateCommand request,
        CancellationToken cancellationToken
    )
    {
        var id = ProductSyncRules.NormalizeGuid(request.Dto.Id);
        if (!ProductSyncRules.UserMatches(request.Dto.ClientCreatedBy, _currentUser) ||
            !ProductSyncRules.UserMatches(request.Dto.ClientModifiedBy, _currentUser))
            return ProductSyncRules.InvalidUser();
        var existing = await _repository.GetByIdIncludingDeletedAsync(id, cancellationToken);
        var modified = DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate);
        if (existing is not null)
        {
            if (!ProductSyncRules.CanAccess(existing, _currentUser)) return ProductSyncRules.Forbidden();
            if (modified <= existing.GetConflictModifiedUtc())
                return Result<ProductDto>.SuccessResult(_mapper.Map<ProductDto>(existing));
            if (existing.IsBaseUnitChange(request.Dto.BaseUnitId) &&
                await _repository.HasStockOrConversionsAsync(existing.Id, cancellationToken))
                return ProductSyncRules.BaseUnitIsLocked();
            var oldBaseUnitId = existing.BaseUnitId;
            ProductSyncRules.Apply(existing, request.Dto);
            await ProductSyncRules.EnsureBaseProductUnitAsync(
                existing,
                oldBaseUnitId,
                _productUnitRepository,
                cancellationToken);
            existing.SetClientCreationMetadata(request.Dto.ClientCreatedDate, request.Dto.ClientCreatedBy);
            existing.SetClientModificationMetadata(modified, request.Dto.ClientModifiedBy);
            existing.Restore();
            await _unitOfWork.SaveChanges(cancellationToken);
            return Result<ProductDto>.SuccessResult(_mapper.Map<ProductDto>(existing));
        }

        var product = Product.Create(request.Dto.Name, _currentUser.GetShopId(), request.Dto.BaseUnitId,
            request.Dto.SKU, request.Dto.IsActive, request.Dto.Description, request.Dto.Barcode, request.Dto.ImageUrl,
            request.Dto.CategoryId);
        product.Id = id;
        product.SetClientCreationMetadata(request.Dto.ClientCreatedDate, request.Dto.ClientCreatedBy);
        product.SetClientModificationMetadata(modified, request.Dto.ClientModifiedBy);
        await _repository.AddAsync(product);
        await ProductSyncRules.EnsureBaseProductUnitAsync(
            product,
            product.BaseUnitId,
            _productUnitRepository,
            cancellationToken);
        await _unitOfWork.SaveChanges(cancellationToken);
        return Result<ProductDto>.SuccessResult(_mapper.Map<ProductDto>(product));
    }
}

internal sealed class ProductSyncUpdateCommandHandler : IRequestHandler<ProductSyncUpdateCommand, Result<ProductDto>>
{
    private readonly IProductRepository _repository;
    private readonly IProductUnitRepository _productUnitRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICurrentUser _currentUser;
    private readonly IMapper _mapper;

    public ProductSyncUpdateCommandHandler(
        IProductRepository repository,
        IProductUnitRepository productUnitRepository,
        IUnitOfWork unitOfWork,
        ICurrentUser currentUser,
        IMapper mapper
    ) => (_repository, _productUnitRepository, _unitOfWork, _currentUser, _mapper) =
        (repository, productUnitRepository, unitOfWork, currentUser, mapper);

    public async Task<Result<ProductDto>> Handle(
        ProductSyncUpdateCommand request,
        CancellationToken cancellationToken
    )
    {
        if (!ProductSyncRules.UserMatches(request.Dto.ClientModifiedBy, _currentUser))
            return ProductSyncRules.InvalidUser();
        var product =
            await _repository.GetByIdIncludingDeletedAsync(ProductSyncRules.NormalizeGuid(request.Id),
                cancellationToken);
        if (product is null) return Result<ProductDto>.NotFoundResult(request.Id);
        if (!ProductSyncRules.CanAccess(product, _currentUser)) return ProductSyncRules.Forbidden();
        var modified = DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate);
        if (modified <= product.GetConflictModifiedUtc())
            return Result<ProductDto>.SuccessResult(_mapper.Map<ProductDto>(product));
        if (product.IsBaseUnitChange(request.Dto.BaseUnitId) &&
            await _repository.HasStockOrConversionsAsync(product.Id, cancellationToken))
            return ProductSyncRules.BaseUnitIsLocked();
        var oldBaseUnitId = product.BaseUnitId;
        ProductSyncRules.Apply(product, request.Dto);
        await ProductSyncRules.EnsureBaseProductUnitAsync(
            product,
            oldBaseUnitId,
            _productUnitRepository,
            cancellationToken);
        product.SetClientModificationMetadata(modified, request.Dto.ClientModifiedBy);
        product.Restore();
        await _unitOfWork.SaveChanges(cancellationToken);
        return Result<ProductDto>.SuccessResult(_mapper.Map<ProductDto>(product));
    }
}

internal sealed class ProductSyncDeleteCommandHandler : IRequestHandler<ProductSyncDeleteCommand, Result<ProductDto>>
{
    private readonly IProductRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICurrentUser _currentUser;
    private readonly IMapper _mapper;

    public ProductSyncDeleteCommandHandler(
        IProductRepository repository,
        IUnitOfWork unitOfWork,
        ICurrentUser currentUser,
        IMapper mapper
    ) => (_repository, _unitOfWork, _currentUser, _mapper) = (repository, unitOfWork, currentUser, mapper);

    public async Task<Result<ProductDto>> Handle(
        ProductSyncDeleteCommand request,
        CancellationToken cancellationToken
    )
    {
        if (!ProductSyncRules.UserMatches(request.Dto.ClientModifiedBy, _currentUser))
            return ProductSyncRules.InvalidUser();
        var product =
            await _repository.GetByIdIncludingDeletedAsync(ProductSyncRules.NormalizeGuid(request.Id),
                cancellationToken);
        if (product is null) return Result<ProductDto>.NotFoundResult(request.Id);
        if (!ProductSyncRules.CanAccess(product, _currentUser)) return ProductSyncRules.Forbidden();
        var modified = DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate);
        if (modified <= product.GetConflictModifiedUtc())
            return Result<ProductDto>.SuccessResult(_mapper.Map<ProductDto>(product));
        var referenceCount = await _repository.CountReferencesAsync(
            product.Id,
            cancellationToken);
        if (referenceCount > 0)
            return Result<ProductDto>.FailureResult(
                "ProductInUse",
                $"Product is used by {referenceCount} record(s). Remove those references before deleting the product.");
        product.SetClientModificationMetadata(modified, request.Dto.ClientModifiedBy);
        await _repository.RemoveAsync(product);
        await _unitOfWork.SaveChanges(cancellationToken);
        return Result<ProductDto>.SuccessResult(_mapper.Map<ProductDto>(product));
    }
}

internal static class ProductSyncRules
{
    /// <summary>
    /// Normalizes client IDs to the canonical dashed GUID representation so the same
    /// logical key is not treated as different merely because of formatting/casing.
    /// </summary>
    public static string NormalizeGuid(
        string value
    ) => Guid.Parse(value).ToString("D");

    /// <summary>
    /// Client audit metadata may be omitted, but when supplied it must describe the
    /// authenticated user. This prevents one offline device from impersonating another user.
    /// </summary>
    public static bool UserMatches(
        string? value,
        ICurrentUser currentUser
    ) => string.IsNullOrWhiteSpace(value) || string.Equals(value.Trim(), currentUser.GetId(), StringComparison.Ordinal);

    public static bool CanAccess(
        Product product,
        ICurrentUser currentUser
    ) => currentUser.IsSuperAdmin() || product.ShopId == currentUser.GetShopId();

    public static void Apply(
        Product product,
        ProductSyncUpdateDto dto
    )
    {
        // The caller performs the stock/conversion lock check before this method.
        // Passing false here avoids duplicating repository knowledge inside the domain object.
        product.SetName(dto.Name);
        product.ChangeBaseUnit(dto.BaseUnitId, hasStockOrConversions: false);
        product.SetSKU(dto.SKU);
        product.SetDescription(dto.Description);
        product.SetBarcode(dto.Barcode);
        product.SetImageUrl(dto.ImageUrl);
        product.SetCategoryId(dto.CategoryId);
        if (dto.IsActive) product.Activate();
        else product.Deactivate();
    }

    public static async Task EnsureBaseProductUnitAsync(
        Product product,
        string oldBaseUnitId,
        IProductUnitRepository productUnits,
        CancellationToken cancellationToken)
    {
        // Every Product must have exactly one ProductUnit that represents its base unit
        // with a factor of 1. Sync creation/update repairs that invariant automatically.
        var baseProductUnit = await productUnits.GetFirstOrDefaultAsync(
            item => item.ProductId == product.Id && item.UnitOfMeasureId == oldBaseUnitId);

        if (baseProductUnit is null)
        {
            baseProductUnit = ProductUnit.Create(product.Id, product.BaseUnitId, 1m);
            await productUnits.AddAsync(baseProductUnit);
        }
        else
        {
            // When a base unit is changed before the product has stock/conversion history,
            // reuse the old base ProductUnit instead of leaving a stale factor-1 row behind.
            baseProductUnit.SetUnitOfMeasureId(product.BaseUnitId);
            baseProductUnit.SetBaseUnitQuantity(1m);
        }

        baseProductUnit.SetProductName(product.Name);
    }

    public static Result<ProductDto> InvalidUser() => Result<ProductDto>.FailureResult("InvalidClientUser",
        "Client user metadata must match the authenticated user.");

    public static Result<ProductDto> Forbidden() =>
        Result<ProductDto>.FailureResult("Forbidden", "You can only synchronize products from your own shop.");

    public static Result<ProductDto> BaseUnitIsLocked() =>
        Result<ProductDto>.FailureResult(
            "BaseUnitChangeNotAllowed",
            "Base unit cannot be changed after stock or product-unit conversions exist.");
}
