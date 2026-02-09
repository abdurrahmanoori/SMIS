namespace SMIS.Application.DTO.ShopOwners
{
    public class ShopOwnerDto
    {
        public string Id { get; set; } = string.Empty;
        public string ApplicationUserId { get; set; } = string.Empty;
        public string ShopId { get; set; } = string.Empty;
        public string ShopName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; }
        public string? NationalIdCardNumber { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public decimal OwnershipPercentage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsActive { get; set; }
        public string? ProvinceId { get; set; }
        public string? DistrictId { get; set; }
    }
}