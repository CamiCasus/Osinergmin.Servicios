using Domain.MainModule.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.Data.MainModule.EntityConfigs
{
    public class UsuarioEntityConfig : IEntityTypeConfiguration<UsuarioEntity>
    {
        public void Configure(EntityTypeBuilder<UsuarioEntity> builder)
        {
            //builder.HasKey(p => p.Id);


            //builder.Property(u => u.Codigo).HasMaxLength(20);
        }
    }
}
