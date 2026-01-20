using System.Reflection;
using SMIS.Application.Attributes;
using SMIS.Application.Repositories.Localization;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Application.Extensions
{
    public static class TranslationKeyExtensions
    {
        public static async Task AddTranslationKeysForEntity<T>(this ITranslationKeyRepository repository, T entity)
        {
            var properties = typeof(T).GetProperties()
                .Where(p => p.GetCustomAttribute<TranslatableAttribute>() != null && p.PropertyType == typeof(string));

            foreach (var property in properties)
            {
                var value = property.GetValue(entity) as string;
                if (!string.IsNullOrEmpty(value))
                {
                    var existingKey = await repository.GetFirstOrDefaultAsync(tk => tk.Name == value);
                    if (existingKey == null)
                    {
                        var translationKey = new TranslationKey
                        {
                            Name = value,
                            IsActive = true
                        };
                        await repository.AddAsync(translationKey);
                    }
                }
            }
        }
    }
}