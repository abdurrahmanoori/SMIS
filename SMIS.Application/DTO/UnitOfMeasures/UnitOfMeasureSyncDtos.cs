namespace SMIS.Application.DTO.UnitOfMeasures;

public class UnitOfMeasureSyncUpdateDto
{
    public string Name { get; set; } = string.Empty;
    public string? Symbol { get; set; }
    public string? Description { get; set; }
    public DateTime ClientModifiedDate { get; set; }
}

public sealed class UnitOfMeasureSyncCreateDto : UnitOfMeasureSyncUpdateDto
{
    public string Id { get; set; } = string.Empty;
}

public sealed class UnitOfMeasureSyncDeleteDto
{
    public DateTime ClientModifiedDate { get; set; }
}