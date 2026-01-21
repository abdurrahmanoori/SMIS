using SMIS.Domain.Entities.Localization;

namespace SMIS.Application.Services
{
    public interface ITranslationService
    {
        Task<TranslationKey> CreateTranslationKeyAsync(string keyValue, CancellationToken cancellationToken = default);
        Task<Translation> AddTranslationAsync(string keyValue, string languageNo, string translatedValue, CancellationToken cancellationToken = default);
        Task<string> GetTranslationAsync(string keyValue, string languageNo, CancellationToken cancellationToken = default);
    }
}
