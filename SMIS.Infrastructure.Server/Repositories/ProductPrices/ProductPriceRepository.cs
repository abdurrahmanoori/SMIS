using Microsoft.EntityFrameworkCore;
using SMIS.Application.Repositories.ProductPrices;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.Repositories.Base;

namespace SMIS.Infrastructure.Server.Repositories.ProductPrices;

public class ProductPriceRepository : GenericRepository<ProductPrice>, IProductPriceRepository
{
    public ProductPriceRepository(AppDbContext context) : base(context)
    {
    }

    public Task<ProductPrice?> GetByIdIncludingDeletedAsync(string id, CancellationToken cancellationToken = default) =>
        _context.ProductPrices.IgnoreQueryFilters().FirstOrDefaultAsync(price => price.Id == id, cancellationToken);
}
