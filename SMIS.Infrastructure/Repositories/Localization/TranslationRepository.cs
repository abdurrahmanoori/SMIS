using SMIS.Application.Repositories.Localization;
using SMIS.Domain.Entities.Localization;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.Repositories.Base;

namespace SMIS.Infrastructure.Server.Repositories.Localization
{
    public class TranslationRepository : GenericRepository<Translation>, ITranslationRepository
    {
        public TranslationRepository(AppDbContext context) : base(context)
        {
        }
    }
}