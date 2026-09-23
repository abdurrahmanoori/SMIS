using SMIS.Application.Repositories.Base;
using SMIS.Domain.Entities;

namespace SMIS.Application.Repositories.Products
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<int> CountByCategoryIdAsync(
            string categoryId,
            CancellationToken cancellationToken = default
        );

        Task<int> CountReferencesAsync(
            string id,
            CancellationToken cancellationToken = default
        );

        Task<bool> HasStockOrConversionsAsync(
            string id,
            CancellationToken cancellationToken = default
        );
    }
}