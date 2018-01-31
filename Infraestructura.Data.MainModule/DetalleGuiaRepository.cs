using Domain.MainModule.Entities;
using Infraestructura.Data.MainModule.Core;
using Infraestructura.Data.MainModule.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.Data.MainModule
{
    public class DetalleGuiaRepository : Repository<DetalleGuiaEntity, int>, IDetalleGuiaRepository
    {
        public DetalleGuiaRepository(DbContext dbContext)
            : base(dbContext)
        {

        }
    }
}
