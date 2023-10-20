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
    public class VentaConfiguration : IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> builder)
        {
            builder.ToTable("Venta");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
            .HasColumnName("Id");

            builder.Property(x => x.Fecha)
            .IsRequired()
            .HasColumnType("datetime");

            builder.HasOne(M => M.Empleados)
            .WithMany(F => F.Ventas)
            .HasForeignKey(M => M.IdEmpleadoFk);

            builder.HasOne(M => M.FormaPagos)
            .WithMany(F => F.Ventas)
            .HasForeignKey(M => M.IdFormaPagoFk);   

            builder.HasOne(M => M.Clientes)
            .WithMany(F => F.Ventas)
            .HasForeignKey(M => M.IdClienteFk);
        }
    }
}

