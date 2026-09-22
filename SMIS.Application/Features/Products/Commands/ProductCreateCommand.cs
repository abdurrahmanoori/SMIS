using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Products;
using SMIS.Application.Extensions;
using SMIS.Application.Repositories.Categories;
using SMIS.Application.Repositories.Localization;
using SMIS.Application.Repositories.Products;
using SMIS.Application.Repositories.ProductUnits;
using SMIS.Application.Repositories.Shops;
using SMIS.Application.Repositories.UnitOfMeasures;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Services;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.Products.Commands;

public record ProductCreateCommand(ProductCreateDto ProductCreateDto) : IRequest<Result<ProductDto>>;

internal sealed class ProductCreateCommandHandler : IRequestHandler<ProductCreateCommand, Result<ProductDto>>
{
    private readonly IProductRepository _productRepository;
    private readonly ITranslationKeyRepository _translationKeyRepository;
    private readonly IShopRepository _shopRepository;
    private readonly IUnitOfMeasureRepository _unitOfMeasureRepository;
    private readonly IProductUnitRepository _productUnitRepository;
    private readonly ICategoryRepository _categoryRepository;
    private readonly IApplicationDbContext _db;
    private readonly IMapper _mapper;
    private readonly ICurrentUser _currentUser;

    public ProductCreateCommandHandler(
        IApplicationDbContext db,
        IMapper mapper,
        IProductRepository productRepository,
        ITranslationKeyRepository translationKeyRepository,
        IShopRepository shopRepository,
        IUnitOfMeasureRepository unitOfMeasureRepository,
        ICategoryRepository categoryRepository,
        IProductUnitRepository productUnitRepository,
        ICurrentUser currentUser
    )
    {
        _db = db;
        _mapper = mapper;
        _productRepository = productRepository;
        _translationKeyRepository = translationKeyRepository;
        _shopRepository = shopRepository;
        _unitOfMeasureRepository = unitOfMeasureRepository;
        _categoryRepository = categoryRepository;
        _productUnitRepository = productUnitRepository;
        _currentUser = currentUser;
    }

    public async Task<Result<ProductDto>> Handle(
        ProductCreateCommand request,
        CancellationToken cancellationToken
    )
    {
        await _translationKeyRepository.AddTranslationKeysForEntity(request.ProductCreateDto);

        var activeShopId = _currentUser.GetShopId();
        if (string.IsNullOrWhiteSpace(activeShopId))
            return Result<ProductDto>.FailureResult("ShopContextRequired", "An active shop is required.");

        var entity = ProductCommandRules.Create(request.ProductCreateDto, activeShopId);

        // Populate name fields
        var shop = await _shopRepository.GetByIdAsync(activeShopId);
        entity.ShopName = shop?.Name;

        var unit = await _unitOfMeasureRepository.GetByIdAsync(request.ProductCreateDto.BaseUnitId);
        entity.BaseUnitName = unit?.Name;

        var category = await _categoryRepository.GetByIdAsync(request.ProductCreateDto.CategoryId);
        entity.CategoryName = category?.Name;

        await _productRepository.AddAsync(entity);

        var baseProductUnit = ProductUnit.Create(entity.Id, entity.BaseUnitId, 1m);
        baseProductUnit.SetProductName(entity.Name);
        baseProductUnit.SetUnitName(unit?.Name);
        await _productUnitRepository.AddAsync(baseProductUnit);

        await _db.SaveChangesAsync(cancellationToken);

        return Result<ProductDto>.SuccessResult(_mapper.Map<ProductDto>(entity));
    }
}