using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Features.Categories;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Categories;
using SMIS.Application.Services;

namespace SMIS.Application.Features.Categories.Commands
{
    public record CategoryUpdateCommand(string Id, CategoryUpdateDto CategoryUpdateDto) : IRequest<Result<CategoryDto>>;

    internal sealed class CategoryUpdateCommandHandler : IRequestHandler<CategoryUpdateCommand, Result<CategoryDto>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IApplicationDbContext _db;
        private readonly ICurrentUser _currentUser;

        public CategoryUpdateCommandHandler(
            IApplicationDbContext db,
            ICategoryRepository categoryRepository,
            ICurrentUser currentUser
        )
        {
            _db = db;
            _categoryRepository = categoryRepository;
            _currentUser = currentUser;
        }

        public async Task<Result<CategoryDto>> Handle(
            CategoryUpdateCommand request,
            CancellationToken cancellationToken
        )
        {
            var entity = await _db.Categories
                .IncludeNameLocalization()
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if (entity == null)
                return Result<CategoryDto>.NotFoundResult(nameof(CategoryDto.Id));

            var userShopId = _currentUser.GetShopId();
            if (entity.ShopId != userShopId)
            {
                return Result<CategoryDto>.FailureResult(
                    "You can only update categories from your own shop");
            }

            if (await _categoryRepository.NameExistsInShopAsync(
                    entity.ShopId,
                    request.CategoryUpdateDto.Name,
                    entity.Id,
                    cancellationToken))
            {
                return CategoryCommandRules.DuplicateName();
            }

            CategoryCommandRules.Apply(entity, request.CategoryUpdateDto);
            CategoryLocalization.ApplyName(entity, request.CategoryUpdateDto);

            entity.ClearClientModificationMetadata();

            await _db.SaveChangesAsync(cancellationToken);

            return Result<CategoryDto>.SuccessResult(
                CategoryLocalization.ToDto(entity, _currentUser.GetLangId()));
        }
    }
}
