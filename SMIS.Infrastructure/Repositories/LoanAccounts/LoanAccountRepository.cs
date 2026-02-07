using SMIS.Application.Repositories.LoanAccounts;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Context;
using SMIS.Infrastructure.Repositories.Base;

namespace SMIS.Infrastructure.Repositories.LoanAccounts;

public class LoanAccountRepository : GenericRepository<LoanAccount>, ILoanAccountRepository
{
    public LoanAccountRepository(AppDbContext context) : base(context)
    {
    }
}
