namespace SMIS.Application.DTO.Shops;

public sealed class ShopSyncCreateDto : ShopCreateDto
{
    public string Id { get; set; } = string.Empty;
    public DateTime ClientModifiedDate { get; set; }
}

public sealed class ShopSyncUpdateDto : ShopUpdateDto
{
    public DateTime ClientModifiedDate { get; set; }
}

public sealed class ShopSyncDeleteDto
{
    public DateTime ClientModifiedDate { get; set; }
}