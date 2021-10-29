using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class CampeonatoDto
    {
        public List<PartidaDto> Partidas { get; set; }

        public string Campeao { get; set; }
        public string Vice { get; set; }
        public string Terceiro { get; set; }
    }
}
