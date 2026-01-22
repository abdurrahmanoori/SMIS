using SMIS.Application.Repositories.Base;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Application.Repositories.Localization
{
    public interface ITranslationKeyRepository : IGenericRepository<TranslationKey>
    {
        Task SaveChangesAsync();
    }
}