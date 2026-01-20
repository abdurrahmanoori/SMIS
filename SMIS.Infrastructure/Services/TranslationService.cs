using Microsoft.EntityFrameworkCore;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Localization;
using SMIS.Application.Services;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Infrastructure.Services
{
    public class TranslationService : ITranslationService
    {
        private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly IGenericRepository<Translation> _translationRepository;
        private readonly IUnitOfWork _unitOfWork;

        public TranslationService(
            ITranslationKeyRepository translationKeyRepository,
            IGenericRepository<Translation> translationRepository,
            IUnitOfWork unitOfWork)
        {
            _translationKeyRepository = translationKeyRepository;
            _translationRepository = translationRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<TranslationKey> CreateTranslationKeyAsync(string keyValue, CancellationToken cancellationToken = default)
        {
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

        public async Task<Translation> AddTranslationAsync(string keyValue, int languageNo, string translatedValue, CancellationToken cancellationToken = default)
        {
            var translationKey = await _translationKeyRepository
                .GetFirstOrDefaultAsync(tk => tk.Name == keyValue);

            if (translationKey == null)
            {
                translationKey = await CreateTranslationKeyAsync(keyValue, cancellationToken);
            }

            var existingTranslation = await _translationRepository
                .GetFirstOrDefaultAsync(t => t.TranslationKeyPublicId == translationKey.PublicId && t.LanguageNo == languageNo);

            if (existingTranslation != null)
            {
                existingTranslation.Name = translatedValue;
                await _translationRepository.UpdateAsync(existingTranslation);
            }
            else
            {
                var translation = new Translation
                {
                    TranslationKeyPublicId = translationKey.PublicId,
                    LanguageNo = languageNo,
                    Name = translatedValue
                };

                await _translationRepository.AddAsync(translation);
            }

            await _unitOfWork.SaveChanges(cancellationToken);

            return await _translationRepository
                .GetFirstOrDefaultAsync(t => t.TranslationKeyPublicId == translationKey.PublicId && t.LanguageNo == languageNo);
        }

        public async Task<string> GetTranslationAsync(string keyValue, int languageNo, CancellationToken cancellationToken = default)
        {
            var translation = await _translationKeyRepository.GetAllQueryable()
                .Where(tk => tk.Name == keyValue)
                .SelectMany(tk => tk.Translations)
                .Where(t => t.LanguageNo == languageNo)
                .Select(t => t.Name)
                .FirstOrDefaultAsync(cancellationToken);

            return translation ?? keyValue;
        }
    }
}
