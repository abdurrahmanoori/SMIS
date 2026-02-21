using SMIS.Application.Repositories.Categories;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Mobile.Context;
using SMIS.Infrastructure.Mobile.Repositories.Base;

namespace SMIS.Infrastructure.Mobile.Repositories.Categories;

public class LocalCategoryRepository : LocalGenericRepository<Category>, ICategoryRepository
{
    public LocalCategoryRepository(LocalDbContext context) : base(context)
    {
    }
}
