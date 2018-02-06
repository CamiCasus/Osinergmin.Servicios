using Application.Dto;
using Domain.MainModule.Osinergmin;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.MainModule.Interfaces
{
    public interface IGuiaAppService
    {
        IEnumerable<GuiaListadoDto> ObtenerListadoGuia();
        IEnumerable<DetalleGuiaListadoDto> ObtenerDetalleGuiaListado(int guiaId);
        Task<GuiaEntidadDto> ObtenerGuia(int guiaId);

        Task<OsinergminResponse> Agregar(GuiaEntidadDto entidadDto);
        Task<OsinergminResponse> Actualizar(GuiaEntidadDto entidadDto);
        void Eliminar(long id);
        Task<OsinergminResponse> PresentarOsinergmin(int guiaId);
        Task<OsinergminResponse> ValidarMuestra(int guiaId, long codigoVerificacion);
    }
}
