using Domain.Interfaces.Services.Campeonato;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        //[HttpGet]
        //public async Task<ActionResult> GetAll()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    try
        //    {
        //        return Ok(await _campeonatoService.GetAll());
        //    }
        //    catch (ArgumentException e)
        //    {
        //        return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
        //    }
        //}

        [HttpGet]
        public async Task<ActionResult> ObterCampeonato()
        {
            var result = await _campeonatoService.ObterCampeonato();
            if (result is null)
            {
                return BadRequest();
            }

            return Ok(result);
        }
    }
}
