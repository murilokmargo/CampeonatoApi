using Domain.Dtos;
using Domain.Interfaces.Services.Campeonato;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampeonatosController : ControllerBase
    {
        private ICampeonatoService _campeonatoService;
        public CampeonatosController(ICampeonatoService service)
        {
            _campeonatoService = service;
        }

        [HttpGet]
        public async Task<ActionResult> ObterCampeonato()
        {
            var result = await _campeonatoService.ObterCampeonato();
            if (result is null)
            {
                var error = new CampeonatoErrorDto();
                error.Message = "É obrigatório a presença de ao menos 3 times.";
                error.type = "Regra de negócio.";
                return BadRequest(error);
            }

            return Ok(result);
        }
    }
}
