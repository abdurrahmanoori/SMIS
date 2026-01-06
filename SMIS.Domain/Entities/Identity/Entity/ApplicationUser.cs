
using Microsoft.AspNetCore.Identity;

namespace SMIS.Domain.Entities.Identity.Entity
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

 
        //public List<ApplicationRole>? ApplicationRoles { get; set; }
    }
}
