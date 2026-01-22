using FluentValidation;
using SMIS.Application.Features.Translations.Commands;
using SMIS.Application.Repositories.Localization;

namespace SMIS.Application.Features.Translations.Validators
{
    public class TranslationCreateCommandValidator : AbstractValidator<TranslationCreateCommand>
    {
        private readonly ITranslationRepository _translationRepository;

        public TranslationCreateCommandValidator(ITranslationRepository translationRepository)
        {
            _translationRepository = translationRepository;

            RuleFor(x => x.TranslationCreateDto.Name)
                .NotEmpty().WithMessage("Name is required")
                .MaximumLength(500).WithMessage("Name must not exceed 500 characters");

            RuleFor(x => x.TranslationCreateDto.TranslationKeyId)
                .NotEmpty().WithMessage("TranslationKeyId is required");

            RuleFor(x => x.TranslationCreateDto.LanguageNo)
                .NotEmpty().WithMessage("LanguageNo is required");

            RuleFor(x => x.TranslationCreateDto)
                .MustAsync(async (dto, cancellation) => 
                {
                    var existing = await _translationRepository.GetFirstOrDefaultAsync(
                        t => t.TranslationKeyId == dto.TranslationKeyId && t.LanguageNo == dto.LanguageNo);
                    return existing == null;
                })
                .WithMessage("A translation for this TranslationKey and Language combination already exists");
        }
    }
}