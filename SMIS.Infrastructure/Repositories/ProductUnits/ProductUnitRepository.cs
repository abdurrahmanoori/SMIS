using SMIS.Application.Repositories.ProductUnits;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Context;
using SMIS.Infrastructure.Repositories.Base;

namespace SMIS.Infrastructure.Repositories.ProductUnits
{
    public class ProductUnitRepository : GenericRepository<ProductUnit>, IProductUnitRepository
    {
        public ProductUnitRepository(AppDbContext context) : base(context)
        {
        }
    }
}