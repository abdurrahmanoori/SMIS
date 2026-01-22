using SMIS.Application.Repositories.Localization;
using SMIS.Domain.Entities.Localization;
using SMIS.Infrastructure.Context;
using SMIS.Infrastructure.Repositories.Base;

namespace SMIS.Infrastructure.Repositories.Localization
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