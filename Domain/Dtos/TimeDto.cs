using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class TimeDto
    {

        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome é um campo obrigatório")]
        [MinLength (3, ErrorMessage = "Nome deve ter no mínimo 3 letras")]
        public string Nome { get; set; }
    }
}
