namespace SMIS.Application.DTO.Customers;

public sealed class CustomerSyncCreateDto : CustomerCreateDto
{
    public string Id { get; set; } = string.Empty;
    public DateTime ClientCreatedDate { get; set; }
    public DateTime ClientModifiedDate { get; set; }
    public string? ClientCreatedBy { get; set; }
    public string? ClientModifiedBy { get; set; }
}
