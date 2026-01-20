using System.Reflection;
using SMIS.Application.Attributes;
using SMIS.Application.Repositories.Localization;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Application.Extensions
{
    public static class TranslationKeyUpdateExtensions
    {
        public static async Task AddTranslationKeysForChangedProperties<TDto, TEntity>(
            this ITranslationKeyRepository repository, 
            TDto newDto, 
            TEntity existingEntity)
        {
            var dtoProperties = typeof(TDto).GetProperties()
                .Where(p => p.GetCustomAttribute<TranslatableAttribute>() != null && p.PropertyType == typeof(string))
                .ToList();

            var entityProperties = typeof(TEntity).GetProperties().ToDictionary(p => p.Name, p => p);

            foreach (var dtoProperty in dtoProperties)
            {
                var newValue = dtoProperty.GetValue(newDto) as string;
                
                if (!string.IsNullOrEmpty(newValue) && entityProperties.TryGetValue(dtoProperty.Name, out var entityProperty))
                {
                    var oldValue = entityProperty.GetValue(existingEntity) as string;
                    
                    // Only add translation key if value has changed
                    if (newValue != oldValue)
                    {
                        var existingKey = await repository.GetFirstOrDefaultAsync(tk => tk.Name == newValue);
                        if (existingKey == null)
                        {
                            var translationKey = new TranslationKey
                            {
                                Name = newValue,
                                IsActive = true
                            };
                            await repository.AddAsync(translationKey);
                        }
                    }
                }
            }
        }
    }
}