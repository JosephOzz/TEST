using Application.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class Entity2Configurations : IEntityTypeConfiguration<Entity2>
    {
        public void Configure(EntityTypeBuilder<Entity2> entity)
        {
            entity.ToTable("Entity2");

            entity.HasKey(p => p.Id);
            entity.HasIndex(p => p.Id);

            entity.Property(p => p.Field1)
                .IsRequired()
                .HasMaxLength(180);

            entity.Property(p => p.Field2)
                .IsRequired()
                .HasMaxLength(180);

            entity.Property(p => p.Field3)
                .IsRequired()
                .HasMaxLength(180);
        }
    }
}