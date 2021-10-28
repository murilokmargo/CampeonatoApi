using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CampeonatoEntity : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<PartidaEntity>  Partidas { get; set; }

    }
}
