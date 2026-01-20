using System.Linq.Expressions;
using System.Reflection;
using SMIS.Application.Attributes;
using SMIS.Application.Repositories.Localization;

namespace SMIS.Application.Extensions
{
    public static class TranslationExtensions
    {
        public static string GetTranslation(this IQueryable<Domain.Entities.Localization.TranslationKey> translationKeys, 
            string originalValue, int languageId)
        {
            return translationKeys
                .Where(tk => tk.Name == originalValue)
                .SelectMany(tk => tk.Translations)
                .Where(t => t.LanguageNo == languageId)
                .Select(t => t.Name)
                .FirstOrDefault() ?? originalValue;
        }

        public static T TranslateEntity<T>(this T entity, 
            IQueryable<Domain.Entities.Localization.TranslationKey> translationKeys, 
            int languageId,
            params (Func<T, string> getter, Action<T, string> setter)[] properties)
        {
            foreach (var (getter, setter) in properties)
            {
                var originalValue = getter(entity);
                var translatedValue = translationKeys.GetTranslation(originalValue, languageId);
                setter(entity, translatedValue);
            }
            return entity;
        }

        public static T TranslateEntityByAttributes<T>(this T entity,
            IQueryable<Domain.Entities.Localization.TranslationKey> translationKeys,
            int languageId)
        {
            var properties = typeof(T).GetProperties()
                .Where(p => p.GetCustomAttribute<TranslatableAttribute>() != null && p.PropertyType == typeof(string));

            foreach (var property in properties)
            {
                var originalValue = property.GetValue(entity) as string;
                if (!string.IsNullOrEmpty(originalValue))
                {
                    var translatedValue = translationKeys.GetTranslation(originalValue, languageId);
                    property.SetValue(entity, translatedValue);
                }
            }
            return entity;
        }
    }
}