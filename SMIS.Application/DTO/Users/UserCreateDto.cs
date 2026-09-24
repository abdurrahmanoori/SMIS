using SMIS.Application.Attributes;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Application.DTO.Users
{
    public class UserCreateDto
    {
        public string UserName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string? PhoneNumber { get; set; }
        public string Password { get; set; } = default!;

        [Translatable] public string? FirstName { get; set; }

        [Translatable] public string? LastName { get; set; }

        public string ShopId { get; set; } = default!;
        public string LanguageId { get; set; } = LanguageDefaults.EnglishId;
        public IEnumerable<string>? Roles { get; set; }
    }
}