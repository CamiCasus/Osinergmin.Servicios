using Domain.MainModule.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructura.Data.MainModule.EntityConfigs
{
    class InformeEnsayoLiquidoEntityConfig : IEntityTypeConfiguration<InformeEnsayoLiquidoEntity>
    {
        public void Configure(EntityTypeBuilder<InformeEnsayoLiquidoEntity> builder)
        {
            
        }
    }
}
