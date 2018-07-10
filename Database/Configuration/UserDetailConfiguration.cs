using dotnetapi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dotnetapi.Database.Configuration
{
    internal partial class UserDetailConfiguration : IEntityTypeConfiguration<UserDetail>
    {
        public void Configure(EntityTypeBuilder<UserDetail> builder)
        {
            builder.HasKey(e => e.UserDetailId);
            builder.ToTable("UserDetails");

            builder.Property(e => e.UserDetailId).UseMySqlIdentityColumn();
            builder.Property(e => e.UserId).IsRequired().HasAnnotation("unsigned", true);
            builder.Property(e => e.Street).IsRequired().HasColumnType("varchar(100)");
            builder.Property(e => e.Street2).IsRequired().HasColumnType("varchar(100)");
            builder.Property(e => e.City).IsRequired().HasColumnType("varchar(100)");
            builder.Property(e => e.State).IsRequired().HasColumnType("varchar(10)");
            builder.Property(e => e.Zip).IsRequired().HasAnnotation("unsigned", true);
            builder.Property(e => e.Ssn).HasAnnotation("unsigned", true);
            builder.Property(e => e.Phone).IsRequired().HasAnnotation("unsigned", true);
            builder.Property(e => e.BirthDate).IsRequired();
            builder.Property(e => e.BankRouting).HasColumnType("bigint").HasAnnotation("unsigned", true);
            builder.Property(e => e.BankAccount).HasColumnType("bigint").HasAnnotation("unsigned", true);
            builder.Property(e => e.SaleOneId);
            builder.Property(e => e.SaleOneCampaignId);
            builder.Property(e => e.SaleTwoId);
            builder.Property(e => e.SaleTwoCampaignId);
            builder.Property(e => e.SaleThreeId);
            builder.Property(e => e.SaleThreeCampaignId);
            builder.Property(e => e.CreatedAt);
            builder.Property(e => e.UpdatedAt);

            builder.HasOne(e => e.User).WithOne(u => u.Detail);
        }
    }
}