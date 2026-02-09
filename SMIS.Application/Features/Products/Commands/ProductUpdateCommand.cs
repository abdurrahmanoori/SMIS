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

namespace SMIS.Application.Features.Products.Commands
{
    public record ProductUpdateCommand(string Id, ProductCreateDto ProductCreateDto) : IRequest<Result<ProductDto>>;

    internal sealed class ProductUpdateCommandHandler : IRequestHandler<ProductUpdateCommand, Result<ProductDto>>
    {
        private readonly IProductRepository _productRepository;
        private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly IShopRepository _shopRepository;
        private readonly IUnitOfMeasureRepository _unitOfMeasureRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductUpdateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IProductRepository productRepository, ITranslationKeyRepository translationKeyRepository, IShopRepository shopRepository, IUnitOfMeasureRepository unitOfMeasureRepository, ICategoryRepository categoryRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _productRepository = productRepository;
            _translationKeyRepository = translationKeyRepository;
            _shopRepository = shopRepository;
            _unitOfMeasureRepository = unitOfMeasureRepository;
            _categoryRepository = categoryRepository;
        }

        public async Task<Result<ProductDto>> Handle(ProductUpdateCommand request, CancellationToken cancellationToken)
        {
            var entity = await _productRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result<ProductDto>.NotFoundResult(nameof(ProductDto.Id));
            }

            await _translationKeyRepository.AddTranslationKeysForChangedProperties(request.ProductCreateDto, entity);
            
            // Update existing entity using domain methods
            entity.SetName(request.ProductCreateDto.Name);
            entity.SetShopId(request.ProductCreateDto.ShopId);
            entity.SetBaseUnitId(request.ProductCreateDto.BaseUnitId);
            entity.SetSKU(request.ProductCreateDto.SKU);
            entity.SetDescription(request.ProductCreateDto.Description);
            if (!string.IsNullOrWhiteSpace(request.ProductCreateDto.Barcode)) entity.SetBarcode(request.ProductCreateDto.Barcode);
            entity.SetImageUrl(request.ProductCreateDto.ImageUrl);
            entity.SetCategoryId(request.ProductCreateDto.CategoryId);
            if (request.ProductCreateDto.IsActive) entity.Activate(); else entity.Deactivate();
            
            // Update name fields
            var shop = await _shopRepository.GetByIdAsync(request.ProductCreateDto.ShopId);
            entity.ShopName = shop?.Name;
            
            var unit = await _unitOfMeasureRepository.GetByIdAsync(request.ProductCreateDto.BaseUnitId);
            entity.BaseUnitName = unit?.Name;
            
            if (!string.IsNullOrWhiteSpace(request.ProductCreateDto.CategoryId))
            {
                var category = await _categoryRepository.GetByIdAsync(request.ProductCreateDto.CategoryId);
                entity.CategoryName = category?.Name;
            }
            else
            {
                entity.CategoryName = null;
            }
            
            await _unitOfWork.SaveChanges(cancellationToken);

            var dto = _mapper.Map<ProductDto>(entity);
            return Result<ProductDto>.SuccessResult(dto);
        }
    }
}