using Domain.MainModule.Entities;
using Infraestructura.Data.MainModule.Core;
using Infraestructura.Data.MainModule.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

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
                        .Where(predicate);
        }
    }
}
