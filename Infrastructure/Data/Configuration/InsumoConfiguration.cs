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
    public class InsumoConfiguration : IEntityTypeConfiguration<Insumo>
    {
        public void Configure(EntityTypeBuilder<Insumo> builder)
        {
            builder.ToTable("Insumo");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
            .HasColumnName("Id");

            builder.HasIndex(x => x.Nombre).IsUnique();

            builder.Property(x => x.Nombre)
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(x => x.ValorUnit)
            .IsRequired()
            .HasColumnType("decimal(18,2)");

            builder.Property(x => x.StockMin)
            .IsRequired()
            .HasColumnType("int");    

            builder.Property(x => x.StockMax)
            .IsRequired()
            .HasColumnType("int");
        }
    }
}
