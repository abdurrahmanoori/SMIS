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
    public record ProductUnitUpdateCommand(string Id, ProductUnitCreateDto ProductUnitCreateDto) : IRequest<Result<ProductUnitDto>>;

    internal sealed class ProductUnitUpdateCommandHandler : IRequestHandler<ProductUnitUpdateCommand, Result<ProductUnitDto>>
    {
        private readonly IProductUnitRepository _productUnitRepository;
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfMeasureRepository _unitOfMeasureRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductUnitUpdateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IProductUnitRepository productUnitRepository, IProductRepository productRepository, IUnitOfMeasureRepository unitOfMeasureRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _productUnitRepository = productUnitRepository;
            _productRepository = productRepository;
            _unitOfMeasureRepository = unitOfMeasureRepository;
        }

        public async Task<Result<ProductUnitDto>> Handle(ProductUnitUpdateCommand request, CancellationToken cancellationToken)
        {
            var entity = await _productUnitRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result<ProductUnitDto>.NotFoundResult(nameof(ProductUnitDto.Id));
            }

            var currentProduct = await _productRepository.GetByIdAsync(entity.ProductId);
            if (currentProduct == null)
            {
                return Result<ProductUnitDto>.NotFoundResult(nameof(ProductUnitCreateDto.ProductId));
            }

            var isBaseProductUnit = string.Equals(
                currentProduct.BaseUnitId,
                entity.UnitOfMeasureId,
                StringComparison.Ordinal);
            var changesIdentityOrQuantity =
                !string.Equals(entity.ProductId, request.ProductUnitCreateDto.ProductId, StringComparison.Ordinal) ||
                !string.Equals(entity.UnitOfMeasureId, request.ProductUnitCreateDto.UnitOfMeasureId, StringComparison.Ordinal) ||
                entity.BaseUnitQuantity != request.ProductUnitCreateDto.BaseUnitQuantity;

            if (isBaseProductUnit && changesIdentityOrQuantity)
            {
                return ProductUnitCommandRules.BaseUnitProtected();
            }

            if (!isBaseProductUnit && changesIdentityOrQuantity &&
                await _productUnitRepository.HasUsageAsync(entity.Id, cancellationToken))
            {
                return ProductUnitCommandRules.ConversionInUse();
            }

            var targetProduct = await _productRepository.GetByIdAsync(request.ProductUnitCreateDto.ProductId);
            if (targetProduct == null)
            {
                return Result<ProductUnitDto>.NotFoundResult(nameof(ProductUnitCreateDto.ProductId));
            }

            if (string.Equals(targetProduct.BaseUnitId, request.ProductUnitCreateDto.UnitOfMeasureId, StringComparison.Ordinal) &&
                request.ProductUnitCreateDto.BaseUnitQuantity != 1m)
            {
                return ProductUnitCommandRules.BaseUnitMustEqualOne();
            }

            if (await _productUnitRepository.ExistsPairAsync(
                request.ProductUnitCreateDto.ProductId,
                request.ProductUnitCreateDto.UnitOfMeasureId,
                entity.Id,
                cancellationToken))
            {
                return ProductUnitCommandRules.DuplicatePair();
            }

            // Update using domain methods
            entity.SetProductId(request.ProductUnitCreateDto.ProductId);
            entity.SetUnitOfMeasureId(request.ProductUnitCreateDto.UnitOfMeasureId);
            entity.SetBaseUnitQuantity(request.ProductUnitCreateDto.BaseUnitQuantity);
            
            // Update name fields using domain methods
            entity.SetProductName(targetProduct.Name);
            
            var unit = await _unitOfMeasureRepository.GetByIdAsync(request.ProductUnitCreateDto.UnitOfMeasureId);
            entity.SetUnitName(unit?.Name);
            entity.ClearClientModificationMetadata();
            
            await _unitOfWork.SaveChanges(cancellationToken);

            var dto = _mapper.Map<ProductUnitDto>(entity);
            return Result<ProductUnitDto>.SuccessResult(dto);
        }
    }
}
