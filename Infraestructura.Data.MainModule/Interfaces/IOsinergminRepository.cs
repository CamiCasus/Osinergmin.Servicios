using Domain.MainModule.Entities;
using Domain.MainModule.Osinergmin;
using System.Threading.Tasks;

namespace Infraestructura.Data.MainModule.Interfaces
{
    public interface IOsinergminRepository
    {
        Task<OsinergminResponse> RegistrarGuiaOsinergmin(GuiaEntity guiaEntity);
        Task<OsinergminResponse> RegistrarActualizarDetalle(GuiaEntity guiaEntity);
        Task<OsinergminResponse> PresentarOsinergmin(GuiaEntity guiaEntity);
        Task<OsinergminResponse> ValidarMuestra(GuiaEntity guiaEntity, long codigoVerificacion);
        Task<OsinergminResponse> RegistrarInformeEnsayoCombustibleLiquido(InformeEnsayoLiquidoEntity informeEnsayoLiquido);
        Task<OsinergminResponse> RegistrarInformeEnsayoGlp(InformeEnsayoGlpEntity informeEnsayoGlp);
    }
}
