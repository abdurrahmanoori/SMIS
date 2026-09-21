using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Products;
using SMIS.Application.Extensions;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Categories;
using SMIS.Application.Repositories.Localization;
using SMIS.Application.Repositories.Products;
using SMIS.Application.Repositories.ProductUnits;
using SMIS.Application.Repositories.Shops;
using SMIS.Application.Repositories.UnitOfMeasures;

namespace SMIS.Application.Features.Products.Commands
{
    public record ProductUpdateCommand(string Id, ProductCreateDto ProductCreateDto) : IRequest<Result<ProductDto>>;

    internal sealed class ProductUpdateCommandHandler : IRequestHandler<ProductUpdateCommand, Result<ProductDto>>
    {
        private readonly IProductRepository _productRepository;
        private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly IShopRepository _shopRepository;
        private readonly IUnitOfMeasureRepository _unitOfMeasureRepository;
        private readonly IProductUnitRepository _productUnitRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductUpdateCommandHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IProductRepository productRepository,
            ITranslationKeyRepository translationKeyRepository,
            IShopRepository shopRepository,
            IUnitOfMeasureRepository unitOfMeasureRepository,
            ICategoryRepository categoryRepository,
            IProductUnitRepository productUnitRepository
        )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _productRepository = productRepository;
            _translationKeyRepository = translationKeyRepository;
            _shopRepository = shopRepository;
            _unitOfMeasureRepository = unitOfMeasureRepository;
            _categoryRepository = categoryRepository;
            _productUnitRepository = productUnitRepository;
        }

        public async Task<Result<ProductDto>> Handle(
            ProductUpdateCommand request,
            CancellationToken cancellationToken
        )
        {
            var entity = await _productRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result<ProductDto>.NotFoundResult(nameof(ProductDto.Id));
            }

            if (entity.IsBaseUnitChange(request.ProductCreateDto.BaseUnitId) &&
                await _productRepository.HasStockOrConversionsAsync(entity.Id, cancellationToken))
            {
                return ProductCommandRules.BaseUnitIsLocked();
            }

            await _translationKeyRepository.AddTranslationKeysForChangedProperties(request.ProductCreateDto, entity);

            var oldBaseUnitId = entity.BaseUnitId;
            var baseUnitChanged = ProductCommandRules.Apply(entity, request.ProductCreateDto);

            // Update name fields
            var shop = await _shopRepository.GetByIdAsync(entity.ShopId);
            entity.ShopName = shop?.Name;

            var unit = await _unitOfMeasureRepository.GetByIdAsync(request.ProductCreateDto.BaseUnitId);
            entity.BaseUnitName = unit?.Name;

            if (baseUnitChanged)
            {
                var baseProductUnit = await ProductCommandRules.EnsureBaseProductUnitAsync(
                    entity,
                    oldBaseUnitId,
                    _productUnitRepository,
                    cancellationToken);
                baseProductUnit.SetUnitName(unit?.Name);
                baseProductUnit.ClearClientModificationMetadata();
            }

            var category = await _categoryRepository.GetByIdAsync(request.ProductCreateDto.CategoryId);
            entity.CategoryName = category?.Name;

            // A direct API edit becomes the current server-originated version.
            entity.ClearClientModificationMetadata();

            await _unitOfWork.SaveChanges(cancellationToken);

            var dto = _mapper.Map<ProductDto>(entity);
            return Result<ProductDto>.SuccessResult(dto);
        }
    }
}