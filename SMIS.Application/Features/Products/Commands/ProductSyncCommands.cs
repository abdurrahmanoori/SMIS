using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Products;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Products;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.Products.Commands;

public record ProductSyncCreateCommand(ProductSyncCreateDto Dto) : IRequest<Result<ProductDto>>;

public record ProductSyncUpdateCommand(string Id, ProductSyncUpdateDto Dto) : IRequest<Result<ProductDto>>;

public record ProductSyncDeleteCommand(string Id, ProductSyncDeleteDto Dto) : IRequest<Result<ProductDto>>;

internal sealed class ProductSyncCreateCommandHandler : IRequestHandler<ProductSyncCreateCommand, Result<ProductDto>>
{
    private readonly IProductRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICurrentUser _currentUser;
    private readonly IMapper _mapper;

    public ProductSyncCreateCommandHandler(
        IProductRepository repository,
        IUnitOfWork unitOfWork,
        ICurrentUser currentUser,
        IMapper mapper
    ) => (_repository, _unitOfWork, _currentUser, _mapper) = (repository, unitOfWork, currentUser, mapper);

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
            ProductSyncRules.Apply(existing, request.Dto);
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
        await _unitOfWork.SaveChanges(cancellationToken);
        return Result<ProductDto>.SuccessResult(_mapper.Map<ProductDto>(product));
    }
}

internal sealed class ProductSyncUpdateCommandHandler : IRequestHandler<ProductSyncUpdateCommand, Result<ProductDto>>
{
    private readonly IProductRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICurrentUser _currentUser;
    private readonly IMapper _mapper;

    public ProductSyncUpdateCommandHandler(
        IProductRepository repository,
        IUnitOfWork unitOfWork,
        ICurrentUser currentUser,
        IMapper mapper
    ) => (_repository, _unitOfWork, _currentUser, _mapper) = (repository, unitOfWork, currentUser, mapper);

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
        ProductSyncRules.Apply(product, request.Dto);
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
        product.SetClientModificationMetadata(modified, request.Dto.ClientModifiedBy);
        await _repository.RemoveAsync(product);
        await _unitOfWork.SaveChanges(cancellationToken);
        return Result<ProductDto>.SuccessResult(_mapper.Map<ProductDto>(product));
    }
}

internal static class ProductSyncRules
{
    public static string NormalizeGuid(
        string value
    ) => Guid.Parse(value).ToString("D");

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
        product.SetName(dto.Name);
        product.SetBaseUnitId(dto.BaseUnitId);
        product.SetSKU(dto.SKU);
        product.SetDescription(dto.Description);
        product.SetBarcode(dto.Barcode);
        product.SetImageUrl(dto.ImageUrl);
        product.SetCategoryId(dto.CategoryId);
        if (dto.IsActive) product.Activate();
        else product.Deactivate();
    }

    public static Result<ProductDto> InvalidUser() => Result<ProductDto>.FailureResult("InvalidClientUser",
        "Client user metadata must match the authenticated user.");

    public static Result<ProductDto> Forbidden() =>
        Result<ProductDto>.FailureResult("Forbidden", "You can only synchronize products from your own shop.");
}