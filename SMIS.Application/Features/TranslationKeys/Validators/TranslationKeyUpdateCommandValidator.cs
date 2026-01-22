using FluentValidation;
using SMIS.Application.Features.TranslationKeys.Commands;

namespace SMIS.Application.Features.TranslationKeys.Validators
{
    public class TranslationKeyUpdateCommandValidator : AbstractValidator<TranslationKeyUpdateCommand>
    {
        public TranslationKeyUpdateCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Id is required");

            RuleFor(x => x.TranslationKeyCreateDto.Name)
                .NotEmpty().WithMessage("Name is required")
                .MaximumLength(200).WithMessage("Name must not exceed 200 characters");

            RuleFor(x => x.TranslationKeyCreateDto.MessageCode)
                .MaximumLength(100).WithMessage("MessageCode must not exceed 100 characters")
                .When(x => !string.IsNullOrEmpty(x.TranslationKeyCreateDto.MessageCode));
        }
    }
}