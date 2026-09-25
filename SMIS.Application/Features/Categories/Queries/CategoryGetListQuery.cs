using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Features.Categories;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Categories;

namespace SMIS.Application.Features.Categories.Queries
{
    public record CategoryGetListQuery(int PageNumber = 1, int PageSize = 25, string? SearchTerm = null)
        : IRequest<Result<PagedList<CategoryDto>>>;

    internal sealed class
        CategoryGetListQueryHandler : IRequestHandler<CategoryGetListQuery, Result<PagedList<CategoryDto>>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ICurrentUser _currentUser;

        public CategoryGetListQueryHandler(
            ICategoryRepository categoryRepository,
            ICurrentUser currentUser
        )
        {
            _categoryRepository = categoryRepository;
            _currentUser = currentUser;
        }

        public async Task<Result<PagedList<CategoryDto>>> Handle(
            CategoryGetListQuery request,
            CancellationToken cancellationToken
        )
        {
            var query = _categoryRepository
                .GetAllQueryable()
                .IncludeNameLocalization();

            if (!string.IsNullOrWhiteSpace(request.SearchTerm))
            {
                var term = request.SearchTerm.ToLower();
                query = query.Where(c =>
                    c.Name.ToLower().Contains(term) ||
                    c.NameLocalizedText.Translations.Any(t => t.Value.ToLower().Contains(term)) ||
                    (c.Code != null && c.Code.ToLower().Contains(term)) ||
                    (c.Description != null && c.Description.ToLower().Contains(term)));
            }

            var categories = await query.ToPagedList(request.PageNumber, request.PageSize);

            if (!categories.Items.Any())
                return Result<PagedList<CategoryDto>>.EmptyResult(nameof(CategoryDto));

            var userLanguageId = _currentUser.GetLangId();
            var categoryDtos = categories.Items
                .Select(category => CategoryLocalization.ToDto(category, userLanguageId))
                .ToList();

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
