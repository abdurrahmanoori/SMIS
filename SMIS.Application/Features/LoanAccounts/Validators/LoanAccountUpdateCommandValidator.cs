using FluentValidation;
using SMIS.Application.Features.LoanAccounts.Commands;

namespace SMIS.Application.Features.LoanAccounts.Validators;

public class LoanAccountUpdateCommandValidator : AbstractValidator<LoanAccountUpdateCommand>
{
    public LoanAccountUpdateCommandValidator()
    {
        RuleFor(command => command.Id)
            .NotEmpty();

        RuleFor(command => command.Dto.DueDate)
            .GreaterThan(DateTime.UtcNow)
            .When(command => command.Dto.DueDate.HasValue)
            .WithMessage("Due date must be in the future.");

        RuleFor(command => command.Dto.Notes)
            .MaximumLength(500);
    }
}