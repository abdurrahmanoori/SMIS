using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.Repositories.Products;
using SMIS.Application.Services;

namespace SMIS.Application.Features.Products.Commands
{
    public record ProductDeleteCommand(string Id) : IRequest<Result<Unit>>;

    internal sealed class ProductDeleteCommandHandler : IRequestHandler<ProductDeleteCommand, Result<Unit>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IApplicationDbContext _db;

        public ProductDeleteCommandHandler(
            IApplicationDbContext db,
            IProductRepository productRepository
        )
        {
            _db = db;
            _productRepository = productRepository;
        }

        public async Task<Result<Unit>> Handle(
            ProductDeleteCommand request,
            CancellationToken cancellationToken
        )
        {
            var entity = await _productRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result<Unit>.NotFoundResult(request?.Id);
            }

            var referenceCount = await _productRepository.CountReferencesAsync(
                entity.Id,
                cancellationToken);
            if (referenceCount > 0)
                return Result<Unit>.FailureResult(
                    "ProductInUse",
                    $"Product is used by {referenceCount} record(s). Remove those references before deleting the product.");

            entity.ClearClientModificationMetadata();
            await _productRepository.RemoveAsync(entity);
            await _db.SaveChangesAsync(cancellationToken);
            return Result<Unit>.SuccessResult(Unit.Value);
        }
    }
}