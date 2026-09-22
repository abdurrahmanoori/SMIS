using SMIS.Application.Repositories.Base;
using SMIS.Domain.Entities;

namespace SMIS.Application.Repositories.Categories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<Category?> GetByIdIncludingDeletedAsync(
            string id,
            CancellationToken cancellationToken = default
        );

        Task<bool> NameExistsInShopAsync(
            string shopId,
            string name,
            string? excludeId = null,
            CancellationToken cancellationToken = default
        );
    }
}