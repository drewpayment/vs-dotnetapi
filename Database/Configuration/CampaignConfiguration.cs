
using dotnetapi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dotnetapi.Database.Configuration
{
    internal partial class CampaignConfiguration : IEntityTypeConfiguration<Campaign>
    {
        public void Configure(EntityTypeBuilder<Campaign> b)
        {
            b.HasKey(e => e.CampaignId);
            b.ToTable("Campaigns");

            b.Property(e => e.CampaignId).UseMySqlIdentityColumn();
            b.Property(e => e.Name).IsRequired().HasColumnType("varchar(100)");
            b.Property(e => e.Street).HasColumnType("varchar(100)");
            b.Property(e => e.Street2).HasColumnType("varchar(50)");
            b.Property(e => e.City).HasColumnType("varchar(100)");
            b.Property(e => e.State).HasColumnType("varchar(10)");
            b.Property(e => e.Zip);
            b.Property(e => e.Phone);
            b.Property(e => e.Email).HasColumnType("varchar(60)");
            b.Property(e => e.IsActive).IsRequired();
            b.Property(e => e.CreatedAt);
            b.Property(e => e.UpdatedAt);
            b.Property(e => e.ModifiedBy);
        }
    }
}