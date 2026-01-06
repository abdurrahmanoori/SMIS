using SMIS.Application.Repositories.Laboratory;
using SMIS.Domain.Entities.Laboratory;
using SMIS.Infrastructure.Context;
using SMIS.Infrastructure.Repositories.Base;

namespace SMIS.Infrastructure.Repositories.Laboratory
{
    public class LabTestRepository : GenericRepository<LabTest>, ILabTestRepository
    {
        public LabTestRepository(AppDbContext context) : base(context) { }
    }
}
