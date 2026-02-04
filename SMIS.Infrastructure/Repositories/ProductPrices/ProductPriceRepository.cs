using SMIS.Application.Repositories.ProductPrices;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Context;
using SMIS.Infrastructure.Repositories.Base;

namespace SMIS.Infrastructure.Repositories.ProductPrices;

public class ProductPriceRepository : GenericRepository<ProductPrice>, IProductPriceRepository
{
    public ProductPriceRepository(AppDbContext context) : base(context)
    {
    }
}
