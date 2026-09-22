using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.Repositories.Categories;
using SMIS.Application.Repositories.Products;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Services;

namespace SMIS.Application.Features.Categories.Commands
{
    public record CategoryDeleteCommand(string Id) : IRequest<Result<Unit>>;

    internal sealed class CategoryDeleteCommandHandler : IRequestHandler<CategoryDeleteCommand, Result<Unit>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IApplicationDbContext _db;
        private readonly ICurrentUser _currentUser;
        private readonly IProductRepository _productRepository;

        public CategoryDeleteCommandHandler(
            IApplicationDbContext db,
            ICategoryRepository categoryRepository,
            IProductRepository productRepository,
            ICurrentUser currentUser
        )
        {
            _db = db;
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
            _currentUser = currentUser;
        }

        public async Task<Result<Unit>> Handle(
            CategoryDeleteCommand request,
            CancellationToken cancellationToken
        )
        {
            var entity = await _categoryRepository.GetByIdAsync(request.Id);
            if (entity == null)
                return Result<Unit>.NotFoundResult(request?.Id);

            if (entity.ShopId != _currentUser.GetShopId())
                return Result<Unit>.FailureResult("Forbidden", "You can only delete categories from your own shop");

            var productCount = await _productRepository.CountByCategoryIdAsync(
                entity.Id,
                cancellationToken);
            if (productCount > 0)
                return Result<Unit>.FailureResult(
                    "CategoryInUse",
                    $"Category is used by {productCount} product(s). Reassign them before deleting the category.");

            // Physical remove — SoftDeleteInterceptor converts this to a soft delete
            // transparently before EF Core hits the database.
            entity.ClearClientModificationMetadata();
            await _categoryRepository.RemoveAsync(entity);
            await _db.SaveChangesAsync(cancellationToken);
            return Result<Unit>.SuccessResult(Unit.Value);
        }
    }
}