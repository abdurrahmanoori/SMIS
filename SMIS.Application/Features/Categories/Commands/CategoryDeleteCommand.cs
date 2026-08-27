using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Categories;
using SMIS.Application.Identity.IServices;

namespace SMIS.Application.Features.Categories.Commands
{
    public record CategoryDeleteCommand(string Id) : IRequest<Result<Unit>>;

    internal sealed class CategoryDeleteCommandHandler : IRequestHandler<CategoryDeleteCommand, Result<Unit>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICurrentUser _currentUser;

        public CategoryDeleteCommandHandler(IUnitOfWork unitOfWork, ICategoryRepository categoryRepository, ICurrentUser currentUser)
        {
            _unitOfWork = unitOfWork;
            _categoryRepository = categoryRepository;
            _currentUser = currentUser;
        }

        public async Task<Result<Unit>> Handle(CategoryDeleteCommand request, CancellationToken cancellationToken)
        {
            var entity = await _categoryRepository.GetByIdAsync(request.Id);
            if (entity == null)
                return Result<Unit>.NotFoundResult(request?.Id);

            if (!_currentUser.IsSuperAdmin() && entity.ShopId != _currentUser.GetShopId())
                return Result<Unit>.FailureResult("Forbidden", "You can only delete categories from your own shop");

            entity.ClearClientModificationMetadata();

            // Physical remove — SoftDeleteInterceptor converts this to a soft delete
            // transparently before EF Core hits the database.
            await _categoryRepository.RemoveAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);
            return Result<Unit>.SuccessResult(Unit.Value);
        }
    }
}
