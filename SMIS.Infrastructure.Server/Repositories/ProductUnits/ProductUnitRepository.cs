using Microsoft.EntityFrameworkCore;
using SMIS.Application.Repositories.ProductUnits;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.Repositories.Base;

namespace SMIS.Infrastructure.Server.Repositories.ProductUnits
{
    public class ProductUnitRepository : GenericRepository<ProductUnit>, IProductUnitRepository
    {
        public ProductUnitRepository(AppDbContext context) : base(context)
        {
        }

        public Task<ProductUnit?> GetByIdIncludingDeletedAsync(string id, CancellationToken cancellationToken = default) =>
            _context.ProductUnits.IgnoreQueryFilters().FirstOrDefaultAsync(unit => unit.Id == id, cancellationToken);
    }
}
