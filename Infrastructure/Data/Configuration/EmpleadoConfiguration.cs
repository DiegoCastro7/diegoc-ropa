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
    public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.ToTable("Empleado");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
            .HasColumnName("Id");

            builder.HasIndex(x => x.IdEmp).IsUnique();

            builder.Property(x => x.Nombre)
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(x => x.FechaIngreso)
            .IsRequired();


            builder.HasOne(M => M.Cargos)
            .WithMany(N => N.Empleados)
            .HasForeignKey(M => M.IdCargoFk);

            builder.HasOne(M => M.Municipios)
            .WithMany(F => F.Empleados)
            .HasForeignKey(M => M.IdMunicipioFk);
        }
    }
}
