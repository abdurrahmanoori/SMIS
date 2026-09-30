using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.ProductUnits;
using SMIS.Application.Features.ProductUnits;
using SMIS.Application.Repositories.Products;
using SMIS.Application.Repositories.ProductUnits;
using SMIS.Application.Repositories.UnitOfMeasures;
using SMIS.Application.Services;

namespace SMIS.Application.Features.ProductUnits.Commands
{
    public record ProductUnitUpdateCommand(string Id, ProductUnitCreateDto ProductUnitCreateDto)
        : IRequest<Result<ProductUnitDto>>;

    internal sealed class ProductUnitUpdateCommandHandler
        : IRequestHandler<ProductUnitUpdateCommand, Result<ProductUnitDto>>
    {
        private readonly IProductUnitRepository _productUnitRepository;
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfMeasureRepository _unitOfMeasureRepository;
        private readonly IApplicationDbContext _db;

        public ProductUnitUpdateCommandHandler(
            IApplicationDbContext db,
            IProductUnitRepository productUnitRepository,
            IProductRepository productRepository,
            IUnitOfMeasureRepository unitOfMeasureRepository)
        {
            _db = db;
            _productUnitRepository = productUnitRepository;
            _productRepository = productRepository;
            _unitOfMeasureRepository = unitOfMeasureRepository;
        }

        public async Task<Result<ProductUnitDto>> Handle(ProductUnitUpdateCommand request, CancellationToken cancellationToken)
        {
            var entity = await _productUnitRepository.GetByIdAsync(request.Id);
            if (entity == null) return Result<ProductUnitDto>.NotFoundResult(nameof(ProductUnitDto.Id));

            var currentProduct = await _productRepository.GetByIdAsync(entity.ProductId);
            if (currentProduct == null) return Result<ProductUnitDto>.NotFoundResult(nameof(ProductUnitCreateDto.ProductId));

            var input = request.ProductUnitCreateDto;
            var targetProduct = await _productRepository.GetByIdAsync(input.ProductId);
            if (targetProduct == null) return Result<ProductUnitDto>.NotFoundResult(nameof(ProductUnitCreateDto.ProductId));

            var guard = await ProductUnitCommandRules.ValidateMutationAsync(
                entity, currentProduct, targetProduct, input.ProductId, input.UnitOfMeasureId,
                input.BaseUnitQuantity, _productUnitRepository, cancellationToken);
            if (guard is not null) return guard;

            ProductUnitCommandRules.Apply(entity, input.ProductId, input.UnitOfMeasureId, input.BaseUnitQuantity);
            entity.SetProductName(targetProduct.Name);
            var unit = await _unitOfMeasureRepository.GetByIdAsync(input.UnitOfMeasureId);
            entity.SetUnitName(unit?.Name);
            entity.ClearClientModificationMetadata();

            await _db.SaveChangesAsync(cancellationToken);
            return Result<ProductUnitDto>.SuccessResult(ProductUnitMapping.ToDto(entity));
        }
    }
}
