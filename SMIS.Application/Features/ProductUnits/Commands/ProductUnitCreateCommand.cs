using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.ProductUnits;
using SMIS.Application.Repositories.Products;
using SMIS.Application.Repositories.ProductUnits;
using SMIS.Application.Repositories.UnitOfMeasures;
using SMIS.Application.Services;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.ProductUnits.Commands
{
    public record ProductUnitCreateCommand(ProductUnitCreateDto ProductUnitCreateDto)
        : IRequest<Result<ProductUnitDto>>;

    internal sealed class
        ProductUnitCreateCommandHandler : IRequestHandler<ProductUnitCreateCommand, Result<ProductUnitDto>>
    {
        private readonly IProductUnitRepository _productUnitRepository;
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfMeasureRepository _unitOfMeasureRepository;
        private readonly IApplicationDbContext _db;
        private readonly IMapper _mapper;

        public ProductUnitCreateCommandHandler(
            IApplicationDbContext db,
            IMapper mapper,
            IProductUnitRepository productUnitRepository,
            IProductRepository productRepository,
            IUnitOfMeasureRepository unitOfMeasureRepository
        )
        {
            _db = db;
            _mapper = mapper;
            _productUnitRepository = productUnitRepository;
            _productRepository = productRepository;
            _unitOfMeasureRepository = unitOfMeasureRepository;
        }

        public async Task<Result<ProductUnitDto>> Handle(
            ProductUnitCreateCommand request,
            CancellationToken cancellationToken
        )
        {
            var product = await _productRepository.GetByIdAsync(request.ProductUnitCreateDto.ProductId);
            if (product == null)
            {
                return Result<ProductUnitDto>.NotFoundResult(nameof(ProductUnitCreateDto.ProductId));
            }

            var guard = await ProductUnitCommandRules.ValidateCreateAsync(
                product,
                request.ProductUnitCreateDto.ProductId,
                request.ProductUnitCreateDto.UnitOfMeasureId,
                request.ProductUnitCreateDto.BaseUnitQuantity,
                _productUnitRepository,
                cancellationToken);
            if (guard is not null) return guard;

            var entity = _mapper.Map<ProductUnit>(request.ProductUnitCreateDto);

            // Populate name fields using domain methods
            entity.SetProductName(product.Name);

            var unit = await _unitOfMeasureRepository.GetByIdAsync(request.ProductUnitCreateDto.UnitOfMeasureId);
            entity.SetUnitName(unit?.Name);

            await _productUnitRepository.AddAsync(entity);
            await _db.SaveChangesAsync(cancellationToken);

            return Result<ProductUnitDto>.SuccessResult(_mapper.Map<ProductUnitDto>(entity));
        }
    }
}