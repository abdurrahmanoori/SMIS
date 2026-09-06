using SMIS.Application.Repositories.Base;
using SMIS.Domain.Entities;

namespace SMIS.Application.Repositories.ProductUnits
{
    public interface IProductUnitRepository : IGenericRepository<ProductUnit>
    {
        Task<ProductUnit?> GetByIdIncludingDeletedAsync(string id, CancellationToken cancellationToken = default);
    }
}
