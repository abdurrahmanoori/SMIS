using SMIS.Application.Repositories.Provinces;
using SMIS.Domain.Entities.LocationEntities;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.Repositories.Base;

namespace SMIS.Infrastructure.Server.Repositories.Provinces
{
    public class ProvinceRepository : GenericRepository<Province>, IProvinceRepository
    {
        public ProvinceRepository(AppDbContext context) : base(context)
        {
        }
    }
}
