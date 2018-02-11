using Domain.MainModule.Entities;
using Infraestructura.Data.MainModule.Core.Interfaces;
using System.Threading.Tasks;

namespace Infraestructura.Data.MainModule.Interfaces
{
    public interface IInformeEnsayoRepository : IRepository<InformeEnsayoEntity, int>
    {
        Task<InformeEnsayoEntity> GetByDetalleId(int detalleId, bool @readonly = true);
    }
}
