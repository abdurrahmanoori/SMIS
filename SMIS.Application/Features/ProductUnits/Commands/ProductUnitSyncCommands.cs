using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.ProductUnits;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Products;
using SMIS.Application.Repositories.ProductUnits;
using SMIS.Application.Services;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.ProductUnits.Commands;

public record ProductUnitSyncCreateCommand(ProductUnitSyncCreateDto Dto) : IRequest<Result<ProductUnitDto>>;

public record ProductUnitSyncUpdateCommand(string Id, ProductUnitSyncUpdateDto Dto) : IRequest<Result<ProductUnitDto>>;

public record ProductUnitSyncDeleteCommand(string Id, ProductUnitSyncDeleteDto Dto) : IRequest<Result<ProductUnitDto>>;

internal sealed class
    ProductUnitSyncCreateCommandHandler : IRequestHandler<ProductUnitSyncCreateCommand, Result<ProductUnitDto>>
{
    private readonly IProductUnitRepository _repository;
    private readonly IApplicationDbContext _db;
    private readonly IProductRepository _products;
    private readonly ICurrentUser _user;
    private readonly IMapper _mapper;

    public ProductUnitSyncCreateCommandHandler(
        IProductUnitRepository repository,
        IApplicationDbContext db,
        IProductRepository products,
        ICurrentUser user,
        IMapper mapper
    )
    {
        _repository = repository;
        _db = db;
        _products = products;
        _user = user;
        _mapper = mapper;
    }

    public async Task<Result<ProductUnitDto>> Handle(
        ProductUnitSyncCreateCommand request,
        CancellationToken ct
    )
    {
        if (!ProductUnitSyncRules.User(request.Dto.ClientCreatedBy, _user) ||
            !ProductUnitSyncRules.User(request.Dto.ClientModifiedBy, _user))
            return ProductUnitSyncRules.InvalidUser();

        var product = await ProductUnitSyncRules.GetAccessibleProductAsync(request.Dto.ProductId, _products, _user);
        if (product is null) return ProductUnitSyncRules.Forbidden();

        var id = ProductUnitSyncRules.Id(request.Dto.Id);
        var modified = DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate);
        var value = await _db.ProductUnits
            .IgnoreQueryFilters()
            .FirstOrDefaultAsync(productUnit => productUnit.Id == id, ct);

        if (value is not null)
        {
            if (modified <= value.GetConflictModifiedUtc())
                return Result<ProductUnitDto>.SuccessResult(_mapper.Map<ProductUnitDto>(value));

            var currentProduct =
                await ProductUnitSyncRules.GetAccessibleProductAsync(value.ProductId, _products, _user);
            var targetProduct =
                await ProductUnitSyncRules.GetAccessibleProductAsync(request.Dto.ProductId, _products, _user);
            if (currentProduct is null || targetProduct is null) return ProductUnitSyncRules.Forbidden();

            var guard = await ProductUnitCommandRules.ValidateMutationAsync(
                value,
                currentProduct,
                targetProduct,
                request.Dto.ProductId,
                request.Dto.UnitOfMeasureId,
                request.Dto.BaseUnitQuantity,
                _repository,
                ct);
            if (guard is not null) return guard;

            ProductUnitCommandRules.Apply(
                value,
                request.Dto.ProductId,
                request.Dto.UnitOfMeasureId,
                request.Dto.BaseUnitQuantity);
            value.SetClientCreationMetadata(request.Dto.ClientCreatedDate, request.Dto.ClientCreatedBy);
            value.SetClientModificationMetadata(modified, request.Dto.ClientModifiedBy);
            value.Restore();
            await _db.SaveChangesAsync(ct);
            return Result<ProductUnitDto>.SuccessResult(_mapper.Map<ProductUnitDto>(value));
        }

        var createGuard = await ProductUnitCommandRules.ValidateCreateAsync(
            product,
            request.Dto.ProductId,
            request.Dto.UnitOfMeasureId,
            request.Dto.BaseUnitQuantity,
            _repository,
            ct);
        if (createGuard is not null) return createGuard;

        value = ProductUnit.Create(request.Dto.ProductId, request.Dto.UnitOfMeasureId, request.Dto.BaseUnitQuantity);
        value.Id = id;
        value.SetProductName(product.Name);
        value.SetClientCreationMetadata(request.Dto.ClientCreatedDate, request.Dto.ClientCreatedBy);
        value.SetClientModificationMetadata(modified, request.Dto.ClientModifiedBy);
        await _repository.AddAsync(value);
        await _db.SaveChangesAsync(ct);
        return Result<ProductUnitDto>.SuccessResult(_mapper.Map<ProductUnitDto>(value));
    }
}

internal sealed class
    ProductUnitSyncUpdateCommandHandler : IRequestHandler<ProductUnitSyncUpdateCommand, Result<ProductUnitDto>>
{
    private readonly IProductUnitRepository _repository;
    private readonly IApplicationDbContext _db;
    private readonly IProductRepository _products;
    private readonly ICurrentUser _user;
    private readonly IMapper _mapper;

    public ProductUnitSyncUpdateCommandHandler(
        IProductUnitRepository repository,
        IApplicationDbContext db,
        IProductRepository products,
        ICurrentUser user,
        IMapper mapper
    )
    {
        _repository = repository;
        _db = db;
        _products = products;
        _user = user;
        _mapper = mapper;
    }

    public async Task<Result<ProductUnitDto>> Handle(
        ProductUnitSyncUpdateCommand request,
        CancellationToken ct
    )
    {
        if (!ProductUnitSyncRules.User(request.Dto.ClientModifiedBy, _user))
            return ProductUnitSyncRules.InvalidUser();

        var id = ProductUnitSyncRules.Id(request.Id);
        var value = await _db.ProductUnits
            .IgnoreQueryFilters()
            .FirstOrDefaultAsync(productUnit => productUnit.Id == id, ct);
        if (value is null) return Result<ProductUnitDto>.NotFoundResult(request.Id);

        var modified = DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate);
        if (modified <= value.GetConflictModifiedUtc())
            return Result<ProductUnitDto>.SuccessResult(_mapper.Map<ProductUnitDto>(value));

        var currentProduct = await ProductUnitSyncRules.GetAccessibleProductAsync(value.ProductId, _products, _user);
        var targetProduct =
            await ProductUnitSyncRules.GetAccessibleProductAsync(request.Dto.ProductId, _products, _user);
        if (currentProduct is null || targetProduct is null) return ProductUnitSyncRules.Forbidden();

        var guard = await ProductUnitCommandRules.ValidateMutationAsync(
            value,
            currentProduct,
            targetProduct,
            request.Dto.ProductId,
            request.Dto.UnitOfMeasureId,
            request.Dto.BaseUnitQuantity,
            _repository,
            ct);
        if (guard is not null) return guard;

        ProductUnitCommandRules.Apply(
            value,
            request.Dto.ProductId,
            request.Dto.UnitOfMeasureId,
            request.Dto.BaseUnitQuantity);
        value.SetClientModificationMetadata(modified, request.Dto.ClientModifiedBy);
        value.Restore();
        await _db.SaveChangesAsync(ct);
        return Result<ProductUnitDto>.SuccessResult(_mapper.Map<ProductUnitDto>(value));
    }
}

internal sealed class
    ProductUnitSyncDeleteCommandHandler : IRequestHandler<ProductUnitSyncDeleteCommand, Result<ProductUnitDto>>
{
    private readonly IProductUnitRepository _repository;
    private readonly IApplicationDbContext _db;
    private readonly IProductRepository _products;
    private readonly ICurrentUser _user;
    private readonly IMapper _mapper;

    public ProductUnitSyncDeleteCommandHandler(
        IProductUnitRepository repository,
        IApplicationDbContext db,
        IProductRepository products,
        ICurrentUser user,
        IMapper mapper
    )
    {
        _repository = repository;
        _db = db;
        _products = products;
        _user = user;
        _mapper = mapper;
    }

    public async Task<Result<ProductUnitDto>> Handle(
        ProductUnitSyncDeleteCommand request,
        CancellationToken ct
    )
    {
        if (!ProductUnitSyncRules.User(request.Dto.ClientModifiedBy, _user))
            return ProductUnitSyncRules.InvalidUser();

        var id = ProductUnitSyncRules.Id(request.Id);
        var value = await _db.ProductUnits
            .IgnoreQueryFilters()
            .FirstOrDefaultAsync(productUnit => productUnit.Id == id, ct);
        if (value is null) return Result<ProductUnitDto>.NotFoundResult(request.Id);

        var product = await ProductUnitSyncRules.GetAccessibleProductAsync(value.ProductId, _products, _user);
        if (product is null) return ProductUnitSyncRules.Forbidden();
        if (string.Equals(product.BaseUnitId, value.UnitOfMeasureId, StringComparison.Ordinal))
            return ProductUnitCommandRules.BaseUnitProtected();
        if (await _repository.HasUsageAsync(value.Id, ct))
            return ProductUnitCommandRules.ConversionInUse();

        var modified = DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate);
        if (modified <= value.GetConflictModifiedUtc())
            return Result<ProductUnitDto>.SuccessResult(_mapper.Map<ProductUnitDto>(value));

        value.SetClientModificationMetadata(modified, request.Dto.ClientModifiedBy);
        await _repository.RemoveAsync(value);
        await _db.SaveChangesAsync(ct);
        return Result<ProductUnitDto>.SuccessResult(_mapper.Map<ProductUnitDto>(value));
    }
}

internal static class ProductUnitSyncRules
{
    public static string Id(
        string value
    ) => Guid.Parse(value).ToString("D");

    public static bool User(
        string? value,
        ICurrentUser user
    ) =>
        string.IsNullOrWhiteSpace(value) ||
        string.Equals(value.Trim(), user.GetId(), StringComparison.Ordinal);

    public static async Task<Product?> GetAccessibleProductAsync(
        string productId,
        IProductRepository products,
        ICurrentUser user
    )
    {
        var product = await products.GetByIdAsync(productId);
        return product is not null && product.ShopId == user.GetShopId()
            ? product
            : null;
    }

    public static Result<ProductUnitDto> InvalidUser() =>
        Result<ProductUnitDto>.FailureResult(
            "InvalidClientUser",
            "Client user metadata must match the authenticated user.");

    public static Result<ProductUnitDto> Forbidden() =>
        Result<ProductUnitDto>.FailureResult(
            "Forbidden",
            "You can only synchronize product units from your own shop.");
}