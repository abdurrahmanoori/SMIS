using SMIS.Application.Repositories.Base;
using SMIS.Domain.Entities;

namespace SMIS.Application.Repositories.Categories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        // Returns all categories (including soft-deleted) modified after the given timestamp.
        // Used exclusively by the pull endpoint to propagate deletes to mobile clients.
        Task<IEnumerable<Category>> GetChangedSinceAsync(DateTime changedSince);
    }
}