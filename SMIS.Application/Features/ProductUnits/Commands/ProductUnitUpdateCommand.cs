using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.ProductUnits;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Products;
using SMIS.Application.Repositories.ProductUnits;
using SMIS.Application.Repositories.Shops;
using SMIS.Application.Repositories.UnitOfMeasures;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.ProductUnits.Commands
{
    public record ProductUnitUpdateCommand(string Id, ProductUnitCreateDto ProductUnitCreateDto) : IRequest<Result<ProductUnitDto>>;

    internal sealed class ProductUnitUpdateCommandHandler : IRequestHandler<ProductUnitUpdateCommand, Result<ProductUnitDto>>
    {
        private readonly IProductUnitRepository _productUnitRepository;
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfMeasureRepository _unitOfMeasureRepository;
        private readonly IShopRepository _shopRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductUnitUpdateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IProductUnitRepository productUnitRepository, IProductRepository productRepository, IUnitOfMeasureRepository unitOfMeasureRepository, IShopRepository shopRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _productUnitRepository = productUnitRepository;
            _productRepository = productRepository;
            _unitOfMeasureRepository = unitOfMeasureRepository;
            _shopRepository = shopRepository;
        }

        public async Task<Result<ProductUnitDto>> Handle(ProductUnitUpdateCommand request, CancellationToken cancellationToken)
        {
            var entity = await _productUnitRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result<ProductUnitDto>.NotFoundResult(nameof(ProductUnitDto.Id));
            }

            _mapper.Map(request.ProductUnitCreateDto, entity);
            
            // Update name fields
            var shop = await _shopRepository.GetByIdAsync(request.ProductUnitCreateDto.ShopId);
            entity.ShopName = shop?.Name;
            
            var product = await _productRepository.GetByIdAsync(request.ProductUnitCreateDto.ProductId);
            entity.ProductName = product?.Name;
            
            var unit = await _unitOfMeasureRepository.GetByIdAsync(request.ProductUnitCreateDto.UnitOfMeasureId);
            entity.UnitName = unit?.Name;
            
            await _unitOfWork.SaveChanges(cancellationToken);

            var dto = _mapper.Map<ProductUnitDto>(entity);
            return Result<ProductUnitDto>.SuccessResult(dto);
        }
    }
}