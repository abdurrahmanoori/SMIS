using FluentValidation;
using SMIS.Application.Features.Districts.Commands;

namespace SMIS.Application.Features.Districts.Validators;

public sealed class DistrictCreateCommandValidator : AbstractValidator<DistrictCreateCommand>
{
    public DistrictCreateCommandValidator()
    {
        RuleFor(command => command.DistrictCreateDto.Name)
            .NotEmpty()
            .MaximumLength(200);

        RuleFor(command => command.DistrictCreateDto.ProvinceId)
            .NotEmpty();
    }
}