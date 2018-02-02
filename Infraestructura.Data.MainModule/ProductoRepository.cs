using Domain.MainModule.Entities;
using Infraestructura.Data.MainModule.Core;
using Infraestructura.Data.MainModule.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.Data.MainModule
{
    public class ProductoRepository : Repository<ProductoEntity, int> , IProductoRepository
    {
        public ProductoRepository(DbContext dbContext)
            : base(dbContext)
        {

        }
    }
}
