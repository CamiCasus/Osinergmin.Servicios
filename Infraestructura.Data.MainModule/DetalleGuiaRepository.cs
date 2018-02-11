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
    public class DetalleGuiaRepository : Repository<DetalleGuiaEntity, int>, IDetalleGuiaRepository
    {
        public DetalleGuiaRepository(DbContext dbContext)
            : base(dbContext)
        {

        }

        public override IQueryable<DetalleGuiaEntity> Find(Expression<Func<DetalleGuiaEntity, bool>> predicate, bool @readonly = true)
        {
            return (@readonly ? DbSet.AsNoTracking() : DbSet)
                        .Include(p => p.Guia)
                        .Include(p => p.Producto)
                        .Include(p => p.InformeEnsayo)
                        .Where(predicate);
        }

        public override Task<DetalleGuiaEntity> Get(int id, bool @readonly = true)
        {
            return (@readonly ? DbSet.AsNoTracking() : DbSet)
                        .Include(p => p.Guia)
                        .Include(p => p.Producto)
                        .Include(p => p.InformeEnsayo)
                        .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
