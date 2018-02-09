using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Dto;
using Application.MainModule.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Intertek.Osinergmin.Servicios.Controllers
{
    [Authorize(Policy = "ApiUser")]
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

            var responseOsinergmin = await _guiaAppService.Agregar(item);
            return new ObjectResult(responseOsinergmin);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] GuiaEntidadDto item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            var responseOsinergmin = await _guiaAppService.Actualizar(item);

            return new ObjectResult(responseOsinergmin);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _guiaAppService.Eliminar(id);
            return new NoContentResult();
        }

        [HttpGet("presentar/{id}")]
        public async Task<IActionResult> PresentarOsinergmin(int id)
        {
            var responseOsinergmin = await _guiaAppService.PresentarOsinergmin(id);
            return new ObjectResult(responseOsinergmin);
        }

        [HttpPost("validarMuestra")]
        public async Task<IActionResult> ValidarMuestra([FromBody]ValidacionMuestraDto validacionMuestraDto)
        {
            var responseOsinergmin = await _guiaAppService.ValidarMuestra(validacionMuestraDto.GuiaId, validacionMuestraDto.CodigoVerificacion);
            return new ObjectResult(responseOsinergmin);
        }

        [HttpPost("registrarInformeEnsayoGlp")]
        public async Task<IActionResult> RegistrarInformeEnsayoGlp([FromBody]InformeEnsayoGlpEntidadDto informeEnsayoGlp)
        {
            var responseOsinergmin = await _guiaAppService.RegistrarInformeEnsayo(informeEnsayoGlp);
            return new ObjectResult(responseOsinergmin);
        }

        [HttpPost("registrarInformeEnsayoLiquido")]
        public async Task<IActionResult> RegistrarInformeEnsayoLiquido([FromBody]InformeEnsayoLiquidoEntidadDto informeEnsayoLiquido)
        {
            var responseOsinergmin = await _guiaAppService.RegistrarInformeEnsayo(informeEnsayoLiquido);
            return new ObjectResult(responseOsinergmin);
        }
    }
}