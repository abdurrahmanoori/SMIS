using SMIS.Application.Repositories.ShopOwners;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.Repositories.Base;

namespace SMIS.Infrastructure.Server.Repositories.ShopOwners
{
    public class ShopOwnerRepository : GenericRepository<ShopOwner>, IShopOwnerRepository
    {
        public ShopOwnerRepository(AppDbContext context) : base(context)
        {
        }
    }
}