using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Repositories.Categories;

namespace SMIS.Application.Features.Categories.Queries
{
    public record CategoryPullQuery(DateTimeOffset ChangedSince) : IRequest<Result<List<CategoryDto>>>;

    internal sealed class CategoryPullQueryHandler : IRequestHandler<CategoryPullQuery, Result<List<CategoryDto>>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryPullQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<Result<List<CategoryDto>>> Handle(CategoryPullQuery request, CancellationToken cancellationToken)
        {
            var categories = await _categoryRepository
                .GetAllAsync(c => c.LastModifiedUtc > request.ChangedSince);

            return Result<List<CategoryDto>>.SuccessResult(_mapper.Map<List<CategoryDto>>(categories));
        }
    }
}
