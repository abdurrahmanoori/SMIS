using Microsoft.AspNetCore.Identity;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Enums;

namespace SMIS.Domain.Entities.Identity.Entity;

public class ApplicationRole : IdentityRole<string>, IEntityPK
{
    public override string Id { get; set; } = Guid.NewGuid().ToString();
    public int Version { get ; set ; }
    public EntityStateEnum EntityState { get ; set ; }
    public DateTimeOffset LastModifiedUtc { get ; set ; }
    //[ForeignKey(nameof())]
    //public ApplicationUser? ApplicationUser { get; set; }
}
