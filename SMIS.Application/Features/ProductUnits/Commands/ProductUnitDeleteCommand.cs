using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Products;
using SMIS.Application.Repositories.ProductUnits;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.ProductUnits.Commands
{
    public record ProductUnitDeleteCommand(string Id) : IRequest<Result<Unit>>;

    internal sealed class ProductUnitDeleteCommandHandler : IRequestHandler<ProductUnitDeleteCommand, Result<Unit>>
    {
        private readonly IProductUnitRepository _productUnitRepository;
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProductUnitDeleteCommandHandler(IUnitOfWork unitOfWork, IProductUnitRepository productUnitRepository, IProductRepository productRepository)
        {
            _unitOfWork = unitOfWork;
            _productUnitRepository = productUnitRepository;
            _productRepository = productRepository;
        }

        public async Task<Result<Unit>> Handle(ProductUnitDeleteCommand request, CancellationToken cancellationToken)
        {
            var entity = await _productUnitRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result<Unit>.NotFoundResult(request?.Id);
            }

            var product = await _productRepository.GetByIdAsync(entity.ProductId);
            if (product != null && string.Equals(product.BaseUnitId, entity.UnitOfMeasureId, StringComparison.Ordinal))
            {
                return Result<Unit>.FailureResult(
                    "BaseProductUnitProtected",
                    "The product's base-unit mapping is managed by the product and cannot be deleted directly.");
            }

            if (await _productUnitRepository.HasUsageAsync(entity.Id, cancellationToken))
            {
                return Result<Unit>.FailureResult(
                    "ProductUnitInUse",
                    "This product-unit conversion has pricing or inventory history and cannot be deleted.");
            }

            entity.ClearClientModificationMetadata();
            await _productUnitRepository.RemoveAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);
            return Result<Unit>.SuccessResult(Unit.Value);
        }
    }
}
