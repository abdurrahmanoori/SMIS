using SMIS.Application.Attributes;
using SMIS.Application.DTO.Shops;

namespace SMIS.Application.DTO.Users
{
    public class UserDto
    {
        public string Id { get; set; } = string.Empty;
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        
        [Translatable]
        public string? FirstName { get; set; }
        
        [Translatable]
        public string? LastName { get; set; }
        
        public string ShopId { get; set; } = string.Empty;
        public bool EmailConfirmed { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public ShopDto? Shop { get; set; }
    }
}