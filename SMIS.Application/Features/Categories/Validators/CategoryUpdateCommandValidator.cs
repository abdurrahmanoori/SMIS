using FluentValidation;
using SMIS.Application.DTO.Localization;
using SMIS.Application.Features.Categories.Commands;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Application.Features.Categories.Validators
{
    public class CategoryUpdateCommandValidator : AbstractValidator<CategoryUpdateCommand>
    {
        public CategoryUpdateCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Category ID is required");

            RuleFor(x => x.CategoryUpdateDto.Name)
                .NotEmpty().WithMessage("Category Name is required")
                .MaximumLength(200).WithMessage("Name must not exceed 200 characters");

            RuleFor(x => x.CategoryUpdateDto.Code)
                .MaximumLength(50).WithMessage("Code must not exceed 50 characters")
                .When(x => !string.IsNullOrEmpty(x.CategoryUpdateDto.Code));

            RuleFor(x => x.CategoryUpdateDto.Description)
                .MaximumLength(500).WithMessage("Description must not exceed 500 characters")
                .When(x => !string.IsNullOrEmpty(x.CategoryUpdateDto.Description));

            RuleFor(x => x.CategoryUpdateDto.NameTranslations)
                .Must(HaveUniqueSupportedLanguages)
                .WithMessage("Category name translations may contain English and Dari once each.");

            RuleForEach(x => x.CategoryUpdateDto.NameTranslations)
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
            IEnumerable<LocalizedTextValueDto> translations
        )
        {
            var ids = translations.Select(x => x.LanguageId).ToList();
            return ids.All(BeSupportedLanguage) &&
                   ids.Distinct(StringComparer.Ordinal).Count() == ids.Count;
        }
    }
}
