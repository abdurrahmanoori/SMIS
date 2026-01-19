using SMIS.Domain.Common.BaseAbstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMIS.Domain.Entities.Localization
{
    public class SigtasDictOther : BaseAuditableEntity
    {
        public int SigtasDictNo { get; set; }

        public int LanguageNo { get; set; }

        public string Description { get; set; } = string.Empty;

        // Navigation properties
        [ForeignKey(nameof(SigtasDictNo))]
        public SigtasDict SigtasDict { get; set; } = null!;

        [ForeignKey(nameof(LanguageNo))]
        public Language Language { get; set; } = null!;
    }
}