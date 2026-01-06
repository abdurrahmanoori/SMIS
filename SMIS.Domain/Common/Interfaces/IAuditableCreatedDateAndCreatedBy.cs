namespace SMIS.Domain.Common.Interfaces;

public interface IAuditableCreatedDateAndCreatedBy
{
     string? CreatedBy { get; set; }
     DateTime CreatedDate { get; set; }
}
