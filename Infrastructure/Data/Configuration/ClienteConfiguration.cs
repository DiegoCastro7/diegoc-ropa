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
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
            .HasColumnName("Id");

            builder.HasIndex(x => x.IdCliente).IsUnique();

            builder.Property(x => x.Nombre)
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(x => x.FechaRegistro);


            builder.HasOne(M => M.TipoPersonas)
            .WithMany(N => N.Clientes)
            .HasForeignKey(M => M.IdTipoPersonaFk);

            builder.HasOne(M => M.Municipios)
            .WithMany(F => F.Clientes)
            .HasForeignKey(M => M.IdMunFk);
        }
    }
}
