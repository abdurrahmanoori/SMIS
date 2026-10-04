using System.Text.Json.Serialization;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Application.DTO.Users
{
    public class UserCreateDto
    {
        public string UserName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string? PhoneNumber { get; set; }
        public string Password { get; set; } = default!;

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        // Resolved by the server from the authenticated JWT shop context.
        // It is deliberately excluded from the HTTP request contract.
        [JsonIgnore]
        public string ShopId { get; internal set; } = string.Empty;

        public string LanguageId { get; set; } = LanguageDefaults.EnglishId;
        public IEnumerable<string>? Roles { get; set; }
    }
}