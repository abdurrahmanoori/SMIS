using SMIS.Domain.Enums;

namespace SMIS.Application.DTO.Shops;

public sealed class ShopQueryCriteria
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public ShopType? ShopType { get; set; }
    public string? Address { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    public string? TaxNumber { get; set; }
    public bool? IsActive { get; set; }
}
