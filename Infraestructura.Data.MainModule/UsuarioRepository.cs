using Domain.MainModule.Entities;
using Infraestructura.Data.MainModule.Core;
using Infraestructura.Data.MainModule.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Data.MainModule
{
    public class UsuarioRepository : Repository<UsuarioEntity, int>, IUsuarioRepository
    {
        public UsuarioRepository(DbContext dbContext)
            : base(dbContext)
        {

        }
    }
}
