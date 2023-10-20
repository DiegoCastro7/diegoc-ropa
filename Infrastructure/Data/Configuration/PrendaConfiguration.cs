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
    public class PrendaConfiguration : IEntityTypeConfiguration<Prenda>
    {
        public void Configure(EntityTypeBuilder<Prenda> builder)
        {
            builder.ToTable("Prenda");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
            .HasColumnName("Id");

            builder.HasIndex(x => x.IdPrenda).IsUnique();

            builder.Property(x => x.Nombre)
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(x => x.ValorUnitCop)
            .IsRequired()
            .HasColumnType("decimal(18,2)");

            builder.Property(x => x.ValorUnitUsd)
            .IsRequired()
            .HasColumnType("decimal(18,2)");

            builder.HasOne(M => M.Estados)
            .WithMany(F => F.Prendas)
            .HasForeignKey(M => M.IdEstadoFk);

            builder.HasOne(M => M.TipoProtecciones)
            .WithMany(F => F.Prendas)
            .HasForeignKey(M => M.IdTipoProteccionFk);

            builder.HasOne(M => M.Generos)
            .WithMany(F => F.Prendas)
            .HasForeignKey(M => M.IdGeneroFk);
        }
    }
}

