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
    public record ProductUnitCreateCommand(ProductUnitCreateDto ProductUnitCreateDto) : IRequest<Result<ProductUnitDto>>;

    internal sealed class ProductUnitCreateCommandHandler : IRequestHandler<ProductUnitCreateCommand, Result<ProductUnitDto>>
    {
        private readonly IProductUnitRepository _productUnitRepository;
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfMeasureRepository _unitOfMeasureRepository;
        private readonly IShopRepository _shopRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductUnitCreateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IProductUnitRepository productUnitRepository, IProductRepository productRepository, IUnitOfMeasureRepository unitOfMeasureRepository, IShopRepository shopRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _productUnitRepository = productUnitRepository;
            _productRepository = productRepository;
            _unitOfMeasureRepository = unitOfMeasureRepository;
            _shopRepository = shopRepository;
        }

        public async Task<Result<ProductUnitDto>> Handle(ProductUnitCreateCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<ProductUnit>(request.ProductUnitCreateDto);
            
            // Populate name fields using domain methods
            var shop = await _shopRepository.GetByIdAsync(request.ProductUnitCreateDto.ShopId);
            entity.SetShopName(shop?.Name);
            
            var product = await _productRepository.GetByIdAsync(request.ProductUnitCreateDto.ProductId);
            entity.SetProductName(product?.Name);
            
            var unit = await _unitOfMeasureRepository.GetByIdAsync(request.ProductUnitCreateDto.UnitOfMeasureId);
            entity.SetUnitName(unit?.Name);
            
            await _productUnitRepository.AddAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);

            return Result<ProductUnitDto>.SuccessResult(_mapper.Map<ProductUnitDto>(entity));
        }
    }
}