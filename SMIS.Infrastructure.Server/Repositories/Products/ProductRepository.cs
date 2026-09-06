using Microsoft.EntityFrameworkCore;
using SMIS.Application.Repositories.Products;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.Repositories.Base;

namespace SMIS.Infrastructure.Server.Repositories.Products
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public Task<Product?> GetByIdIncludingDeletedAsync(
            string id,
            CancellationToken cancellationToken = default)
        {
            return _context.Products
                .IgnoreQueryFilters()
                .FirstOrDefaultAsync(product => product.Id == id, cancellationToken);
        }
    }
}
