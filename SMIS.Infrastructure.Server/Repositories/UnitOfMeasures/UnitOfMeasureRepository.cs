using SMIS.Application.Repositories.UnitOfMeasures;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.Repositories.Base;

namespace SMIS.Infrastructure.Server.Repositories.UnitOfMeasures
{
    public class UnitOfMeasureRepository : GenericRepository<UnitOfMeasure>, IUnitOfMeasureRepository
    {
        public UnitOfMeasureRepository(AppDbContext context) : base(context)
        {
        }
    }
}
