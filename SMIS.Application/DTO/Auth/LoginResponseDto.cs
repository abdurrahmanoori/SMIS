using SMIS.Domain.Entities.Localization;

namespace SMIS.Application.DTO.Auth
{
    public class LoginResponseDto
    {
        public string Token { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string ShopId { get; set; } = string.Empty;
        public string LanguageId { get; set; } = LanguageDefaults.EnglishId;
        public string LanguageCode { get; set; } = LanguageDefaults.EnglishCode;

        public IList<string> Roles { get; set; } = new List<string>();
    }
}