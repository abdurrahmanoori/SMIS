using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Features.Categories;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Categories;

namespace SMIS.Application.Features.Categories.Queries
{
    public record CategoryGetByIdQuery(string Id) : IRequest<Result<CategoryDto>>;

    internal sealed class CategoryGetByIdQueryHandler : IRequestHandler<CategoryGetByIdQuery, Result<CategoryDto>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ICurrentUser _currentUser;

        public CategoryGetByIdQueryHandler(
            ICategoryRepository categoryRepository,
            ICurrentUser currentUser
        )
        {
            _categoryRepository = categoryRepository;
            _currentUser = currentUser;
        }

        public async Task<Result<CategoryDto>> Handle(
            CategoryGetByIdQuery request,
            CancellationToken cancellationToken
        )
        {
            var dbCategory = await _categoryRepository
                .GetAllQueryable()
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if (dbCategory == null)
                return Result<CategoryDto>.NotFoundResult(nameof(CategoryDto));

            return Result<CategoryDto>.SuccessResult(
                CategoryMapping.ToDto(dbCategory));
        }
    }
}
