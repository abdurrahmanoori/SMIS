using Microsoft.EntityFrameworkCore;
using SMIS.Application.Repositories.StockMovements;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.Repositories.Base;

namespace SMIS.Infrastructure.Server.Repositories.StockMovements;

public sealed class StockMovementRepository : GenericRepository<StockMovement>, IStockMovementRepository
{
    public StockMovementRepository(AppDbContext context) : base(context)
    {
    }

    public Task<bool> HasReversalAsync(
        string movementId,
        CancellationToken cancellationToken = default) =>
        _context.StockMovements.AnyAsync(
            movement => movement.ReferenceType == "StockMovementReversal" &&
                        movement.ReferenceId == movementId,
            cancellationToken);
}
