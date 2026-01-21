using SMIS.Domain.Common.BaseAbstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMIS.Domain.Entities.Localization
{
    public class TranslationKey : BaseAuditableEntity
    {
        public string? MessageCode { get; set; }


        public bool IsActive { get; set; } = true;

        public ICollection<Translation> Translations { get; set; } = new List<Translation>();
    }
}