using System.Collections.Generic;
using System.Linq;
using Application.Dto;
using Application.Dto.Enums;
using Application.MainModule.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Distributed.Services.Controllers
{
    [Authorize(Policy = "ApiUser")]
    [Produces("application/json")]
    [Route("api/Maestros")]
    public class MaestrosController : Controller
    {
        private readonly IProductoAppService _productoAppService;
        private readonly IItemTablaAppService _itemTablaAppService;

        public MaestrosController(
            IProductoAppService productoAppService,
            IItemTablaAppService itemTablaAppService)
        {
            _productoAppService = productoAppService;
            _itemTablaAppService = itemTablaAppService;
        }

        [HttpGet("productos")]
        public List<ProductoEntidadDto> Listado()
        {
            return _productoAppService.ObtenerProductos().ToList();
        }

        [HttpGet("envases")]
        public List<ItemTablaEntidadDto> Envases()
        {
            return _itemTablaAppService.ObtenerDatosMaestro((int)TipoTablaEnum.Envases).ToList();
        }

        [HttpGet("origenProducto")]
        public List<ItemTablaEntidadDto> OrigenProducto()
        {
            return _itemTablaAppService.ObtenerDatosMaestro((int)TipoTablaEnum.OrigenProducto).ToList();
        }
    }
}