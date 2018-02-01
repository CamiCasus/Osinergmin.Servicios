using Domain.MainModule.Entities;
using Infraestructura.Data.MainModule.Core;
using Infraestructura.Data.MainModule.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Infraestructura.Data.MainModule
{
    public class GuiaRepository : Repository<GuiaEntity, int>, IGuiaRepository
    {
        public GuiaRepository(DbContext dbContext)
            : base(dbContext)
        {

        }

        public async override Task<GuiaEntity> Get(int id, bool @readonly = true)
        {
            var listaIncluyendoDetalles = DbSet.Include(p => p.Detalles);

            if (@readonly)
                return await listaIncluyendoDetalles.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);

            return await listaIncluyendoDetalles.FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
