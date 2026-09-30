using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.Repositories.Products;
using SMIS.Application.Repositories.ProductUnits;
using SMIS.Application.Services;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.ProductUnits.Commands
{
    public record ProductUnitDeleteCommand(string Id) : IRequest<Result>;

    internal sealed class ProductUnitDeleteCommandHandler : IRequestHandler<ProductUnitDeleteCommand, Result>
    {
        private readonly IProductUnitRepository _productUnitRepository;
        private readonly IProductRepository _productRepository;
        private readonly IApplicationDbContext _db;

        public ProductUnitDeleteCommandHandler(
            IApplicationDbContext db,
            IProductUnitRepository productUnitRepository,
            IProductRepository productRepository
        )
        {
            _db = db;
            _productUnitRepository = productUnitRepository;
            _productRepository = productRepository;
        }

        public async Task<Result> Handle(
            ProductUnitDeleteCommand request,
            CancellationToken cancellationToken
        )
        {
            var entity = await _productUnitRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result.NotFound(request?.Id);
            }

            var product = await _productRepository.GetByIdAsync(entity.ProductId);
            if (product != null && string.Equals(product.BaseUnitId, entity.UnitOfMeasureId, StringComparison.Ordinal))
            {
                return Result.BusinessRule(
                    "BaseProductUnitProtected",
                    "The product's base-unit mapping is managed by the product and cannot be deleted directly.");
            }

            if (await _productUnitRepository.HasUsageAsync(entity.Id, cancellationToken))
            {
                return Result.BusinessRule(
                    "ProductUnitInUse",
                    "This product-unit conversion has pricing or inventory history and cannot be deleted.");
            }

            entity.ClearClientModificationMetadata();
            await _productUnitRepository.RemoveAsync(entity);
            await _db.SaveChangesAsync(cancellationToken);
            return Result.Success();
        }
    }
}