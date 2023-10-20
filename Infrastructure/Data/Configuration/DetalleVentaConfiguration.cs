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
    public class DetalleVentaConfiguration : IEntityTypeConfiguration<DetalleVenta>
    {
        public void Configure(EntityTypeBuilder<DetalleVenta> builder)
        {
            builder.ToTable("DetalleVenta");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
            .HasColumnName("Id");

            builder.Property(x => x.Cantidad)
            .IsRequired();

            builder.Property(x => x.ValorUnit);

            builder.HasOne(M => M.Ventas)
            .WithMany(N => N.DetalleVentas)
            .HasForeignKey(M => M.IdVentaFk);

            builder.HasOne(M => M.Inventarios)
            .WithMany(F => F.DetalleVentas)
            .HasForeignKey(M => M.IdProductoFk);

            builder.HasOne(M => M.Tallas)
            .WithMany(F => F.DetalleVentas)
            .HasForeignKey(M => M.IdTallaFk);
        }
    }
}
