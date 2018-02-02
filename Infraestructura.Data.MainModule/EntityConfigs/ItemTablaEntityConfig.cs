using Domain.MainModule.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructura.Data.MainModule.EntityConfigs
{
    public class ItemTablaEntityConfig : IEntityTypeConfiguration<ItemTablaEntity>
    {
        public void Configure(EntityTypeBuilder<ItemTablaEntity> builder)
        {
            //builder.HasKey(p => p.Id);

            //builder.Property(u => u.Codigo).HasMaxLength(20);
        }
    }
}
