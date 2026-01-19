using SMIS.Application.Repositories.Districts;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Context;
using SMIS.Infrastructure.Repositories.Base;

namespace SMIS.Infrastructure.Repositories.Districts
{
    public class DistrictRepository : GenericRepository<District>, IDistrictRepository
    {
        public DistrictRepository(AppDbContext context) : base(context)
        {
        }
    }
}