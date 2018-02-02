using Domain.MainModule.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructura.Data.MainModule.EntityConfigs
{
    public class DetalleGuiaEntityConfig : IEntityTypeConfiguration<DetalleGuiaEntity>
    {
        public void Configure(EntityTypeBuilder<DetalleGuiaEntity> builder)
        {
            //builder.HasKey(p => p.Id);


            //builder.Property(u => u.Codigo).HasMaxLength(20);
            builder.HasOne(p => p.Producto).WithMany().HasForeignKey(p => p.ProductoId);
        }
    }
}
