using SMIS.Domain.Enums;

namespace SMIS.Application.DTO.StockBatches;

public sealed class StockBatchUpdateDto
{
    public string? BatchNumber { get; set; }
    public DateTime? ExpirationDate { get; set; }
    public StatusEnum? Status { get; set; }
}