using Domain.MainModule.Entities;
using Infraestructura.Data.MainModule.Core;
using Infraestructura.Data.MainModule.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infraestructura.Data.MainModule
{
    public class ItemTablaRepository : Repository<ItemTablaEntity, int>, IItemTablaRepository
    {
        public ItemTablaRepository(DbContext dbContext)
           : base(dbContext)
        {

        }
    }
}
