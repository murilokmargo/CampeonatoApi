using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class TimeMap : IEntityTypeConfiguration<TimeEntity>
    {
        public void Configure(EntityTypeBuilder<TimeEntity> builder)
        {
            builder.ToTable("Time");

            builder.HasKey(t => t.Id);

            builder.HasIndex(t => t.Nome).IsUnique();

            builder.Property(t => t.Nome).IsRequired();

            builder.HasMany(t => t.TimesA).WithOne(p => p.TimeA).HasForeignKey(p => p.TimeAId).HasPrincipalKey(t => t.Id);
            builder.HasMany(t => t.TimesB).WithOne(p => p.TimeB).HasForeignKey(p => p.TimeBId).HasPrincipalKey(t => t.Id).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
