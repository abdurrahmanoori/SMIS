using SMIS.Application.Attributes;
using SMIS.Domain.Enums;

namespace SMIS.Application.DTO.Shops
{
    public class ShopCreateDto
    {
        [Translatable] public string Name { get; set; } = string.Empty;
        public ShopType ShopType { get; set; }
        [Translatable] public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? TaxNumber { get; set; }
        public bool IsActive { get; set; } = true;
    }
}