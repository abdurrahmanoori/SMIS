using SMIS.Application.Repositories.Shops;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.Repositories.Base;

namespace SMIS.Infrastructure.Server.Repositories.Shops
{
    public class ShopRepository : GenericRepository<Shop>, IShopRepository
    {
        public ShopRepository(AppDbContext context) : base(context)
        {
        }
    }
}
