using Domain.MainModule.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructura.Data.MainModule.EntityConfigs
{
    public class InformeEnsayoGlpEntityConfig : IEntityTypeConfiguration<InformeEnsayoGlpEntity>
    {
        public void Configure(EntityTypeBuilder<InformeEnsayoGlpEntity> builder)
        {
            
        }
    }
}
