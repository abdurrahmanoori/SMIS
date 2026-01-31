using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Products;
using SMIS.Application.Extensions;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Categories;
using SMIS.Application.Repositories.Localization;
using SMIS.Application.Repositories.Products;
using SMIS.Application.Repositories.Shops;
using SMIS.Application.Repositories.UnitOfMeasures;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.Produmscts.Commands;

public record ProductCreateCommand(ProductCreateDto ProductCreateDto) : IRequest<Result<ProductDto>>;

internal sealed class ProductCreateCommandHandler : IRequestHandler<ProductCreateCommand, Result<ProductDto>>
{
    private readonly IProductRepository _productRepository;
    private readonly ITranslationKeyRepository _translationKeyRepository;
    private readonly IShopRepository _shopRepository;
    private readonly IUnitOfMeasureRepository _unitOfMeasureRepository;
    private readonly ICategoryRepository _categoryRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public ProductCreateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IProductRepository productRepository, ITranslationKeyRepository translationKeyRepository, IShopRepository shopRepository, IUnitOfMeasureRepository unitOfMeasureRepository, ICategoryRepository categoryRepository)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _productRepository = productRepository;
        _translationKeyRepository = translationKeyRepository;
        _shopRepository = shopRepository;
        _unitOfMeasureRepository = unitOfMeasureRepository;
        _categoryRepository = categoryRepository;
    }

    public async Task<Result<ProductDto>> Handle(ProductCreateCommand request, CancellationToken cancellationToken)
    {
        await _translationKeyRepository.AddTranslationKeysForEntity(request.ProductCreateDto, _unitOfWork);

        var entity = _mapper.Map<Product>(request.ProductCreateDto);
        
        // Populate name fields
        var shop = await _shopRepository.GetByIdAsync(request.ProductCreateDto.ShopId);
        entity.ShopName = shop?.Name;
        
        var unit = await _unitOfMeasureRepository.GetByIdAsync(request.ProductCreateDto.BaseUnitId);
        entity.BaseUnitName = unit?.Name;
        
        if (!string.IsNullOrWhiteSpace(request.ProductCreateDto.CategoryId))
        {
            var category = await _categoryRepository.GetByIdAsync(request.ProductCreateDto.CategoryId);
            entity.CategoryName = category?.Name;
        }
        
        await _productRepository.AddAsync(entity);
        await _unitOfWork.SaveChanges(cancellationToken);

        return Result<ProductDto>.SuccessResult(_mapper.Map<ProductDto>(entity));
    }
}