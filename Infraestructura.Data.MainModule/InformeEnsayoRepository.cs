using Domain.MainModule.Entities;
using Infraestructura.Data.MainModule.Core;
using Infraestructura.Data.MainModule.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Infraestructura.Data.MainModule
{
    public class InformeEnsayoRepository : Repository<InformeEnsayoEntity, int>, IInformeEnsayoRepository
    {
        public InformeEnsayoRepository(DbContext dbContext)
            : base(dbContext)
        {

        }

        public override IQueryable<InformeEnsayoEntity> Find(Expression<Func<InformeEnsayoEntity, bool>> predicate, bool @readonly = true)
        {
            return (@readonly ? DbSet.AsNoTracking() : DbSet)
                        .Include(p => p.DetalleGuia)
                        .ThenInclude(d => d.Guia)
                        .Where(predicate);
        }

        public override Task<InformeEnsayoEntity> Get(int id, bool @readonly = true)
        {
            return (@readonly ? DbSet.AsNoTracking() : DbSet)
                        .Include(p => p.DetalleGuia)
                        .ThenInclude(d => d.Guia)
                        .FirstOrDefaultAsync(p => p.Id == id);
        }

        public Task<InformeEnsayoEntity> GetByDetalleId(int detalleId, bool @readonly = true)
        {
            return (@readonly ? DbSet.AsNoTracking() : DbSet)
                        .Include(p => p.DetalleGuia)
                        .ThenInclude(d => d.Guia)
                        .FirstOrDefaultAsync(p => p.DetalleGuiaId == detalleId);
        }
    }
}
