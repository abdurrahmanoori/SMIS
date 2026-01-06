using SMIS.Application.Repositories.Patients;
using SMIS.Domain.Entities.Patients;
using SMIS.Infrastructure.Context;
using SMIS.Infrastructure.Repositories.Base;

namespace SMIS.Infrastructure.Repositories.Patients
{
    public class PatientRepository : GenericRepository<Patient>, IPatientRepository
    {
        public PatientRepository(AppDbContext _context) : base(_context)
        {
        }
    }
}
