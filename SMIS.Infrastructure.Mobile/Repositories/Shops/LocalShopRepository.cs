using SMIS.Application.Repositories.Shops;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Mobile.Context;
using SMIS.Infrastructure.Mobile.Repositories.Base;

namespace SMIS.Infrastructure.Mobile.Repositories.Shops;

public class LocalShopRepository : LocalGenericRepository<Shop>, IShopRepository
{
    public LocalShopRepository(LocalDbContext context) : base(context)
    {
    }
}
