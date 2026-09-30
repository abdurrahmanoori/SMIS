namespace SMIS.Application.DTO.Purchasing;

public sealed class SupplierQueryCriteria
{
    public string? Id { get; set; }
    public string? ShopId { get; set; }
    public string? Name { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Notes { get; set; }
    public bool? IsActive { get; set; }
}