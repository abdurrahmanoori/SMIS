using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Categories;
using SMIS.Application.Services;

namespace SMIS.Application.Features.Categories.Commands
{
    public record CategoryUpdateCommand(string Id, CategoryUpdateDto CategoryUpdateDto) : IRequest<Result<CategoryDto>>;

    internal sealed class CategoryUpdateCommandHandler : IRequestHandler<CategoryUpdateCommand, Result<CategoryDto>>
    {
        private readonly ICategoryRepository _categoryRepository;

        //private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly IApplicationDbContext _db;
        private readonly ICurrentUser _currentUser;
        private readonly IMapper _mapper;

        public CategoryUpdateCommandHandler(
            IApplicationDbContext db,
            IMapper mapper,
            ICategoryRepository categoryRepository, /*ITranslationKeyRepository translationKeyRepository,*/
            ICurrentUser currentUser
        )
        {
            _db = db;
            _mapper = mapper;
            _categoryRepository = categoryRepository;
            //_translationKeyRepository = translationKeyRepository;
            _currentUser = currentUser;
        }

        public async Task<Result<CategoryDto>> Handle(
            CategoryUpdateCommand request,
            CancellationToken cancellationToken
        )
        {
            //request.CategoryUpdateDto.Name += request.CategoryUpdateDto.Name;
            var entity = await _categoryRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result<CategoryDto>.NotFoundResult(nameof(CategoryDto.Id));
            }

            // Verify user can only update their own shop's categories
            var userShopId = _currentUser.GetShopId();
            if (entity.ShopId != userShopId)
            {
                return Result<CategoryDto>.FailureResult("You can only update categories from your own shop");
            }

            if (await _categoryRepository.NameExistsInShopAsync(
                    entity.ShopId,
                    request.CategoryUpdateDto.Name,
                    entity.Id,
                    cancellationToken))
            {
                return CategoryCommandRules.DuplicateName();
            }

            //await _translationKeyRepository.AddTranslationKeysForChangedProperties(request.CategoryUpdateDto, entity);

            CategoryCommandRules.Apply(entity, request.CategoryUpdateDto);

            // A direct API edit becomes the current server-originated version.
            entity.ClearClientModificationMetadata();

            await _db.SaveChangesAsync(cancellationToken);

            var dto = _mapper.Map<CategoryDto>(entity);
            return Result<CategoryDto>.SuccessResult(dto);
        }
    }
}