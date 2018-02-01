using Application.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.MainModule.Interfaces
{
    public interface IGuiaAppService
    {
        IEnumerable<GuiaListadoDto> ObtenerListadoGuia();
        IEnumerable<DetalleGuiaListadoDto> ObtenerDetalleGuiaListado(int guiaId);
        Task<GuiaEntidadDto> ObtenerGuia(int guiaId);

        Task Agregar(GuiaEntidadDto entidadDto);
        Task Actualizar(GuiaEntidadDto entidadDto);
        void Eliminar(long id);
    }
}
