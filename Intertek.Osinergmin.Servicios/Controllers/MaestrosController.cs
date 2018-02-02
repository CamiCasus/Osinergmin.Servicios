using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Dto;
using Application.MainModule.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Distributed.Services.Controllers
{
    [Produces("application/json")]
    [Route("api/Maestros")]
    public class MaestrosController : Controller
    {
        private readonly IProductoAppService _productoAppService;
        public MaestrosController(IProductoAppService productoAppService)
        {
            _productoAppService = productoAppService;
        }

        [HttpGet("productos")]
        public List<ProductoEntidadDto> Listado()
        {
            return _productoAppService.ObtenerProductos().ToList();
        }
    }
}