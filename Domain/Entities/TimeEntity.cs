using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TimeEntity : BaseEntity
    {
        [Required, MinLength(3)]
        public string Nome { get; set; }
        public ICollection<PartidaEntity> TimesA { get; set; }
        public ICollection<PartidaEntity> TimesB { get; set; }
    }
}
