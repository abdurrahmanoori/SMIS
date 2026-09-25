using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Features.Categories;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Categories;
using SMIS.Application.Services;

namespace SMIS.Application.Features.Categories.Commands
{
    public record CategoryCreateCommand(CategoryCreateDto CategoryCreateDto) : IRequest<Result<CategoryDto>>;

    internal sealed class CategoryCreateCommandHandler : IRequestHandler<CategoryCreateCommand, Result<CategoryDto>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IApplicationDbContext _db;
        private readonly ICurrentUser _currentUser;

        public CategoryCreateCommandHandler(
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
            CategoryCreateCommand request,
            CancellationToken cancellationToken
        )
        {
            var shopId = _currentUser.GetShopId();

            if (await _categoryRepository.NameExistsInShopAsync(
                    shopId,
                    request.CategoryCreateDto.Name,
                    cancellationToken: cancellationToken))
            {
                return CategoryCommandRules.DuplicateName();
            }

            var entity = CategoryCommandRules.Create(request.CategoryCreateDto, shopId);
            var localizedName = CategoryLocalization.CreateName(request.CategoryCreateDto);
            entity.SetNameLocalizedText(localizedName);

            _db.LocalizedTexts.Add(localizedName);
            await _categoryRepository.AddAsync(entity);
            await _db.SaveChangesAsync(cancellationToken);

            return Result<CategoryDto>.SuccessResult(
                CategoryLocalization.ToDto(entity, _currentUser.GetLangId()),
                "Category Created Successfully.");
        }
    }
}
