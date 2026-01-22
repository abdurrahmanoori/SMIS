using FluentValidation;
using SMIS.Application.Features.Translations.Commands;

namespace SMIS.Application.Features.Translations.Validators
{
    public class TranslationCreateCommandValidator : AbstractValidator<TranslationCreateCommand>
    {
        public TranslationCreateCommandValidator()
        {
            RuleFor(x => x.TranslationCreateDto.Name)
                .NotEmpty().WithMessage("Name is required")
                .MaximumLength(500).WithMessage("Name must not exceed 500 characters");

            RuleFor(x => x.TranslationCreateDto.TranslationKeyId)
                .NotEmpty().WithMessage("TranslationKeyId is required");

            RuleFor(x => x.TranslationCreateDto.LanguageNo)
                .NotEmpty().WithMessage("LanguageNo is required");
        }
    }
}