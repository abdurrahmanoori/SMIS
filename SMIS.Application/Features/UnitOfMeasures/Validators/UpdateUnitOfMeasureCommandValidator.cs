using FluentValidation;
using SMIS.Application.Features.UnitOfMeasures.Commands;

namespace SMIS.Application.Features.UnitOfMeasures.Validators
{
    public class UpdateUnitOfMeasureCommandValidator : AbstractValidator<UpdateUnitOfMeasureCommand>
    {
        public UpdateUnitOfMeasureCommandValidator()
        {
            RuleFor(x => x.PublicId)
                .NotEmpty().WithMessage("PublicId is required");

            RuleFor(x => x.UnitOfMeasureCreateDto.Name)
                .NotEmpty().WithMessage("Name is required")
                .MaximumLength(100).WithMessage("Name must not exceed 100 characters");

            RuleFor(x => x.UnitOfMeasureCreateDto.Symbol)
                .NotEmpty().WithMessage("Symbol is required")
                .MaximumLength(20).WithMessage("Symbol must not exceed 20 characters");

            RuleFor(x => x.UnitOfMeasureCreateDto.Description)
                .MaximumLength(500).WithMessage("Description must not exceed 500 characters")
                .When(x => !string.IsNullOrEmpty(x.UnitOfMeasureCreateDto.Description));
        }
    }
}
