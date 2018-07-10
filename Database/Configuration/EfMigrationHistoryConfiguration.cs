using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dotnetapi.Database.Configuration
{
    internal partial class EfMigrationHistoryConfiguration : IEntityTypeConfiguration<EfmigrationsHistory>
    {
        public void Configure(EntityTypeBuilder<EfmigrationsHistory> entity)
        {
            entity.HasKey(e => e.MigrationId);

            entity.ToTable("__EFMigrationsHistory");

            entity.Property(e => e.MigrationId).HasColumnType("varchar(95)");

            entity.Property(e => e.ProductVersion)
                .IsRequired()
                .HasColumnType("varchar(32)");
        }
    }
}