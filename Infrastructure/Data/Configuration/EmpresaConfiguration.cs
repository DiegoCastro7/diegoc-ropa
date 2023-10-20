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
    public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("Empresa");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
            .HasColumnName("Id");

            builder.HasIndex(x => x.Nit).IsUnique();

            builder.Property(x => x.RazonSocial)
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(x => x.RepresentanteLegal)
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(x => x.FechaCreacion);

            builder.HasOne(M => M.Municipios)
            .WithMany(F => F.Empresas)
            .HasForeignKey(M => M.IdMunFk);
        }
    }
}
