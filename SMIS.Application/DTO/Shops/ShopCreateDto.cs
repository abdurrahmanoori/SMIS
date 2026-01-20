using SMIS.Domain.Enums;

namespace SMIS.Application.DTO.Shops
{
    public class ShopCreateDto
    {
        public string Name { get; set; } = string.Empty;
        public ShopType ShopType { get; set; }
        public string Address { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string TaxNumber { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
    }
}
