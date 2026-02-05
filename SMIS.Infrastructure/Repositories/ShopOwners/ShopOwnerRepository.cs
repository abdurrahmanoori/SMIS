using SMIS.Application.Repositories.ShopOwners;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Context;
using SMIS.Infrastructure.Repositories.Base;

namespace SMIS.Infrastructure.Repositories.ShopOwners
{
    public class ShopOwnerRepository : GenericRepository<ShopOwner>, IShopOwnerRepository
    {
        public ShopOwnerRepository(AppDbContext context) : base(context)
        {
        }
    }
}