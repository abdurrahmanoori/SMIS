using SMIS.Application.Repositories.LoanAccounts;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.Repositories.Base;

namespace SMIS.Infrastructure.Server.Repositories.LoanAccounts;

public class LoanAccountRepository : GenericRepository<LoanAccount>, ILoanAccountRepository
{
    public LoanAccountRepository(AppDbContext context) : base(context)
    {
    }
}
