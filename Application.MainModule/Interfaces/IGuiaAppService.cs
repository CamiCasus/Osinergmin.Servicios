using Application.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.MainModule.Interfaces
{
    public interface IGuiaAppService
    {
        IEnumerable<GuiaListadoDto> ObtenerListadoGuia();
        IEnumerable<DetalleGuiaListadoDto> ObtenerDetalleGuiaListado(int guiaId);
        GuiaEntidadDto ObtenerGuia(long guiaId);

        void Agregar(GuiaEntidadDto entidadDto);
        void Eliminar(long id);
    }
}
