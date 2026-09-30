using SMIS.Domain.Enums;

namespace SMIS.Application.DTO.Customers;

public sealed class CustomerQueryCriteria
{
    public string? Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? ShopId { get; set; }
    public string? ShopName { get; set; }
    public CustomerType? CustomerType { get; set; }
    public string? FatherName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }
    public string? TaxNumber { get; set; }
    public string? ProvinceId { get; set; }
    public string? DistrictId { get; set; }
    public bool? IsActive { get; set; }
}