using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class PartidaEntity : BaseEntity
    {
        [ForeignKey("TimeId")]
        public Guid TimeAId { get; set; }
        [ForeignKey("TimeId")]
        public Guid TimeBId { get; set; }
        [Required]
        public virtual TimeEntity TimeA { get; set; }
        [Required]
        public virtual TimeEntity TimeB { get; set; }

        [ForeignKey("CampeonatoId")]
        public Guid CampeonatoId { get; set; }
        [Required]
        public virtual CampeonatoEntity Campeonato { get; set; }
        [Required]
        public int GolTimeA { get; set; }
        [Required]
        public int GolTimeB { get; set; }
    }
}
