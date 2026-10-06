namespace SMIS.Application.DTO.Purchasing;

public sealed class SupplierSyncCreateDto
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string? PhoneNumber { get; set; }
    public string? Notes { get; set; }
    public bool IsActive { get; set; } = true;
    public DateTime ClientModifiedDate { get; set; }
}

public sealed class SupplierSyncUpdateDto
{
    public string Name { get; set; } = string.Empty;
    public string? PhoneNumber { get; set; }
    public string? Notes { get; set; }
    public bool IsActive { get; set; }
    public DateTime ClientModifiedDate { get; set; }
}
