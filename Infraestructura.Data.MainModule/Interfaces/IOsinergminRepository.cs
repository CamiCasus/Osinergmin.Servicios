using Domain.MainModule.Entities;
using Domain.MainModule.Osinergmin;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infraestructura.Data.MainModule.Interfaces
{
    public interface IOsinergminRepository
    {
        Task<OsinergminResponse> RegistrarGuiaOsinergmin(GuiaEntity guiaEntity);
        Task<OsinergminResponse> RegistrarActualizarDetalle(GuiaEntity guiaEntity);
    }
}
