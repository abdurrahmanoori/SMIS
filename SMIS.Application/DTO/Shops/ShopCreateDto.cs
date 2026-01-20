using SMIS.Application.Attributes;
using SMIS.Application.Attributes;
using SMIS.Domain.Enums;

namespace SMIS.Application.DTO.Shops
{
    public class ShopCreateDto
    {

        [Translatable]
        public string Name { get; set; } = string.Empty;
        public ShopType ShopType { get; set; }
        [Translatable]

        public string Address { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string TaxNumber { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
    }
}
