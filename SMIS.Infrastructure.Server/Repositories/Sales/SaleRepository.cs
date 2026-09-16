using Microsoft.EntityFrameworkCore;
using SMIS.Application.Repositories.Sales;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.Repositories.Base;

namespace SMIS.Infrastructure.Server.Repositories.Sales;

public sealed class SaleRepository : GenericRepository<Sale>, ISaleRepository
{
    public SaleRepository(
        AppDbContext context
    ) : base(context)
    {
    }

    public Task<Sale?> GetByIdWithDetailsAsync(
        string id,
        CancellationToken cancellationToken = default
    ) =>
        _context.Sales
            .AsNoTracking()
            .Include(sale => sale.Lines)
            .Include(sale => sale.Receivable)
            .ThenInclude(receivable => receivable!.Payments)
            .FirstOrDefaultAsync(sale => sale.Id == id, cancellationToken);
}