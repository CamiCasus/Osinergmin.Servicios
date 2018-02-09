using Domain.MainModule.Entities;
using Infraestructura.Data.MainModule.Core;
using Infraestructura.Data.MainModule.Interfaces;
using Microsoft.EntityFrameworkCore;

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
