using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Products;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Products;
using SMIS.Application.Repositories.ProductUnits;
using SMIS.Application.Services;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.Products.Commands;

public record ProductSyncCreateCommand(ProductSyncCreateDto Dto) : IRequest<Result<ProductDto>>;

public record ProductSyncUpdateCommand(string Id, ProductSyncUpdateDto Dto) : IRequest<Result<ProductDto>>;

public record ProductSyncDeleteCommand(string Id, ProductSyncDeleteDto Dto) : IRequest<Result<ProductDto>>;

internal sealed class ProductSyncCreateCommandHandler : IRequestHandler<ProductSyncCreateCommand, Result<ProductDto>>
{
    private readonly IProductRepository _repository;
    private readonly IApplicationDbContext _db;
    private readonly IProductUnitRepository _productUnitRepository;
    private readonly ICurrentUser _currentUser;
    private readonly IMapper _mapper;

    public ProductSyncCreateCommandHandler(
        IProductRepository repository,
        IApplicationDbContext db,
        IProductUnitRepository productUnitRepository,
        ICurrentUser currentUser,
        IMapper mapper
    ) => (_repository, _db, _productUnitRepository, _currentUser, _mapper) =
        (repository, db, productUnitRepository, currentUser, mapper);

    public async Task<Result<ProductDto>> Handle(
        ProductSyncCreateCommand request,
        CancellationToken cancellationToken
    )
    {
        var id = ProductSyncRules.NormalizeGuid(request.Dto.Id);
        if (!ProductSyncRules.UserMatches(request.Dto.ClientCreatedBy, _currentUser) ||
            !ProductSyncRules.UserMatches(request.Dto.ClientModifiedBy, _currentUser))
            return ProductSyncRules.InvalidUser();
        var existing = await _db.Products
            .IgnoreQueryFilters()
            .FirstOrDefaultAsync(product => product.Id == id, cancellationToken);
        var modified = DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate);
        if (existing is not null)
        {
            if (!ProductSyncRules.CanAccess(existing, _currentUser)) return ProductSyncRules.Forbidden();
            if (modified <= existing.GetConflictModifiedUtc())
                return Result<ProductDto>.SuccessResult(_mapper.Map<ProductDto>(existing));
            if (existing.IsBaseUnitChange(request.Dto.BaseUnitId) &&
                await _repository.HasStockOrConversionsAsync(existing.Id, cancellationToken))
                return ProductCommandRules.BaseUnitIsLocked();
            var oldBaseUnitId = existing.BaseUnitId;
            ProductCommandRules.Apply(existing, request.Dto);
            await ProductCommandRules.EnsureBaseProductUnitAsync(
                existing,
                oldBaseUnitId,
                _productUnitRepository,
                cancellationToken);
            existing.SetClientCreationMetadata(request.Dto.ClientCreatedDate, request.Dto.ClientCreatedBy);
            existing.SetClientModificationMetadata(modified, request.Dto.ClientModifiedBy);
            existing.Restore();
            await _db.SaveChangesAsync(cancellationToken);
            return Result<ProductDto>.SuccessResult(_mapper.Map<ProductDto>(existing));
        }

        var product = ProductCommandRules.Create(request.Dto, _currentUser.GetShopId());
        product.Id = id;
        product.SetClientCreationMetadata(request.Dto.ClientCreatedDate, request.Dto.ClientCreatedBy);
        product.SetClientModificationMetadata(modified, request.Dto.ClientModifiedBy);
        await _repository.AddAsync(product);
        await ProductCommandRules.EnsureBaseProductUnitAsync(
            product,
            product.BaseUnitId,
            _productUnitRepository,
            cancellationToken);
        await _db.SaveChangesAsync(cancellationToken);
        return Result<ProductDto>.SuccessResult(_mapper.Map<ProductDto>(product));
    }
}

internal sealed class ProductSyncUpdateCommandHandler : IRequestHandler<ProductSyncUpdateCommand, Result<ProductDto>>
{
    private readonly IProductRepository _repository;
    private readonly IApplicationDbContext _db;
    private readonly IProductUnitRepository _productUnitRepository;
    private readonly ICurrentUser _currentUser;
    private readonly IMapper _mapper;

    public ProductSyncUpdateCommandHandler(
        IProductRepository repository,
        IApplicationDbContext db,
        IProductUnitRepository productUnitRepository,
        ICurrentUser currentUser,
        IMapper mapper
    ) => (_repository, _db, _productUnitRepository, _currentUser, _mapper) =
        (repository, db, productUnitRepository, currentUser, mapper);

    public async Task<Result<ProductDto>> Handle(
        ProductSyncUpdateCommand request,
        CancellationToken cancellationToken
    )
    {
        if (!ProductSyncRules.UserMatches(request.Dto.ClientModifiedBy, _currentUser))
            return ProductSyncRules.InvalidUser();
        var id = ProductSyncRules.NormalizeGuid(request.Id);
        var product = await _db.Products
            .IgnoreQueryFilters()
            .FirstOrDefaultAsync(value => value.Id == id, cancellationToken);
        if (product is null) return Result<ProductDto>.NotFoundResult(request.Id);
        if (!ProductSyncRules.CanAccess(product, _currentUser)) return ProductSyncRules.Forbidden();
        var modified = DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate);
        if (modified <= product.GetConflictModifiedUtc())
            return Result<ProductDto>.SuccessResult(_mapper.Map<ProductDto>(product));
        if (product.IsBaseUnitChange(request.Dto.BaseUnitId) &&
            await _repository.HasStockOrConversionsAsync(product.Id, cancellationToken))
            return ProductCommandRules.BaseUnitIsLocked();
        var oldBaseUnitId = product.BaseUnitId;
        ProductCommandRules.Apply(product, request.Dto);
        await ProductCommandRules.EnsureBaseProductUnitAsync(
            product,
            oldBaseUnitId,
            _productUnitRepository,
            cancellationToken);
        product.SetClientModificationMetadata(modified, request.Dto.ClientModifiedBy);
        product.Restore();
        await _db.SaveChangesAsync(cancellationToken);
        return Result<ProductDto>.SuccessResult(_mapper.Map<ProductDto>(product));
    }
}

internal sealed class ProductSyncDeleteCommandHandler : IRequestHandler<ProductSyncDeleteCommand, Result<ProductDto>>
{
    private readonly IProductRepository _repository;
    private readonly IApplicationDbContext _db;
    private readonly ICurrentUser _currentUser;
    private readonly IMapper _mapper;

    public ProductSyncDeleteCommandHandler(
        IProductRepository repository,
        IApplicationDbContext db,
        ICurrentUser currentUser,
        IMapper mapper
    ) => (_repository, _db, _currentUser, _mapper) = (repository, db, currentUser, mapper);

    public async Task<Result<ProductDto>> Handle(
        ProductSyncDeleteCommand request,
        CancellationToken cancellationToken
    )
    {
        if (!ProductSyncRules.UserMatches(request.Dto.ClientModifiedBy, _currentUser))
            return ProductSyncRules.InvalidUser();
        var id = ProductSyncRules.NormalizeGuid(request.Id);
        var product = await _db.Products
            .IgnoreQueryFilters()
            .FirstOrDefaultAsync(value => value.Id == id, cancellationToken);
        if (product is null) return Result<ProductDto>.NotFoundResult(request.Id);
        if (!ProductSyncRules.CanAccess(product, _currentUser)) return ProductSyncRules.Forbidden();
        var modified = DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate);
        if (modified < product.GetConflictModifiedUtc())
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
        await _db.SaveChangesAsync(cancellationToken);
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
    ) => product.ShopId == currentUser.GetShopId();

    public static Result<ProductDto> InvalidUser() => Result<ProductDto>.FailureResult("InvalidClientUser",
        "Client user metadata must match the authenticated user.");

    public static Result<ProductDto> Forbidden() =>
        Result<ProductDto>.FailureResult("Forbidden", "You can only synchronize products from your own shop.");
}