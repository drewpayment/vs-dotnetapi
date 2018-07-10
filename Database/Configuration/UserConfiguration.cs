using dotnetapi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dotnetapi.Database.Configuration
{
    internal partial class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.Id);
            builder.ToTable("Users");

            builder.Property(e => e.Id).UseMySqlIdentityColumn();
            builder.Property(e => e.RoleId).IsRequired();
            builder.Property(e => e.FirstName).IsRequired().HasColumnType("varchar(50)");
            builder.Property(e => e.LastName).IsRequired().HasColumnType("varchar(50)");
            builder.Property(e => e.Username).IsRequired().HasColumnType("varchar(30)");
            builder.Property(e => e.Email).IsRequired().HasColumnType("varchar(60)");
            builder.Property(e => e.Password).IsRequired().HasColumnType("varchar(255)");
            builder.Property(e => e.RememberToken).HasColumnType("varchar(255)");
            builder.Property(e => e.Active).IsRequired();
            builder.Property(e => e.CreatedAt);
            builder.Property(e => e.UpdatedAt);
        }
    }
}