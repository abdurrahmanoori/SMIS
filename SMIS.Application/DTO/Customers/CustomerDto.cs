using SMIS.Application.Attributes;

namespace SMIS.Application.DTO.Customers
{
    public class CustomerDto
    {
        public string Id { get; set; } = string.Empty;
        [Translatable]
        public string FirstName { get; set; } = string.Empty;
        [Translatable]
        public string? LastName { get; set; }
        public string ShopId { get; set; } = string.Empty;
        public string? ShopName { get; set; }
        [Translatable]
        public string? FatherName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        [Translatable]
        public string? Address { get; set; }
        public string? TaxNumber { get; set; }
        public string? ProvinceId { get; set; }
        public string? DistrictId { get; set; }
        public bool IsActive { get; set; }
    }
}