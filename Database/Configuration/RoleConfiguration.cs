
using dotnetapi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dotnetapi.Database.Configuration
{
    internal partial class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> b)
        {
            b.HasKey(e => e.RoleId);
            b.ToTable("Roles");

            b.Property(e => e.RoleId).UseMySqlIdentityColumn();
            b.Property(e => e.Name).IsRequired().HasColumnType("varchar(100)");
            b.Property(e => e.Description);
            b.Property(e => e.Order).IsRequired();
            b.Property(e => e.IsActive).IsRequired();
            b.Property(e => e.CreatedAt);
            b.Property(e => e.UpdatedAt);
            b.Property(e => e.ModifiedBy).IsRequired();

            // RELATIONSHIPS
            b.HasMany(u => u.Users).WithOne(r => r.Role).HasForeignKey(u => u.RoleId);
        }
    }
}