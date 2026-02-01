
using Microsoft.AspNetCore.Identity;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Enums;

namespace SMIS.Domain.Entities.Identity.Entity;

public class ApplicationUser : IdentityUser<string>, IEntityPK
{
    public override string Id { get; set; } = Guid.NewGuid().ToString();
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Version { get ; set ; }
    public EntityStateEnum EntityState { get ; set ; }
    public DateTimeOffset LastModifiedUtc { get ; set ; }


    //public List<ApplicationRole>? ApplicationRoles { get; set; }
}
