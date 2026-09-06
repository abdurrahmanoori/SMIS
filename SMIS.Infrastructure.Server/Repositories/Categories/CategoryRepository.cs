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

        public Task<Category?> GetByIdIncludingDeletedAsync(
            string id,
            CancellationToken cancellationToken = default
        )
        {
            return _context.Categories.IgnoreQueryFilters()
                .FirstOrDefaultAsync(category => category.Id == id, cancellationToken);
        }
    }
}