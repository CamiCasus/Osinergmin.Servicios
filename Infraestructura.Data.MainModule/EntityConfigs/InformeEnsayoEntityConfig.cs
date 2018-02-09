using Domain.MainModule.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructura.Data.MainModule.EntityConfigs
{
    public class InformeEnsayoEntityConfig : IEntityTypeConfiguration<InformeEnsayoEntity>
    {
        public void Configure(EntityTypeBuilder<InformeEnsayoEntity> builder)
        {
            //builder.HasKey(p => p.Id);


            builder.HasOne(p => p.DetalleGuia)
                .WithOne(p => p.InformeEnsayo)
                .HasForeignKey<InformeEnsayoEntity>(p => p.DetalleGuiaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
