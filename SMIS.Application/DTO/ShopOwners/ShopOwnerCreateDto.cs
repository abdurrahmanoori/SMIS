namespace SMIS.Application.DTO.ShopOwners
{
    public class ShopOwnerCreateDto
    {
        public string ApplicationUserId { get; set; } = string.Empty;
        public string ShopId { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; }
        public string? NationalIdCardNumber { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public decimal OwnershipPercentage { get; set; } = 100.0m;
        public bool IsActive { get; set; } = true;
        public string? ProvinceId { get; set; }
        public string? DistrictId { get; set; }
    }
}