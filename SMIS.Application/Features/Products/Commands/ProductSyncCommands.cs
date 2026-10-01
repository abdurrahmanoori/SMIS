using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Products;
using SMIS.Application.Features.Products;
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

    public ProductSyncCreateCommandHandler(
        IProductRepository repository,
        IApplicationDbContext db,
        IProductUnitRepository productUnitRepository,
        ICurrentUser currentUser
    ) => (_repository, _db, _productUnitRepository, _currentUser) =
        (repository, db, productUnitRepository, currentUser);

    public async Task<Result<ProductDto>> Handle(ProductSyncCreateCommand request, CancellationToken cancellationToken)
    {
        var id = ProductSyncRules.NormalizeGuid(request.Dto.Id);
        var existing = await _db.Products.IgnoreQueryFilters()
            .FirstOrDefaultAsync(product => product.Id == id, cancellationToken);
        var modified = DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate);
        if (existing is not null)
        {
            if (!ProductSyncRules.CanAccess(existing, _currentUser)) return ProductSyncRules.Forbidden();
            if (modified <= existing.GetConflictModifiedUtc())
                return Result<ProductDto>.Success(ProductMapping.ToDto(existing));
            if (existing.IsBaseUnitChange(request.Dto.BaseUnitId) &&
                await _repository.HasStockOrConversionsAsync(existing.Id, cancellationToken))
                return ProductCommandRules.BaseUnitIsLocked();

            var oldBaseUnitId = existing.BaseUnitId;
            ProductCommandRules.Apply(existing, request.Dto);
            await ProductCommandRules.EnsureBaseProductUnitAsync(
                existing, oldBaseUnitId, _productUnitRepository, cancellationToken);
            existing.SetClientModificationMetadata(modified);
            existing.Restore();
            await _db.SaveChangesAsync(cancellationToken);
            return Result<ProductDto>.Success(ProductMapping.ToDto(existing));
        }

        var product = ProductCommandRules.Create(request.Dto, _currentUser.GetShopId());
        product.Id = id;
        product.SetClientModificationMetadata(modified);
        await _repository.AddAsync(product);
        await ProductCommandRules.EnsureBaseProductUnitAsync(
            product, product.BaseUnitId, _productUnitRepository, cancellationToken);
        await _db.SaveChangesAsync(cancellationToken);
        return Result<ProductDto>.Success(ProductMapping.ToDto(product));
    }
}

internal sealed class ProductSyncUpdateCommandHandler : IRequestHandler<ProductSyncUpdateCommand, Result<ProductDto>>
{
    private readonly IProductRepository _repository;
    private readonly IApplicationDbContext _db;
    private readonly IProductUnitRepository _productUnitRepository;
    private readonly ICurrentUser _currentUser;

    public ProductSyncUpdateCommandHandler(
        IProductRepository repository,
        IApplicationDbContext db,
        IProductUnitRepository productUnitRepository,
        ICurrentUser currentUser
    ) => (_repository, _db, _productUnitRepository, _currentUser) =
        (repository, db, productUnitRepository, currentUser);

    public async Task<Result<ProductDto>> Handle(ProductSyncUpdateCommand request, CancellationToken cancellationToken)
    {
        var id = ProductSyncRules.NormalizeGuid(request.Id);
        var product = await _db.Products.IgnoreQueryFilters()
            .FirstOrDefaultAsync(value => value.Id == id, cancellationToken);
        if (product is null) return Result<ProductDto>.NotFound(request.Id);
        if (!ProductSyncRules.CanAccess(product, _currentUser)) return ProductSyncRules.Forbidden();
        var modified = DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate);
        if (modified <= product.GetConflictModifiedUtc())
            return Result<ProductDto>.Success(ProductMapping.ToDto(product));
        if (product.IsBaseUnitChange(request.Dto.BaseUnitId) &&
            await _repository.HasStockOrConversionsAsync(product.Id, cancellationToken))
            return ProductCommandRules.BaseUnitIsLocked();

        var oldBaseUnitId = product.BaseUnitId;
        ProductCommandRules.Apply(product, request.Dto);
        await ProductCommandRules.EnsureBaseProductUnitAsync(
            product, oldBaseUnitId, _productUnitRepository, cancellationToken);
        product.SetClientModificationMetadata(modified);
        product.Restore();
        await _db.SaveChangesAsync(cancellationToken);
        return Result<ProductDto>.Success(ProductMapping.ToDto(product));
    }
}

internal sealed class ProductSyncDeleteCommandHandler : IRequestHandler<ProductSyncDeleteCommand, Result<ProductDto>>
{
    private readonly IProductRepository _repository;
    private readonly IApplicationDbContext _db;
    private readonly ICurrentUser _currentUser;

    public ProductSyncDeleteCommandHandler(IProductRepository repository, IApplicationDbContext db, ICurrentUser currentUser)
        => (_repository, _db, _currentUser) = (repository, db, currentUser);

    public async Task<Result<ProductDto>> Handle(ProductSyncDeleteCommand request, CancellationToken cancellationToken)
    {
        var id = ProductSyncRules.NormalizeGuid(request.Id);
        var product = await _db.Products.IgnoreQueryFilters()
            .FirstOrDefaultAsync(value => value.Id == id, cancellationToken);
        if (product is null) return Result<ProductDto>.NotFound(request.Id);
        if (!ProductSyncRules.CanAccess(product, _currentUser)) return ProductSyncRules.Forbidden();
        var modified = DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate);
        if (modified < product.GetConflictModifiedUtc())
            return Result<ProductDto>.Success(ProductMapping.ToDto(product));

        var referenceCount = await _repository.CountReferencesAsync(product.Id, cancellationToken);
        if (referenceCount > 0)
            return Result<ProductDto>.BusinessRule(
                "ProductInUse",
                $"Product is used by {referenceCount} record(s). Remove those references before deleting the product.");

        product.SetClientModificationMetadata(modified);
        await _repository.RemoveAsync(product);
        await _db.SaveChangesAsync(cancellationToken);
        return Result<ProductDto>.Success(ProductMapping.ToDto(product));
    }
}

internal static class ProductSyncRules
{
    public static string NormalizeGuid(string value) => Guid.Parse(value).ToString("D");
    public static bool CanAccess(Product product, ICurrentUser currentUser) => product.ShopId == currentUser.GetShopId();
    public static Result<ProductDto> Forbidden() =>
        Result<ProductDto>.Forbidden(
            "product.sync_forbidden",
            "You can only synchronize products from your own shop.");
}
