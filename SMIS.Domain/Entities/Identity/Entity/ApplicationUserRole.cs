using Microsoft.AspNetCore.Identity;

namespace SMIS.Domain.Entities.Identity.Entity
{
    public class ApplicationUserRole : IdentityUserRole<string>
    {
        public string? UserName { get; set; }
        public string? RoleName { get; set; }
    }
}