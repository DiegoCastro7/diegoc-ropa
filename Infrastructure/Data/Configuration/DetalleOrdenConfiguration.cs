
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
    public class DetalleOrdenConfiguration : IEntityTypeConfiguration<DetalleOrden>
    {
        public void Configure(EntityTypeBuilder<DetalleOrden> builder)
        {
            builder.ToTable("DetalleOrden");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
            .HasColumnName("Id");

            builder.Property(x => x.CantidadProducida)
            .IsRequired()
            .HasColumnType("int");

            builder.Property(x => x.CantidadProducir)
            .IsRequired()
            .HasColumnType("int");

            builder.HasOne(M => M.Ordenes)
            .WithMany(N => N.DetalleOrdenes)
            .HasForeignKey(M => M.IdOrdenFk);

            builder.HasOne(M => M.Prendas)
            .WithMany(F => F.DetalleOrdenes)
            .HasForeignKey(M => M.IdPrendaFk);

            builder.HasOne(M => M.Estados)
            .WithMany(F => F.DetalleOrdenes)
            .HasForeignKey(M => M.IdEstadoFk);

            builder.HasOne(M => M.Colores)
            .WithMany(F => F.DetalleOrdenes)
            .HasForeignKey(M => M.IdColorFk);
        }
    }
}