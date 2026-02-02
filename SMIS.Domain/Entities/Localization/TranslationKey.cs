using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Common.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMIS.Domain.Entities.Localization;

public class TranslationKey : BaseAuditableEntity, IEntity
{
    public string Name { get; set; } = string.Empty;
    public string? MessageCode { get; set; }
    public string ShopId { get; set; } = string.Empty;

    public bool IsActive { get; set; } = true;

    public ICollection<Translation> Translations { get; set; } = new List<Translation>();
    
    [ForeignKey(nameof(ShopId))]
    public Shop Shop { get; set; } = null!;
}