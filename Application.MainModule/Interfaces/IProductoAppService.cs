using Application.Dto;
using System.Collections.Generic;

namespace Application.MainModule.Interfaces
{
    public interface IProductoAppService
    {
        IEnumerable<ProductoEntidadDto> ObtenerProductos();
    }
}
