using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Purchasing;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Services;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.Purchasing.Commands;

public sealed record SupplierPaymentCreateCommand(string SupplierId, SupplierPaymentCreateDto Dto)
    : IRequest<Result<SupplierPaymentDto>>;

internal sealed class SupplierPaymentCreateCommandHandler
    : IRequestHandler<SupplierPaymentCreateCommand, Result<SupplierPaymentDto>>
{
    private readonly IApplicationDbContext _db;
    private readonly ICurrentUser _currentUser;
    private readonly IIdempotencyService _idempotency;
    private readonly IUnitOfWork _unitOfWork;

    public SupplierPaymentCreateCommandHandler(IApplicationDbContext db, ICurrentUser currentUser,
        IIdempotencyService idempotency, IUnitOfWork unitOfWork)
    {
        _db = db;
        _currentUser = currentUser;
        _idempotency = idempotency;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<SupplierPaymentDto>> Handle(SupplierPaymentCreateCommand request,
        CancellationToken cancellationToken)
    {
        var shopId = _currentUser.GetShopId();
        if (string.IsNullOrWhiteSpace(shopId))
            return Result<SupplierPaymentDto>.Forbidden("supplier_payment.shop_required", "Active shop required.");

        // An offline command may be retried after the server committed but its
        // response was lost. Replaying the saved result avoids a second payment.
        var reservation = await _idempotency.BeginReplayableAsync(
            $"supplier:payment:{request.SupplierId}", request.Dto.IdempotencyKey,
            new { ShopId = shopId, request.SupplierId, request.Dto }, cancellationToken);
        if (!reservation.IsSuccess)
            return Result<SupplierPaymentDto>.Failure(reservation.Errors);
        if (reservation.Value?.ResponseJson is not null)
            return _idempotency.Replay<SupplierPaymentDto>(reservation.Value);

        var supplier = await _db.Suppliers.FirstOrDefaultAsync(
            x => x.Id == request.SupplierId && x.ShopId == shopId, cancellationToken);
        if (supplier is null)
            return Result<SupplierPaymentDto>.NotFound("supplier.not_found", "Supplier not found in this shop.");

        // Allocate oldest-first so one payment may settle several Purchase Orders.
        // Load prior allocations: remaining debt is derived, not stored on Supplier.
        var payables = await _db.SupplierPayables
            .Include(x => x.Allocations)
            .Where(x => x.SupplierId == request.SupplierId && x.ShopId == shopId)
            .OrderBy(x => x.CreatedDate)
            .ThenBy(x => x.Id)
            .ToListAsync(cancellationToken);

        var outstanding = payables.Sum(x => x.RemainingAmount);
        if (request.Dto.Amount <= 0 || request.Dto.Amount > outstanding)
            return Result<SupplierPaymentDto>.BusinessRule("supplier_payment.invalid_amount",
                "Payment must be positive and cannot exceed the outstanding supplier debt.");

        var payment = SupplierPayment.Create(shopId, supplier.Id, request.Dto.Amount,
            request.Dto.PaidAtUtc ?? DateTimeService.NowUtc,
            request.Dto.PaymentMethod, request.Dto.ReferenceNumber, request.Dto.Notes);
        var remaining = payment.Amount;
        var result = new SupplierPaymentDto
        {
            Id = payment.Id, ShopId = shopId, SupplierId = supplier.Id,
            Amount = payment.Amount, PaidAtUtc = payment.PaidAtUtc,
            PaymentMethod = payment.PaymentMethod, ReferenceNumber = payment.ReferenceNumber,
            Notes = payment.Notes
        };

        // Each allocation is limited by both the payment remainder and the
        // selected payable's outstanding amount.
        foreach (var payable in payables)
        {
            if (remaining == 0) break;
            var allocated = Math.Min(remaining, payable.RemainingAmount);
            if (allocated == 0) continue;
            payable.RecordAllocation(allocated); // Increments the concurrency token.
            payment.Allocations.Add(SupplierPaymentAllocation.Create(shopId, payment.Id, payable.Id, allocated));
            result.Allocations.Add(new SupplierPaymentAllocationDto
                { SupplierPayableId = payable.Id, PurchaseOrderId = payable.PurchaseOrderId, Amount = allocated });
            remaining -= allocated;
        }

        if (remaining != 0)
            return Result<SupplierPaymentDto>.Conflict("supplier_payment.concurrent_change",
                "Outstanding supplier balance changed; retry the payment.");

        await _db.SupplierPayments.AddAsync(payment, cancellationToken);
        _idempotency.Complete(reservation.Value, result);
        // Save payment, allocations, payable versions, and retry result together.
        // If another payment changed a payable version, reject this stale allocation.
        try
        {
            await _unitOfWork.SaveChanges(cancellationToken);
        }
        catch (DbUpdateConcurrencyException)
        {
            return Result<SupplierPaymentDto>.Conflict("supplier_payment.concurrent_change",
                "Outstanding supplier balance changed; retry the payment.");
        }
        return Result<SupplierPaymentDto>.Success(result);
    }
}
