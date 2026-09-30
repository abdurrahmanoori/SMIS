using SMIS.Domain.Enums;

namespace SMIS.Application.DTO.Purchasing;

public sealed class PurchaseOrderQueryCriteria
{
    public string? Id { get; set; }
    public string? ShopId { get; set; }
    public string? SupplierId { get; set; }
    public string? SupplierName { get; set; }
    public string? ReferenceNumber { get; set; }
    public DateTime? OrderedAtUtc { get; set; }
    public PurchaseOrderStatus? Status { get; set; }
    public string? Notes { get; set; }
}