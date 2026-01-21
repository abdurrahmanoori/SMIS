
using Microsoft.AspNetCore.Identity;

namespace SMIS.Domain.Entities.Identity.Entity
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string PublicId { get; set; } = string.Empty;

        public string? FirstName { get; set; }
        public string? LastName { get; set; }

 
        //public List<ApplicationRole>? ApplicationRoles { get; set; }
    }
}
