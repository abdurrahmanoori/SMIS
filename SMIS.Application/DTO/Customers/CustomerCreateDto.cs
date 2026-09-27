using SMIS.Domain.Enums;

namespace SMIS.Application.DTO.Customers
{
    public class CustomerCreateDto
    {
        public string FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; }
        public CustomerType CustomerType { get; set; } = CustomerType.Individual;
        public string? FatherName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? TaxNumber { get; set; }
        public string? ProvinceId { get; set; }
        public string? DistrictId { get; set; }
        public bool IsActive { get; set; } = true;
    }
}