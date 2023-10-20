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
    public class OrdenConfiguration : IEntityTypeConfiguration<Orden>
    {
        public void Configure(EntityTypeBuilder<Orden> builder)
        {
            builder.ToTable("Orden");

            builder.HasKey(x => x.IdOrden);
            builder.Property(x => x.IdOrden)
            .HasColumnName("Id");

            builder.Property(x => x.Fecha)
            .IsRequired()
            .HasColumnType("datetime");

            builder.HasOne(M => M.Empleados)
            .WithMany(F => F.Ordenes)
            .HasForeignKey(M => M.IdEmpleadoFk);

            builder.HasOne(M => M.Estados)
            .WithMany(F => F.Ordenes)
            .HasForeignKey(M => M.IdEstadoFk);

            builder.HasOne(M => M.Clientes)
            .WithMany(F => F.Ordenes)
            .HasForeignKey(M => M.IdClienteFk);
        }
    }
}

