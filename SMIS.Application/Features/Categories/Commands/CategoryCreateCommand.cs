using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Categories;
using SMIS.Application.Services;

namespace SMIS.Application.Features.Categories.Commands
{
    public record CategoryCreateCommand(CategoryCreateDto CategoryCreateDto) : IRequest<Result<CategoryDto>>;

    internal sealed class CategoryCreateCommandHandler : IRequestHandler<CategoryCreateCommand, Result<CategoryDto>>
    {
        private readonly ICategoryRepository _categoryRepository;

        //private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly IApplicationDbContext _db;
        private readonly ICurrentUser _currentUser;
        private readonly IMapper _mapper;

        public CategoryCreateCommandHandler(
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
            CategoryCreateCommand request,
            CancellationToken cancellationToken
        )
        {
            //await _translationKeyRepository.AddTranslationKeysForEntity(request.CategoryCreateDto, _unitOfWork);
            // Get ShopId from authenticated user (secure)
            var shopId = _currentUser.GetShopId();

            if (await _categoryRepository.NameExistsInShopAsync(
                    shopId,
                    request.CategoryCreateDto.Name,
                    cancellationToken: cancellationToken))
            {
                return CategoryCommandRules.DuplicateName();
            }

            var entity = CategoryCommandRules.Create(request.CategoryCreateDto, shopId);

            await _categoryRepository.AddAsync(entity);
            await _db.SaveChangesAsync(cancellationToken);

            return Result<CategoryDto>.SuccessResult(_mapper.Map<CategoryDto>(entity),
                "Category Created Successfully.");
        }
    }
}