namespace SMIS.Application.DTO.Customers;

public sealed class CustomerSyncUpdateDto : CustomerCreateDto
{
    public DateTime ClientModifiedDate { get; set; }
    public string? ClientModifiedBy { get; set; }
}
