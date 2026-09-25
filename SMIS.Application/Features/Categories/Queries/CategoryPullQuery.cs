using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Features.Categories;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Services;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.Categories.Queries
{
    public record CategoryPullQuery(DateTime ChangedSince) : IRequest<Result<List<CategoryDto>>>;

    internal sealed class CategoryPullQueryHandler : IRequestHandler<CategoryPullQuery, Result<List<CategoryDto>>>
    {
        private readonly IApplicationDbContext _db;
        private readonly ICurrentUser _currentUser;

        public CategoryPullQueryHandler(
            IApplicationDbContext db,
            ICurrentUser currentUser
        )
        {
            _db = db;
            _currentUser = currentUser;
        }

        public async Task<Result<List<CategoryDto>>> Handle(
            CategoryPullQuery request,
            CancellationToken cancellationToken
        )
        {
            var shopId = _currentUser.GetShopId();
            var changedSinceUtc = DateTimeService.NormalizeUtc(request.ChangedSince);
            var categories = await _db.Categories
                .IgnoreQueryFilters()
                .IncludeNameLocalization()
                .Where(c => c.LastModifiedUtc > changedSinceUtc && c.ShopId == shopId)
                .ToListAsync(cancellationToken);

            var userLanguageId = _currentUser.GetLangId();
            return Result<List<CategoryDto>>.SuccessResult(
                categories
                    .Select(category => CategoryLocalization.ToDto(category, userLanguageId))
                    .ToList());
        }
    }
}
