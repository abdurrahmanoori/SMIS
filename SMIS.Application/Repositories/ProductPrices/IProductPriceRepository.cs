using SMIS.Application.Repositories.Base;
using SMIS.Domain.Entities;

namespace SMIS.Application.Repositories.ProductPrices;

public interface IProductPriceRepository : IGenericRepository<ProductPrice>
{
    Task<ProductPrice?> GetLatestForProductUnitAsync(
        string productUnitId,
        CancellationToken cancellationToken = default
    );
}