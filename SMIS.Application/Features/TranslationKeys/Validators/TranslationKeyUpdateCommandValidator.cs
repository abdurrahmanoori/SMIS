using FluentValidation;
using SMIS.Application.DTO.Translations;
using SMIS.Application.Features.TranslationKeys.Commands;
using SMIS.Application.Features.Translations.Validators;

namespace SMIS.Application.Features.TranslationKeys.Validators
{
    public class TranslationKeyUpdateCommandValidator : AbstractValidator<TranslationKeyUpdateCommand>
    {
        public TranslationKeyUpdateCommandValidator(IValidator<TranslationEntityCreateDto> translationEntityCreateDtoValidator)
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Id is required");

            RuleFor(x => x.TranslationKeyCreateDto.Name)
                .NotEmpty().WithMessage("Name is required")
                .MaximumLength(200).WithMessage("Name must not exceed 200 characters");

            RuleFor(x => x.TranslationKeyCreateDto.MessageCode)
                .MaximumLength(100).WithMessage("MessageCode must not exceed 100 characters")
                .When(x => !string.IsNullOrEmpty(x.TranslationKeyCreateDto.MessageCode));

            RuleForEach(x => x.TranslationKeyCreateDto.Translations)
                .SetValidator(translationEntityCreateDtoValidator);

            //When(x => x.TranslationKeyCreateDto.Translations?.Any() == true, () => {
            //    RuleForEach(x => x.TranslationKeyCreateDto.Translations)
            //        .ChildRules(translation => {
            //            translation.RuleFor(t => t.Name)
            //                .NotEmpty().WithMessage("Translation Name is required")
            //                .MaximumLength(500).WithMessage("Translation Name must not exceed 500 characters");
            //            translation.RuleFor(t => t.LanguageNo)
            //                .NotEmpty().WithMessage("LanguageNo is required");
            //        });
            //});
        }
    }
}