using SMIS.Application.Repositories.Base;
using SMIS.Domain.Entities;

namespace SMIS.Application.Repositories.StockMovements;

public interface IStockMovementRepository : IGenericRepository<StockMovement>
{
    Task<bool> HasReversalAsync(
        string movementId,
        CancellationToken cancellationToken = default
    );

    Task<List<StockMovement>> GetByOperationIdAsync(
        string operationId,
        CancellationToken cancellationToken = default
    );
}