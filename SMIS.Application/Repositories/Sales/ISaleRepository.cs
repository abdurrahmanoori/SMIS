using SMIS.Application.Repositories.Base;
using SMIS.Domain.Entities;

namespace SMIS.Application.Repositories.Sales;

public interface ISaleRepository : IGenericRepository<Sale>
{
    Task<Sale?> GetByIdWithDetailsAsync(
        string id,
        CancellationToken cancellationToken = default
    );
}