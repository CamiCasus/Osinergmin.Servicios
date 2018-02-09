using Domain.MainModule.Entities;
using Infraestructura.Data.MainModule.EntityConfigs;
using Microsoft.EntityFrameworkCore;

namespace Infraestructura.Data.MainModule
{
    public partial class MainModuleContext : DbContext
    {
        public MainModuleContext(DbContextOptions<MainModuleContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new GuiaEntityConfig());
            builder.ApplyConfiguration(new DetalleGuiaEntityConfig());
            builder.ApplyConfiguration(new TablaEntityConfig());
            builder.ApplyConfiguration(new ItemTablaEntityConfig());
            builder.ApplyConfiguration(new ProductoEntityConfig());
            builder.ApplyConfiguration(new UsuarioEntityConfig());
            builder.ApplyConfiguration(new InformeEnsayoEntityConfig());
            builder.ApplyConfiguration(new InformeEnsayoLiquidoEntityConfig());
            builder.ApplyConfiguration(new InformeEnsayoGlpEntityConfig());
        }

        public DbSet<GuiaEntity> Guias { get; set; }
        public DbSet<DetalleGuiaEntity> DetalleGuia { get; set; }
        public DbSet<ProductoEntity> Productos { get; set; }
        public DbSet<TablaEntity> Tablas { get; set; }
        public DbSet<ItemTablaEntity> ItemsTabla { get; set; }
        public DbSet<UsuarioEntity> Usuarios { get; set; }
        public DbSet<InformeEnsayoEntity> InformesEnsayos { get; set; }
        public DbSet<InformeEnsayoLiquidoEntity> InformesEnsayosLiquidos { get; set; }
        public DbSet<InformeEnsayoGlpEntity> InformesEnsayosGlp { get; set; }
    }
}
