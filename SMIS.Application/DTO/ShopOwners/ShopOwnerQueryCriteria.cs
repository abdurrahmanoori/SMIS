namespace SMIS.Application.DTO.ShopOwners;

public sealed class ShopOwnerQueryCriteria
{
    public string? Id { get; set; }
    public string? ApplicationUserId { get; set; }
    public string? ShopId { get; set; }
    public string? ShopName { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? NationalIdCardNumber { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    public string? Address { get; set; }
    public decimal? OwnershipPercentage { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public bool? IsActive { get; set; }
    public string? ProvinceId { get; set; }
    public string? DistrictId { get; set; }
}