using FluentValidation;
using SMIS.Application.Features.Translations.Commands;
using SMIS.Application.Repositories.Localization;

namespace SMIS.Application.Features.Translations.Validators
{
    public class TranslationUpdateCommandValidator : AbstractValidator<TranslationUpdateCommand>
    {
        private readonly ITranslationRepository _translationRepository;

        public TranslationUpdateCommandValidator(ITranslationRepository translationRepository)
        {
            _translationRepository = translationRepository;

            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Id is required");

            RuleFor(x => x.TranslationCreateDto.Name)
                .NotEmpty().WithMessage("Name is required")
                .MaximumLength(500).WithMessage("Name must not exceed 500 characters");

            RuleFor(x => x.TranslationCreateDto.TranslationKeyId)
                .NotEmpty().WithMessage("TranslationKeyId is required");

            RuleFor(x => x.TranslationCreateDto.LanguageNo)
                .NotEmpty().WithMessage("LanguageNo is required");

            RuleFor(x => x)
                .MustAsync(async (command, cancellation) => 
                {
                    var existing = await _translationRepository.GetFirstOrDefaultAsync(
                        t => t.TranslationKeyId == command.TranslationCreateDto.TranslationKeyId && 
                             t.LanguageNo == command.TranslationCreateDto.LanguageNo &&
                             t.Id != command.Id);
                    return existing == null;
                })
                .WithMessage("A translation for this TranslationKey and Language combination already exists");
        }
    }
}