using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Categories;

namespace SMIS.Application.Features.Categories.Queries
{
    public record CategoryPullQuery(DateTimeOffset ChangedSince) : IRequest<Result<List<CategoryDto>>>;

    internal sealed class CategoryPullQueryHandler : IRequestHandler<CategoryPullQuery, Result<List<CategoryDto>>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ICurrentUser _currentUser;
        private readonly IMapper _mapper;

        public CategoryPullQueryHandler(ICategoryRepository categoryRepository, ICurrentUser currentUser, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _currentUser = currentUser;
            _mapper = mapper;
        }

        public async Task<Result<List<CategoryDto>>> Handle(CategoryPullQuery request, CancellationToken cancellationToken)
        {
            var shopId = _currentUser.GetShopId();

            var categories = await _categoryRepository
                .GetAllAsync(c => c.ShopId == shopId && c.LastModifiedUtc > request.ChangedSince);
                

            return Result<List<CategoryDto>>.SuccessResult(_mapper.Map<List<CategoryDto>>(categories));
        }
    }
}
