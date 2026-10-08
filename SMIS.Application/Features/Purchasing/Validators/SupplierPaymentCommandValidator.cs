using FluentValidation;
using SMIS.Application.Features.Purchasing.Commands;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.Purchasing.Validators;

public sealed class SupplierPaymentCreateCommandValidator : AbstractValidator<SupplierPaymentCreateCommand>
{
    public SupplierPaymentCreateCommandValidator()
    {
        RuleFor(x => x.SupplierId).NotEmpty().MaximumLength(450);
        RuleFor(x => x.Dto.Amount).GreaterThan(0);
        RuleFor(x => x.Dto.PaymentMethod).NotEmpty().MaximumLength(50);
        RuleFor(x => x.Dto.ReferenceNumber).MaximumLength(100);
        RuleFor(x => x.Dto.Notes).MaximumLength(500);
        RuleFor(x => x.Dto.IdempotencyKey).NotEmpty().MaximumLength(200);
        RuleFor(x => x.Dto.PaidAtUtc).LessThanOrEqualTo(DateTimeService.NowUtc.AddMinutes(5))
            .When(x => x.Dto.PaidAtUtc.HasValue);
    }
}
