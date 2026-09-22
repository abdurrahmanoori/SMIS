using Microsoft.EntityFrameworkCore;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Localization;
using SMIS.Application.Services;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Infrastructure.Server.Services
{
    /// <summary>
    /// Coordinates translation keys and language-specific values.
    /// A key is created once, then individual Translation rows are added or updated per language.
    /// </summary>
    public class TranslationService : ITranslationService
    {
        private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly IGenericRepository<Translation> _translationRepository;
        private readonly IUnitOfWork _unitOfWork;

        public TranslationService(
            ITranslationKeyRepository translationKeyRepository,
            IGenericRepository<Translation> translationRepository,
            IUnitOfWork unitOfWork
        )
        {
            _translationKeyRepository = translationKeyRepository;
            _translationRepository = translationRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<TranslationKey> CreateTranslationKeyAsync(
            string keyValue,
            CancellationToken cancellationToken = default
        )
        {
            // Treat key creation as idempotent so callers can safely request the same key
            // from multiple feature flows without intentionally creating duplicates.
            var existingKey = await _translationKeyRepository
                .GetFirstOrDefaultAsync(tk => tk.Name == keyValue, tracked: false);

            if (existingKey != null)
                return existingKey;

            var translationKey = new TranslationKey
            {
                Name = keyValue,
                IsActive = true
            };

            await _translationKeyRepository.AddAsync(translationKey);
            await _unitOfWork.SaveChanges(cancellationToken);

            return translationKey;
        }

        public async Task<Translation> AddTranslationAsync(
            string keyValue,
            string languageNo,
            string translatedValue,
            CancellationToken cancellationToken = default
        )
        {
            var translationKey = await _translationKeyRepository
                .GetFirstOrDefaultAsync(tk => tk.Name == keyValue);

            if (translationKey == null)
            {
                translationKey = await CreateTranslationKeyAsync(keyValue, cancellationToken);
            }

            var existingTranslation = await _translationRepository
                .GetFirstOrDefaultAsync(t => t.TranslationKeyId == translationKey.Id && t.LanguageNo == languageNo);

            if (existingTranslation != null)
            {
                // A key/language pair represents one logical value. Updating that row
                // preserves the relationship instead of creating competing translations.
                existingTranslation.Name = translatedValue;
                await _translationRepository.UpdateAsync(existingTranslation);
            }
            else
            {
                var translation = new Translation
                {
                    TranslationKeyId = translationKey.Id,
                    LanguageNo = languageNo,
                    Name = translatedValue
                };

                await _translationRepository.AddAsync(translation);
            }

            await _unitOfWork.SaveChanges(cancellationToken);

            return await _translationRepository
                .GetFirstOrDefaultAsync(t => t.TranslationKeyId == translationKey.Id && t.LanguageNo == languageNo);
        }

        public async Task<string> GetTranslationAsync(
            string keyValue,
            string languageNo,
            CancellationToken cancellationToken = default
        )
        {
            var translation = await _translationKeyRepository.GetAllQueryable()
                .Where(tk => tk.Name == keyValue)
                .SelectMany(tk => tk.Translations)
                .Where(t => t.LanguageNo == languageNo)
                .Select(t => t.Name)
                .FirstOrDefaultAsync(cancellationToken);

            // Falling back to the key keeps UI text usable when a language-specific
            // translation has not been entered yet.
            return translation ?? keyValue;
        }
    }
}