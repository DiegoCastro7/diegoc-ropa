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
    public class InsumoProveedorConfiguration : IEntityTypeConfiguration<InsumoProveedor>
    {
        public void Configure(EntityTypeBuilder<InsumoProveedor> builder)
        {
            builder.ToTable("InsumoProveedor");

            builder.HasKey(x => new {x.IdProveedorFk,x.IdInsumoFk});

            builder.HasOne(M => M.Proveedores)
            .WithMany(N => N.InsumoProveedores)
            .HasForeignKey(M => M.IdProveedorFk);

            builder.HasOne(M => M.Insumos)
            .WithMany(F => F.InsumoProveedores)
            .HasForeignKey(M => M.IdInsumoFk );
        }
    }
}
