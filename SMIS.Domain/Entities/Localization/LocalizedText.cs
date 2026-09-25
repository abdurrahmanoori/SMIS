using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Exceptions;

namespace SMIS.Domain.Entities.Localization;

public class LocalizedText : EntityPK
{
    public string DefaultValue { get; private set; } = string.Empty;

    public virtual ICollection<LocalizedTextTranslation> Translations { get; private set; } =
        new List<LocalizedTextTranslation>();

    internal LocalizedText()
    {
    }

    public static LocalizedText Create(string defaultValue)
    {
        var localizedText = new LocalizedText();
        localizedText.SetDefaultValue(defaultValue);
        return localizedText;
    }

    public void SetDefaultValue(string defaultValue)
    {
        if (string.IsNullOrWhiteSpace(defaultValue))
            throw new DomainValidationException("Localized default value cannot be empty.");

        DefaultValue = defaultValue.Trim();
    }

    public void SetTranslation(string languageId, string value)
    {
        if (string.IsNullOrWhiteSpace(languageId))
            throw new DomainValidationException("Language ID cannot be empty.");

        if (string.IsNullOrWhiteSpace(value))
            throw new DomainValidationException("Translation value cannot be empty.");

        var normalizedLanguageId = languageId.Trim();
        var existing = Translations.FirstOrDefault(x => x.LanguageId == normalizedLanguageId);
        if (existing is null)
        {
            Translations.Add(LocalizedTextTranslation.Create(Id, normalizedLanguageId, value));
            return;
        }

        existing.SetValue(value);
    }
}
