namespace SMIS.Application.DTO.Users
{
    /// <summary>
    /// Fields accepted by an existing-user update. Password changes deliberately
    /// use ChangePasswordDto and the dedicated change-password endpoint.
    /// </summary>
    public class UserUpdateDto
    {
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? ShopId { get; set; }
        public string? LanguageId { get; set; }
        public IEnumerable<string>? Roles { get; set; }
    }
}