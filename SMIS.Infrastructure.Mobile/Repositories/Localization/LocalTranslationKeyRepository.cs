using SMIS.Application.Repositories.Localization;
using SMIS.Domain.Entities.Localization;
using SMIS.Infrastructure.Mobile.Context;
using SMIS.Infrastructure.Mobile.Repositories.Base;

namespace SMIS.Infrastructure.Mobile.Repositories.Localization;

public class LocalTranslationKeyRepository : LocalGenericRepository<TranslationKey>, ITranslationKeyRepository
{
    private readonly LocalDbContext _context;

    public LocalTranslationKeyRepository(LocalDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}
