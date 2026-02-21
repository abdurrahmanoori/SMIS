using SMIS.Application.Repositories.Localization;
using SMIS.Domain.Entities.Localization;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.Repositories.Base;

namespace SMIS.Infrastructure.Server.Repositories.Localization
{
    public class TranslationKeyRepository : GenericRepository<TranslationKey>, ITranslationKeyRepository
    {
        private readonly AppDbContext _context;
        public TranslationKeyRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}