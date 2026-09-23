using Microsoft.EntityFrameworkCore;
using SMIS.Application.Repositories.ProductPrices;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.Repositories.Base;

namespace SMIS.Infrastructure.Server.Repositories.ProductPrices;

public class ProductPriceRepository : GenericRepository<ProductPrice>, IProductPriceRepository
{
    public ProductPriceRepository(
        AppDbContext context
    ) : base(context)
    {
    }

    public Task<ProductPrice?> GetLatestForProductUnitAsync(
        string productUnitId,
        CancellationToken cancellationToken = default
    ) =>
        _context.ProductPrices
            .Where(price => price.ProductUnitId == productUnitId)
            .OrderByDescending(price => price.EffectiveDate)
            .ThenByDescending(price => price.CreatedDate)
            .FirstOrDefaultAsync(cancellationToken);
}