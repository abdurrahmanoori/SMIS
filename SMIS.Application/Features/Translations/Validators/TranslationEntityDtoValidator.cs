using FluentValidation;
using SMIS.Application.DTO.Translations;

namespace SMIS.Application.Features.Translations.Validators
{
    public class TranslationEntityDtoValidator : AbstractValidator<TranslationEntityDto>
    {
        public TranslationEntityDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Translation Name is required")
                .MaximumLength(500).WithMessage("Translation Name must not exceed 500 characters");

            RuleFor(x => x.LanguageNo)
                .NotEmpty().WithMessage("LanguageNo is required");

            RuleFor(x => x.TranslationKeyId)
                .NotEmpty().WithMessage("TranslationKeyId is required");
        }
    }
}