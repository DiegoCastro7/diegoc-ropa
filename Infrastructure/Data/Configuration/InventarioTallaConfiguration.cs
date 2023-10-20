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
    public class InventarioTallaConfiguration : IEntityTypeConfiguration<InventarioTalla>
    {
        public void Configure(EntityTypeBuilder<InventarioTalla> builder)
        {
            builder.ToTable("InventarioTalla");

            builder.HasKey(x => new{x.IdInvFk,x.IdTallaFk});

            builder.HasOne(M => M.Inventarios)
            .WithMany(F => F.InventarioTallas)
            .HasForeignKey(M => M.IdInvFk);

            builder.HasOne(M => M.Tallas)
            .WithMany(F => F.InventarioTallas)
            .HasForeignKey(M => M.IdTallaFk);
        }
    }
}

