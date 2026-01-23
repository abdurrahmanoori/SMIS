using FluentValidation;
using SMIS.Application.DTO.Translations;
using SMIS.Application.Repositories.Localization;

namespace SMIS.Application.Features.Translations.Validators
{
    public class TranslationEntityCreateDtoValidator : AbstractValidator<TranslationEntityCreateDto>
    {
        private readonly ITranslationRepository _translationRepository;
        public TranslationEntityCreateDtoValidator(ITranslationRepository translationRepository)
        {
            _translationRepository = translationRepository;

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required")
                .MaximumLength(500).WithMessage("Name must not exceed 500 characters");

            RuleFor(x => x.TranslationKeyId)
                    .NotEmpty().WithMessage("TranslationKeyId is required");

            RuleFor(x => x.LanguageNo)
                    .NotEmpty().WithMessage("LanguageNo is required");

            RuleFor(x => x)
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