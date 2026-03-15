using AutoMapper;
using MediatR;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.Extensions;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Categories;
using SMIS.Application.Repositories.Localization;

namespace SMIS.Application.Features.Categories.Queries
{
    public record CategoryGetListQuery(int PageNumber = 1, int PageSize = 25, string? SearchTerm = null) : IRequest<Result<PagedList<CategoryDto>>>;

    internal sealed class CategoryGetListQueryHandler : IRequestHandler<CategoryGetListQuery, Result<PagedList<CategoryDto>>>
    {
        private readonly ICategoryRepository _categoryRepository;
        //private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly ICurrentUser _currentUser;
        private readonly IMapper _mapper;

        public CategoryGetListQueryHandler(ICategoryRepository categoryRepository, /*ITranslationKeyRepository translationKeyRepository,*/ ICurrentUser currentUser, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            //_translationKeyRepository = translationKeyRepository;
            _currentUser = currentUser;
            _mapper = mapper;
        }

        public async Task<Result<PagedList<CategoryDto>>> Handle(CategoryGetListQuery request, CancellationToken cancellationToken)
        {
            var query = _categoryRepository.GetAllQueryable();

            if (!string.IsNullOrWhiteSpace(request.SearchTerm))
            {
                var term = request.SearchTerm.ToLower();
                query = query.Where(c =>
                    c.Name.ToLower().Contains(term) ||
                    (c.Code != null && c.Code.ToLower().Contains(term)) ||
                    (c.Description != null && c.Description.ToLower().Contains(term)));
            }

            var categories = await query.ToPagedList(request.PageNumber, request.PageSize);

            if (!categories.Items.Any())
            {
                return Result<PagedList<CategoryDto>>.EmptyResult(nameof(CategoryDto));
            }

            var categoryDtos = _mapper.Map<List<CategoryDto>>(categories.Items);
            //var translationKeys = _translationKeyRepository.GetAllQueryable();
            //var userLangId = _currentUser.GetLangId();

            //categoryDtos.ForEach(category => category.TranslateEntityByAttributes(translationKeys, userLangId));

            return Result<PagedList<CategoryDto>>.SuccessResult(new PagedList<CategoryDto>
            {
                Items = categoryDtos,
                TotalCount = categories.TotalCount,
                PageNumber = categories.PageNumber,
                PageSize = categories.PageSize,
                TotalPages = categories.TotalPages
            });
        }
    }
}