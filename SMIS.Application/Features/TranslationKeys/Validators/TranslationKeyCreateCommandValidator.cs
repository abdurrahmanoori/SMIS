using FluentValidation;
using SMIS.Application.Features.TranslationKeys.Commands;
using SMIS.Application.Repositories.Localization;

namespace SMIS.Application.Features.TranslationKeys.Validators
{
    public class TranslationKeyCreateCommandValidator : AbstractValidator<TranslationKeyCreateCommand>
    {
        public TranslationKeyCreateCommandValidator()
        {
            RuleFor(x => x.TranslationKeyCreateDto.Name)
                .NotEmpty().WithMessage("Name is required")
                .MaximumLength(200).WithMessage("Name must not exceed 200 characters");

            RuleFor(x => x.TranslationKeyCreateDto.MessageCode)
                .MaximumLength(100).WithMessage("MessageCode must not exceed 100 characters")
                .When(x => !string.IsNullOrEmpty(x.TranslationKeyCreateDto.MessageCode));

            //When(x => x.TranslationKeyCreateDto.Translations?.Any() == true, () => {
            //    RuleForEach(x => x.TranslationKeyCreateDto.Translations)
            //        .ChildRules(translation => {
            //            translation.RuleFor(t => t.Name)
            //                .NotEmpty().WithMessage("Translation Name is required")
            //                .MaximumLength(500).WithMessage("Translation Name must not exceed 500 characters");
            //            translation.RuleFor(t => t.LanguageNo)
            //                .NotEmpty().WithMessage("LanguageNo is required");

            //            translation.RuleFor(x => x.TranslationCreateDto)
            //    .MustAsync(async (dto, cancellation) =>
            //    {
            //        var existing = await _translationRepository.GetFirstOrDefaultAsync(
            //            t => t.TranslationKeyId == dto.TranslationKeyId && t.LanguageNo == dto.LanguageNo);
            //        return existing == null;
            //    })
            //    .WithMessage("A translation for this TranslationKey and Language combination already exists");

            //        });
            //});
        }
    }
}