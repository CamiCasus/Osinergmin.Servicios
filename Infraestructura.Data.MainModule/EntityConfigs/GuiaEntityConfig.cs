using Domain.MainModule.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructura.Data.MainModule.EntityConfigs
{
    public class GuiaEntityConfig : IEntityTypeConfiguration<GuiaEntity>
    {
        public void Configure(EntityTypeBuilder<GuiaEntity> builder)
        {
            //builder.HasKey(p => p.Id);


            //builder.Property(u => u.Codigo).HasMaxLength(20);
        }
    }
}
