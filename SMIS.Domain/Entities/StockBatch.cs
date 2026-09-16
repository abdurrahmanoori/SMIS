using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Enums;
using SMIS.Domain.Exceptions;

namespace SMIS.Domain.Entities;

public class StockBatch : BaseAuditableEntityWithoutName, IShopEntity
{
    // Stock is always tracked internally in the product's base unit. The original
    // receiving unit/quantity are kept separately for audit and user-facing history.
    public string ShopId { get; private set; } = string.Empty;
    public string ProductId { get; private set; } = string.Empty;
    public string ReceivedProductUnitId { get; private set; } = string.Empty;
    public decimal ReceivedQuantity { get; private set; }
    public decimal ReceivedQuantityBase { get; private set; }
    public decimal RemainingQuantityBase { get; private set; }
    public long UnitCostBase { get; private set; }
    public string? BatchNumber { get; private set; }
    public DateTime ReceivedAtUtc { get; private set; }
    public DateTime? ExpirationDate { get; private set; }
    public StatusEnum Status { get; private set; } = StatusEnum.Active;

    public virtual Shop Shop { get; set; } = null!;
    public virtual Product Product { get; set; } = null!;
    public virtual ProductUnit ReceivedProductUnit { get; set; } = null!;
    public ICollection<StockMovement> StockMovements { get; set; } = new List<StockMovement>();

    internal StockBatch()
    {
    } // EF Core & Seeding

    public static StockBatch Create(
        string shopId,
        string productId,
        string receivedProductUnitId,
        decimal receivedQuantity,
        decimal baseUnitQuantity,
        long unitCostBase,
        DateTime? receivedAtUtc = null,
        string? batchNumber = null,
        DateTime? expirationDate = null
    )
    {
        var batch = new StockBatch();
        batch.SetShopId(shopId);
        batch.SetProductId(productId);
        batch.SetReceivedProductUnitId(receivedProductUnitId);
        batch.SetInitialQuantity(receivedQuantity, baseUnitQuantity);
        batch.SetUnitCostBase(unitCostBase);
        batch.SetReceivedAtUtc(receivedAtUtc ?? DateTime.UtcNow);
        batch.SetBatchNumber(batchNumber);
        batch.SetExpirationDate(expirationDate);
        return batch;
    }

    private void SetShopId(
        string shopId
    )
    {
        if (string.IsNullOrWhiteSpace(shopId))
            throw new DomainValidationException("Shop ID cannot be empty");

        ShopId = shopId.Trim();
    }

    public void SetProductId(
        string productId
    )
    {
        if (string.IsNullOrWhiteSpace(productId))
            throw new DomainValidationException("Product ID cannot be empty");
        ProductId = productId.Trim();
    }

    private void SetReceivedProductUnitId(
        string productUnitId
    )
    {
        if (string.IsNullOrWhiteSpace(productUnitId))
            throw new DomainValidationException("Received product unit ID cannot be empty");

        ReceivedProductUnitId = productUnitId.Trim();
    }

    private void SetInitialQuantity(
        decimal receivedQuantity,
        decimal baseUnitQuantity
    )
    {
        if (receivedQuantity <= 0)
            throw new DomainValidationException("Received quantity must be greater than zero");
        if (baseUnitQuantity <= 0)
            throw new DomainValidationException("Base unit quantity must be greater than zero");

        ReceivedQuantity = receivedQuantity;
        ReceivedQuantityBase = receivedQuantity * baseUnitQuantity;
        RemainingQuantityBase = ReceivedQuantityBase;
    }

    private void SetUnitCostBase(
        long unitCostBase
    )
    {
        if (unitCostBase < 0)
            throw new DomainValidationException("Unit cost in base units cannot be negative");

        UnitCostBase = unitCostBase;
    }

    private void SetReceivedAtUtc(
        DateTime receivedAtUtc
    )
    {
        var utc = receivedAtUtc.Kind == DateTimeKind.Utc
            ? receivedAtUtc
            : receivedAtUtc.ToUniversalTime();
        if (utc > DateTime.UtcNow.AddMinutes(5))
            throw new DomainValidationException("Received time cannot be in the future");

        ReceivedAtUtc = utc;
    }

    public void SetBatchNumber(
        string? batchNumber
    )
    {
        BatchNumber = string.IsNullOrWhiteSpace(batchNumber) ? null : batchNumber.Trim();
    }

    public void SetExpirationDate(
        DateTime? expirationDate
    )
    {
        if (expirationDate.HasValue && expirationDate.Value <= ReceivedAtUtc)
            throw new DomainValidationException("Expiration date must be after received date");
        ExpirationDate = expirationDate;
    }

    public void Activate() => Status = StatusEnum.Active;
    public void Deactivate() => Status = StatusEnum.Inactive;
    public void MarkAsCompleted() => Status = StatusEnum.Completed;
    public void MarkAsCancelled() => Status = StatusEnum.Cancelled;

    public void ApplyOutMovement(
        decimal quantityBase
    )
    {
        // Application features must reach this method through IInventoryService so the
        // balance update and immutable StockMovement are always committed together.
        // Never subtract the entered transaction quantity directly. Callers must
        // normalize it through ProductUnit.BaseUnitQuantity before reaching here.
        EnsureCanMove(quantityBase);
        if (quantityBase > RemainingQuantityBase)
            throw new DomainValidationException("Insufficient stock in this batch");

        RemainingQuantityBase -= quantityBase;
        Version++;
        if (RemainingQuantityBase == 0)
            Status = StatusEnum.Completed;
    }

    public void ApplyInMovement(
        decimal quantityBase
    )
    {
        // Application features must reach this method through IInventoryService so the
        // cached balance can never change without a matching ledger entry.
        // IN movements restore/increase the cached batch balance. The StockMovement
        // ledger remains the historical source of truth for why the balance changed.
        EnsureCanMove(quantityBase);
        RemainingQuantityBase += quantityBase;
        Version++;
        if (Status == StatusEnum.Completed)
            Status = StatusEnum.Active;
    }

    private void EnsureCanMove(
        decimal quantityBase
    )
    {
        // Completed means the batch is currently exhausted, so an IN reversal may
        // reactivate it. Inactive/cancelled batches, however, cannot accept movement.
        if (quantityBase <= 0)
            throw new DomainValidationException("Movement quantity in base units must be greater than zero");
        if (Status is StatusEnum.Cancelled or StatusEnum.Inactive)
            throw new DomainValidationException("Stock cannot be moved against an inactive or cancelled batch");
    }
}