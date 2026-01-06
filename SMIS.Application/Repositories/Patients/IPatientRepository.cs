using SMIS.Application.Repositories.Base;
using SMIS.Domain.Entities.Patients;

namespace SMIS.Application.Repositories.Patients
{
    public  interface IPatientRepository : IGenericRepository<Patient>
    {
    }
}
