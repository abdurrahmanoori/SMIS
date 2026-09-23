using Microsoft.EntityFrameworkCore;
using SMIS.Application.Repositories.Categories;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.Repositories.Base;

namespace SMIS.Infrastructure.Server.Repositories.Categories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        // private readonly AppDbContext _context;

        public CategoryRepository(
            AppDbContext context
        ) : base(context)
        {
            // _context = context;
        }

        public Task<bool> NameExistsInShopAsync(
            string shopId,
            string name,
            string? excludeId = null,
            CancellationToken cancellationToken = default
        )
        {
            var normalizedName = name.Trim().ToUpperInvariant();
            return _context.Categories
                .IgnoreQueryFilters()
                .AnyAsync(
                    category =>
                        !category.IsDeleted &&
                        category.ShopId == shopId &&
                        category.Id != excludeId &&
                        category.Name.ToUpper() == normalizedName,
                    cancellationToken);
        }
    }
}