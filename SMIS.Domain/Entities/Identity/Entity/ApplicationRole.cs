using Microsoft.AspNetCore.Identity;

namespace SMIS.Domain.Entities.Identity.Entity
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        //[ForeignKey(nameof())]
        //public ApplicationUser? ApplicationUser { get; set; }
    }
}
