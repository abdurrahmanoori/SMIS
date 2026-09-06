namespace SMIS.Application.DTO.Customers;

public sealed class CustomerSyncDeleteDto
{
    public DateTime ClientModifiedDate { get; set; }
    public string? ClientModifiedBy { get; set; }
}
