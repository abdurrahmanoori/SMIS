using Microsoft.EntityFrameworkCore;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Categories;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.Repositories.Base;

namespace SMIS.Infrastructure.Server.Repositories.Categories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly AppDbContext _context;
        private readonly ICurrentUser _currentUser;

        public CategoryRepository(AppDbContext context, ICurrentUser currentUser) : base(context)
        {
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<IEnumerable<Category>> GetChangedSinceAsync(DateTime changedSince)
        {
            // IgnoreQueryFilters bypasses the soft-delete + shop-scope global filter
            // so deleted records are included. The shop filter is re-applied manually
            // to preserve multi-tenant isolation.
            var shopId = _currentUser.GetShopId();
            return await _context.Categories
                .IgnoreQueryFilters()
                .Where(c => c.ShopId == shopId && c.LastModifiedUtc > changedSince)
                .ToListAsync();
        }
    }
}