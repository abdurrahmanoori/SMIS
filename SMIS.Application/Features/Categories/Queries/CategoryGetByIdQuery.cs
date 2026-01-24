using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Extensions;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Categories;
using SMIS.Application.Repositories.Localization;

namespace SMIS.Application.Features.Categories.Queries
{
    public record CategoryGetByIdQuery(string Id) : IRequest<Result<CategoryDto>>;

    internal sealed class CategoryGetByIdQueryHandler : IRequestHandler<CategoryGetByIdQuery, Result<CategoryDto>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly ICurrentUser _currentUser;
        private readonly IMapper _mapper;

        public CategoryGetByIdQueryHandler(ICategoryRepository categoryRepository, ITranslationKeyRepository translationKeyRepository, ICurrentUser currentUser, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _translationKeyRepository = translationKeyRepository;
            _currentUser = currentUser;
            _mapper = mapper;
        }

        public async Task<Result<CategoryDto>> Handle(CategoryGetByIdQuery request, CancellationToken cancellationToken)
        {
            var dbCategory = await _categoryRepository.GetFirstOrDefaultAsync(x => x.Id == request.Id);

            if (dbCategory == null)
            {
                return Result<CategoryDto>.NotFoundResult(nameof(CategoryDto));
            }

            var category = _mapper.Map<CategoryDto>(dbCategory);
            category.TranslateEntityByAttributes(_translationKeyRepository.GetAllQueryable(), _currentUser.GetLangId());

            return Result<CategoryDto>.SuccessResult(category);
        }
    }
}