using SMIS.Domain.Common.BaseAbstract;
using System.Globalization;
namespace SMIS.Domain.Entities;

public class Customer : BaseAuditableEntity
{
    public string FirstName { get; set; } = string.Empty;
    public string? LastName { get; set; }
    public string ShopId { get; private set; } = string.Empty;
    public string? ShopName { get; set; }
    public string? FatherName { get; set; } = string.Empty;
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }
    public string? TaxNumber { get; set; }
    public bool IsActive { get; set; } = true;
    public bool IsDeleted { get; set; } = false;
    public DateTime? DeletedAt { get; set; }
    public string? DeletedBy { get; set; }


    public virtual Shop Shop { get; set; } = null!;

}
