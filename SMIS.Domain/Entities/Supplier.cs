using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Exceptions;

namespace SMIS.Domain.Entities;

public sealed class Supplier : BaseAuditableEntity, IShopEntity
{
    public string ShopId { get; private set; } = string.Empty;
    public string Name { get; private set; } = string.Empty;
    public string? PhoneNumber { get; private set; }
    public string? Notes { get; private set; }
    public bool IsActive { get; private set; } = true;

    public Shop Shop { get; set; } = null!;
    public ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();

    internal Supplier()
    {
    }

    public static Supplier Create(
        string shopId,
        string name,
        string? phoneNumber = null,
        string? notes = null)
    {
        if (string.IsNullOrWhiteSpace(shopId))
            throw new DomainValidationException("Shop ID cannot be empty");
        if (string.IsNullOrWhiteSpace(name))
            throw new DomainValidationException("Supplier name cannot be empty");

        return new Supplier
        {
            ShopId = shopId.Trim(),
            Name = name.Trim(),
            PhoneNumber = string.IsNullOrWhiteSpace(phoneNumber) ? null : phoneNumber.Trim(),
            Notes = string.IsNullOrWhiteSpace(notes) ? null : notes.Trim()
        };
    }

    public void Update(string name, string? phoneNumber, string? notes, bool isActive)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new DomainValidationException("Supplier name cannot be empty");

        Name = name.Trim();
        PhoneNumber = string.IsNullOrWhiteSpace(phoneNumber) ? null : phoneNumber.Trim();
        Notes = string.IsNullOrWhiteSpace(notes) ? null : notes.Trim();
        IsActive = isActive;
    }
}
