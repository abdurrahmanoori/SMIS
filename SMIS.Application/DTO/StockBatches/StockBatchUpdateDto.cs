using SMIS.Application.Common.Models;
using SMIS.Domain.Enums;

namespace SMIS.Application.DTO.StockBatches;

public sealed class StockBatchUpdateDto
{
    public OptionalValue<string?> BatchNumber { get; set; }
    public OptionalValue<DateTime?> ExpirationDate { get; set; }
    public StatusEnum? Status { get; set; }
}