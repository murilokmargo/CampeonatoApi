using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapping
{
    public class PartidaMap : IEntityTypeConfiguration<PartidaEntity>
    {
        public void Configure(EntityTypeBuilder<PartidaEntity> builder)
        {
            builder.ToTable("Partida");

            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.Campeonato).WithMany(c => c.Partidas).HasForeignKey(p => p.CampeonatoId);

            builder.Property(p => p.GolTimeA).IsRequired();
            builder.Property(p => p.GolTimeB).IsRequired();
        }
    }
}
