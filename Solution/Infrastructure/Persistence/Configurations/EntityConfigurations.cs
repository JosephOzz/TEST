using Application.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class EntityConfigurations : IEntityTypeConfiguration<Entity>
    {
        public void Configure(EntityTypeBuilder<Entity> entity)
        {
            entity.ToTable("Entity");

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

            entity.Property(p => p.Field4)
                .IsRequired()
                .HasMaxLength(180);

            entity.Property(p => p.Field5)
                .IsRequired()
                .HasMaxLength(180);
        }
    }
}