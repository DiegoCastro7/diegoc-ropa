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
    public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> builder)
        {
            builder.ToTable("Proveedor");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
            .HasColumnName("Id");

            builder.HasIndex(x => x.NitProveedor).IsUnique();

            builder.Property(x => x.Nombre)
            .IsRequired()
            .HasMaxLength(100);

            builder.HasOne(M => M.TipoPersonas)
            .WithMany(F => F.Proveedores)
            .HasForeignKey(M => M.IdTipoPersonaFk);

            builder.HasOne(M => M.Municipios)
            .WithMany(F => F.Proveedores)
            .HasForeignKey(M => M.IdMunicipioFk);
        }
    }
}

