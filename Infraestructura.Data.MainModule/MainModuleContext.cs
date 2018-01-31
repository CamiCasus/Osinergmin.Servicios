using Domain.MainModule.Entities;
using Infraestructura.Data.MainModule.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.Data.MainModule
{
    public partial class MainModuleContext : DbContext
    {
        public MainModuleContext(DbContextOptions<MainModuleContext> options)
            : base(options)
        {
        }

        public DbSet<GuiaEntity> Guias { get; set; }
    }
}
