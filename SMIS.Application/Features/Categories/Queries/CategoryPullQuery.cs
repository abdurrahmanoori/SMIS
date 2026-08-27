using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Categories;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.Categories.Queries
{
    public record CategoryPullQuery(DateTime ChangedSince) : IRequest<Result<List<CategoryDto>>>;

    internal sealed class CategoryPullQueryHandler : IRequestHandler<CategoryPullQuery, Result<List<CategoryDto>>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        private readonly ICurrentUser _currentUser;

        public CategoryPullQueryHandler(ICategoryRepository categoryRepository, IMapper mapper, ICurrentUser currentUser)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
            _currentUser = currentUser;
        }

        public async Task<Result<List<CategoryDto>>> Handle(CategoryPullQuery request, CancellationToken cancellationToken)
        {
            var shopId = _currentUser.GetShopId();
            var isSuperAdmin = _currentUser.IsSuperAdmin();
            var changedSinceUtc =DateTimeService.NormalizeUtc(request.ChangedSince);
            var categories = await _categoryRepository.GetAllAsync(
                filter: c => c.LastModifiedUtc > changedSinceUtc &&
                             (isSuperAdmin || c.ShopId == shopId),
                ignoreQueryFilters: true);

            return Result<List<CategoryDto>>.SuccessResult(_mapper.Map<List<CategoryDto>>(categories));
        }
    }
}
