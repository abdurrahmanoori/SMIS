using FluentValidation;
using SMIS.Application.Features.Categories.Commands;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Application.Features.Categories.Validators
{
    public class CategoryCreateCommandValidator : AbstractValidator<CategoryCreateCommand>
    {
        public CategoryCreateCommandValidator()
        {
            RuleFor(x => x.CategoryCreateDto.Name)
                .NotEmpty().WithMessage("Category Name is required")
                .MaximumLength(200).WithMessage("Name must not exceed 200 characters");

            RuleFor(x => x.CategoryCreateDto.Code)
                .MaximumLength(50).WithMessage("Code must not exceed 50 characters")
                .When(x => !string.IsNullOrEmpty(x.CategoryCreateDto.Code));

            RuleFor(x => x.CategoryCreateDto.Description)
                .MaximumLength(500).WithMessage("Description must not exceed 500 characters")
                .When(x => !string.IsNullOrEmpty(x.CategoryCreateDto.Description));

            RuleFor(x => x.CategoryCreateDto.NameTranslations)
                .Must(HaveUniqueSupportedLanguages)
                .WithMessage("Category name translations may contain English and Dari once each.");

            RuleForEach(x => x.CategoryCreateDto.NameTranslations)
                .ChildRules(translation =>
                {
                    translation.RuleFor(x => x.LanguageId)
                        .Must(BeSupportedLanguage)
                        .WithMessage("Only English and Dari category translations are supported in this proof-of-concept.");

                    translation.RuleFor(x => x.Value)
                        .MaximumLength(200);
                });
        }

        private static bool BeSupportedLanguage(string languageId) =>
            languageId == LanguageDefaults.EnglishId ||
            languageId == LanguageDefaults.DariId;

        private static bool HaveUniqueSupportedLanguages(
            IEnumerable<DTO.Localization.LocalizedTextValueDto> translations
        )
        {
            var ids = translations.Select(x => x.LanguageId).ToList();
            return ids.All(BeSupportedLanguage) &&
                   ids.Distinct(StringComparer.Ordinal).Count() == ids.Count;
        }
    }
}
