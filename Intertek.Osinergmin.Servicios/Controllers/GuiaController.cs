using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Dto;
using Application.MainModule.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Intertek.Osinergmin.Servicios.Controllers
{
    [Produces("application/json")]
    [Route("api/Guia")]
    public class GuiaController : Controller
    {
        private readonly IGuiaAppService _guiaAppService;

        public GuiaController(IGuiaAppService guiaAppService)
        {
            _guiaAppService = guiaAppService;
        }

        [HttpGet("listado")]
        public List<GuiaListadoDto> Listado()
        {
            return _guiaAppService.ObtenerListadoGuia().ToList();
        }

        [HttpGet("detalle/{id}")]
        public List<DetalleGuiaListadoDto> Detalle(int id)
        {
            return _guiaAppService.ObtenerDetalleGuiaListado(id).ToList();
        }

        [HttpGet("{guiaId}", Name = "GetTodo")]
        public async Task<IActionResult> GetById(int guiaId)
        {
            var guiaEntidad = await _guiaAppService.ObtenerGuia(guiaId);            
            return new ObjectResult(guiaEntidad);
        }

        [HttpPost]
        public async Task<IActionResult> Registrar([FromBody] GuiaEntidadDto item)
        {
            if (item == null)
                return BadRequest();

            await _guiaAppService.Agregar(item);
            return new NoContentResult();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] GuiaEntidadDto item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            await _guiaAppService.Actualizar(item);
         
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _guiaAppService.Eliminar(id);
            return new NoContentResult();
        }
    }
}