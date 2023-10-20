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
    public class InsumoPrendaConfiguration : IEntityTypeConfiguration<InsumoPrenda>
    {
        public void Configure(EntityTypeBuilder<InsumoPrenda> builder)
        {
            builder.ToTable("InsumoPrenda");

            builder.HasKey(x => new {x.IdInsumoFk,x.IdPrendaFk});

            builder.HasOne(M => M.Insumos)
            .WithMany(N => N.InsumoPrendas)
            .HasForeignKey(M => M.IdInsumoFk);

            builder.HasOne(M => M.Prendas)
            .WithMany(F => F.InsumoPrendas)
            .HasForeignKey(M => M.IdPrendaFk);
        }
    }
}
