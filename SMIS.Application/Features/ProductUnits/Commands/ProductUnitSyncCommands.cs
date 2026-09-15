using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.ProductUnits;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Products;
using SMIS.Application.Repositories.ProductUnits;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.ProductUnits.Commands;

public record ProductUnitSyncCreateCommand(ProductUnitSyncCreateDto Dto) : IRequest<Result<ProductUnitDto>>;
public record ProductUnitSyncUpdateCommand(string Id, ProductUnitSyncUpdateDto Dto) : IRequest<Result<ProductUnitDto>>;
public record ProductUnitSyncDeleteCommand(string Id, ProductUnitSyncDeleteDto Dto) : IRequest<Result<ProductUnitDto>>;

internal sealed class ProductUnitSyncCreateCommandHandler : IRequestHandler<ProductUnitSyncCreateCommand, Result<ProductUnitDto>>
{
    private readonly IProductUnitRepository _repository;
    private readonly IProductRepository _products;
    private readonly IUnitOfWork _uow;
    private readonly ICurrentUser _user;
    private readonly IMapper _mapper;

    public ProductUnitSyncCreateCommandHandler(
        IProductUnitRepository repository,
        IProductRepository products,
        IUnitOfWork uow,
        ICurrentUser user,
        IMapper mapper)
    {
        _repository = repository;
        _products = products;
        _uow = uow;
        _user = user;
        _mapper = mapper;
    }

    public async Task<Result<ProductUnitDto>> Handle(ProductUnitSyncCreateCommand request, CancellationToken ct)
    {
        if (!ProductUnitSyncRules.User(request.Dto.ClientCreatedBy, _user) ||
            !ProductUnitSyncRules.User(request.Dto.ClientModifiedBy, _user))
            return ProductUnitSyncRules.InvalidUser();

        var product = await ProductUnitSyncRules.GetAccessibleProductAsync(request.Dto.ProductId, _products, _user);
        if (product is null) return ProductUnitSyncRules.Forbidden();
        if (ProductUnitSyncRules.IsInvalidBaseQuantity(product, request.Dto.UnitOfMeasureId, request.Dto.BaseUnitQuantity))
            return ProductUnitCommandRules.BaseUnitMustEqualOne();

        var id = ProductUnitSyncRules.Id(request.Dto.Id);
        var modified = DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate);
        var value = await _repository.GetByIdIncludingDeletedAsync(id, ct);

        if (value is not null)
        {
            if (modified <= value.GetConflictModifiedUtc())
                return Result<ProductUnitDto>.SuccessResult(_mapper.Map<ProductUnitDto>(value));

            var guard = await ProductUnitSyncRules.ValidateMutationAsync(value, request.Dto, _repository, _products, _user, ct);
            if (guard is not null) return guard;

            ProductUnitSyncRules.Apply(value, request.Dto);
            value.SetClientCreationMetadata(request.Dto.ClientCreatedDate, request.Dto.ClientCreatedBy);
            value.SetClientModificationMetadata(modified, request.Dto.ClientModifiedBy);
            value.Restore();
            await _uow.SaveChanges(ct);
            return Result<ProductUnitDto>.SuccessResult(_mapper.Map<ProductUnitDto>(value));
        }

        if (await _repository.ExistsPairAsync(request.Dto.ProductId, request.Dto.UnitOfMeasureId, null, ct))
            return ProductUnitSyncRules.DuplicatePair();

        value = ProductUnit.Create(request.Dto.ProductId, request.Dto.UnitOfMeasureId, request.Dto.BaseUnitQuantity);
        value.Id = id;
        value.SetProductName(product.Name);
        value.SetClientCreationMetadata(request.Dto.ClientCreatedDate, request.Dto.ClientCreatedBy);
        value.SetClientModificationMetadata(modified, request.Dto.ClientModifiedBy);
        await _repository.AddAsync(value);
        await _uow.SaveChanges(ct);
        return Result<ProductUnitDto>.SuccessResult(_mapper.Map<ProductUnitDto>(value));
    }
}

internal sealed class ProductUnitSyncUpdateCommandHandler : IRequestHandler<ProductUnitSyncUpdateCommand, Result<ProductUnitDto>>
{
    private readonly IProductUnitRepository _repository;
    private readonly IProductRepository _products;
    private readonly IUnitOfWork _uow;
    private readonly ICurrentUser _user;
    private readonly IMapper _mapper;

    public ProductUnitSyncUpdateCommandHandler(
        IProductUnitRepository repository,
        IProductRepository products,
        IUnitOfWork uow,
        ICurrentUser user,
        IMapper mapper)
    {
        _repository = repository;
        _products = products;
        _uow = uow;
        _user = user;
        _mapper = mapper;
    }

    public async Task<Result<ProductUnitDto>> Handle(ProductUnitSyncUpdateCommand request, CancellationToken ct)
    {
        if (!ProductUnitSyncRules.User(request.Dto.ClientModifiedBy, _user))
            return ProductUnitSyncRules.InvalidUser();

        var value = await _repository.GetByIdIncludingDeletedAsync(ProductUnitSyncRules.Id(request.Id), ct);
        if (value is null) return Result<ProductUnitDto>.NotFoundResult(request.Id);

        var modified = DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate);
        if (modified <= value.GetConflictModifiedUtc())
            return Result<ProductUnitDto>.SuccessResult(_mapper.Map<ProductUnitDto>(value));

        var guard = await ProductUnitSyncRules.ValidateMutationAsync(value, request.Dto, _repository, _products, _user, ct);
        if (guard is not null) return guard;

        ProductUnitSyncRules.Apply(value, request.Dto);
        value.SetClientModificationMetadata(modified, request.Dto.ClientModifiedBy);
        value.Restore();
        await _uow.SaveChanges(ct);
        return Result<ProductUnitDto>.SuccessResult(_mapper.Map<ProductUnitDto>(value));
    }
}

internal sealed class ProductUnitSyncDeleteCommandHandler : IRequestHandler<ProductUnitSyncDeleteCommand, Result<ProductUnitDto>>
{
    private readonly IProductUnitRepository _repository;
    private readonly IProductRepository _products;
    private readonly IUnitOfWork _uow;
    private readonly ICurrentUser _user;
    private readonly IMapper _mapper;

    public ProductUnitSyncDeleteCommandHandler(
        IProductUnitRepository repository,
        IProductRepository products,
        IUnitOfWork uow,
        ICurrentUser user,
        IMapper mapper)
    {
        _repository = repository;
        _products = products;
        _uow = uow;
        _user = user;
        _mapper = mapper;
    }

    public async Task<Result<ProductUnitDto>> Handle(ProductUnitSyncDeleteCommand request, CancellationToken ct)
    {
        if (!ProductUnitSyncRules.User(request.Dto.ClientModifiedBy, _user))
            return ProductUnitSyncRules.InvalidUser();

        var value = await _repository.GetByIdIncludingDeletedAsync(ProductUnitSyncRules.Id(request.Id), ct);
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
        await _uow.SaveChanges(ct);
        return Result<ProductUnitDto>.SuccessResult(_mapper.Map<ProductUnitDto>(value));
    }
}

internal static class ProductUnitSyncRules
{
    public static string Id(string value) => Guid.Parse(value).ToString("D");

    public static bool User(string? value, ICurrentUser user) =>
        string.IsNullOrWhiteSpace(value) ||
        string.Equals(value.Trim(), user.GetId(), StringComparison.Ordinal);

    public static async Task<Product?> GetAccessibleProductAsync(
        string productId,
        IProductRepository products,
        ICurrentUser user)
    {
        var product = await products.GetByIdAsync(productId);
        return product is not null && (user.IsSuperAdmin() || product.ShopId == user.GetShopId())
            ? product
            : null;
    }

    public static bool IsInvalidBaseQuantity(Product product, string unitOfMeasureId, decimal baseUnitQuantity) =>
        string.Equals(product.BaseUnitId, unitOfMeasureId, StringComparison.Ordinal) && baseUnitQuantity != 1m;

    public static async Task<Result<ProductUnitDto>?> ValidateMutationAsync(
        ProductUnit value,
        ProductUnitSyncUpdateDto dto,
        IProductUnitRepository repository,
        IProductRepository products,
        ICurrentUser user,
        CancellationToken ct)
    {
        var currentProduct = await GetAccessibleProductAsync(value.ProductId, products, user);
        var targetProduct = await GetAccessibleProductAsync(dto.ProductId, products, user);
        if (currentProduct is null || targetProduct is null) return Forbidden();

        var changed =
            !string.Equals(value.ProductId, dto.ProductId, StringComparison.Ordinal) ||
            !string.Equals(value.UnitOfMeasureId, dto.UnitOfMeasureId, StringComparison.Ordinal) ||
            value.BaseUnitQuantity != dto.BaseUnitQuantity;

        if (string.Equals(currentProduct.BaseUnitId, value.UnitOfMeasureId, StringComparison.Ordinal) && changed)
            return ProductUnitCommandRules.BaseUnitProtected();

        if (changed && await repository.HasUsageAsync(value.Id, ct))
            return ProductUnitCommandRules.ConversionInUse();

        if (IsInvalidBaseQuantity(targetProduct, dto.UnitOfMeasureId, dto.BaseUnitQuantity))
            return ProductUnitCommandRules.BaseUnitMustEqualOne();

        if (await repository.ExistsPairAsync(dto.ProductId, dto.UnitOfMeasureId, value.Id, ct))
            return DuplicatePair();

        return null;
    }

    public static void Apply(ProductUnit value, ProductUnitSyncUpdateDto dto)
    {
        value.SetProductId(dto.ProductId);
        value.SetUnitOfMeasureId(dto.UnitOfMeasureId);
        value.SetBaseUnitQuantity(dto.BaseUnitQuantity);
    }

    public static Result<ProductUnitDto> InvalidUser() =>
        Result<ProductUnitDto>.FailureResult(
            "InvalidClientUser",
            "Client user metadata must match the authenticated user.");

    public static Result<ProductUnitDto> Forbidden() =>
        Result<ProductUnitDto>.FailureResult(
            "Forbidden",
            "You can only synchronize product units from your own shop.");

    public static Result<ProductUnitDto> DuplicatePair() =>
        Result<ProductUnitDto>.FailureResult(
            "ProductUnitAlreadyExists",
            "This unit of measurement is already configured for the selected product.");
}
