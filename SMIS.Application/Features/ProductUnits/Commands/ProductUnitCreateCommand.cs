using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.ProductUnits;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Products;
using SMIS.Application.Repositories.ProductUnits;
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
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductUnitCreateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IProductUnitRepository productUnitRepository, IProductRepository productRepository, IUnitOfMeasureRepository unitOfMeasureRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _productUnitRepository = productUnitRepository;
            _productRepository = productRepository;
            _unitOfMeasureRepository = unitOfMeasureRepository;
        }

        public async Task<Result<ProductUnitDto>> Handle(ProductUnitCreateCommand request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.ProductUnitCreateDto.ProductId);
            if (product == null)
            {
                return Result<ProductUnitDto>.NotFoundResult(nameof(ProductUnitCreateDto.ProductId));
            }

            if (string.Equals(product.BaseUnitId, request.ProductUnitCreateDto.UnitOfMeasureId, StringComparison.Ordinal) &&
                request.ProductUnitCreateDto.BaseUnitQuantity != 1m)
            {
                return ProductUnitCommandRules.BaseUnitMustEqualOne();
            }

            if (await _productUnitRepository.ExistsPairAsync(
                request.ProductUnitCreateDto.ProductId,
                request.ProductUnitCreateDto.UnitOfMeasureId,
                cancellationToken: cancellationToken))
            {
                return ProductUnitCommandRules.DuplicatePair();
            }

            var entity = _mapper.Map<ProductUnit>(request.ProductUnitCreateDto);
            
            // Populate name fields using domain methods
            entity.SetProductName(product?.Name);
            
            var unit = await _unitOfMeasureRepository.GetByIdAsync(request.ProductUnitCreateDto.UnitOfMeasureId);
            entity.SetUnitName(unit?.Name);
            
            await _productUnitRepository.AddAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);

            return Result<ProductUnitDto>.SuccessResult(_mapper.Map<ProductUnitDto>(entity));
        }
    }

    internal static class ProductUnitCommandRules
    {
        public static Result<ProductUnitDto> DuplicatePair() =>
            Result<ProductUnitDto>.FailureResult(
                "ProductUnitAlreadyExists",
                "This unit of measurement is already configured for the selected product.");

        public static Result<ProductUnitDto> BaseUnitProtected() =>
            Result<ProductUnitDto>.FailureResult(
                "BaseProductUnitProtected",
                "The product's base-unit mapping is managed by the product and cannot be changed or deleted directly.");

        public static Result<ProductUnitDto> BaseUnitMustEqualOne() =>
            Result<ProductUnitDto>.FailureResult(
                "InvalidBaseUnitQuantity",
                "The product's base unit must have BaseUnitQuantity = 1.");

        public static Result<ProductUnitDto> ConversionInUse() =>
            Result<ProductUnitDto>.FailureResult(
                "ProductUnitInUse",
                "This product-unit conversion has pricing or inventory history and cannot be changed or deleted.");
    }
}
