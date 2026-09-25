using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Exceptions;

namespace SMIS.Domain.Entities.Localization;

public class LocalizedTextTranslation : EntityPK
{
    public string LocalizedTextId { get; private set; } = string.Empty;
    public string LanguageId { get; private set; } = string.Empty;
    public string Value { get; private set; } = string.Empty;

    public virtual LocalizedText LocalizedText { get; private set; } = null!;
    public virtual Language Language { get; private set; } = null!;

    internal LocalizedTextTranslation()
    {
    }

    internal static LocalizedTextTranslation Create(
        string localizedTextId,
        string languageId,
        string value
    )
    {
        if (string.IsNullOrWhiteSpace(localizedTextId))
            throw new DomainValidationException("Localized text ID cannot be empty.");

        if (string.IsNullOrWhiteSpace(languageId))
            throw new DomainValidationException("Language ID cannot be empty.");

        var translation = new LocalizedTextTranslation
        {
            LocalizedTextId = localizedTextId.Trim(),
            LanguageId = languageId.Trim()
        };
        translation.SetValue(value);
        return translation;
    }

    internal void SetValue(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new DomainValidationException("Translation value cannot be empty.");

        Value = value.Trim();
    }
}
