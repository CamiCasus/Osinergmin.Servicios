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
            return await
                    (@readonly ? DbSet.AsNoTracking() : DbSet)
                        .Include(p => p.Detalles)
                        .ThenInclude(d => d.Producto)
                        .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
