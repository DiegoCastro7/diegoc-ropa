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
    public class InventarioConfiguration : IEntityTypeConfiguration<Inventario>
    {
        public void Configure(EntityTypeBuilder<Inventario> builder)
        {
            builder.ToTable("Inventario");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
            .HasColumnName("Id");

            builder.HasIndex(x => x.CodInv).IsUnique();

            builder.Property(x => x.ValorUnitCop)
            .IsRequired()
            .HasColumnType("decimal(18,2)");

            builder.Property(x => x.ValorUnitUsd)
            .IsRequired()
            .HasColumnType("decimal(18,2)");

            builder.HasOne(M => M.Prendas)
            .WithMany(F => F.Inventarios)
            .HasForeignKey(M => M.IdPrendaFk);
        }
    }
}
