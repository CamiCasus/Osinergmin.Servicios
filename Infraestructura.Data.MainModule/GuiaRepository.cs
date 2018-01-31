using Domain.MainModule.Entities;
using Infraestructura.Data.MainModule.Core;
using Infraestructura.Data.MainModule.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infraestructura.Data.MainModule
{
    public class GuiaRepository : Repository<GuiaEntity, int>, IGuiaRepository
    {
        public GuiaRepository(DbContext dbContext)
            : base(dbContext)
        {

        }
    }
}
