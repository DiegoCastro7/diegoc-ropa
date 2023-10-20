using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class TipoProteccionConfiguration : IEntityTypeConfiguration<TipoProteccion>
    {
        public void Configure(EntityTypeBuilder<TipoProteccion> builder)
        {
            builder.ToTable("TipoProteccion");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
            .HasColumnName("Id");

            builder.Property(x => x.Descripcion)
            .IsRequired()
            .HasMaxLength(200);
        }
    }
}

