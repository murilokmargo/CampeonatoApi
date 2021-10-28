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
    public class CampeonatoMap : IEntityTypeConfiguration<CampeonatoEntity>
    {
        public void Configure(EntityTypeBuilder<CampeonatoEntity> builder)
        {
            builder.ToTable("Campeonato");

            builder.HasKey(c => c.Id);

            builder.HasMany(c => c.Partidas).WithOne().HasForeignKey(p => p.CampeonatoId); 
        }
    }
}
