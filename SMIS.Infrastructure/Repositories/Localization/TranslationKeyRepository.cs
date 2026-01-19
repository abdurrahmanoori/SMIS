using SMIS.Application.Repositories.Localization;
using SMIS.Domain.Entities.Localization;
using SMIS.Infrastructure.Context;
using SMIS.Infrastructure.Repositories.Base;

namespace SMIS.Infrastructure.Repositories.Localization
{
    public class TranslationKeyRepository : GenericRepository<TranslationKey>, ITranslationKeyRepository
    {
        public TranslationKeyRepository(AppDbContext context) : base(context)
        {
        }
    }
}