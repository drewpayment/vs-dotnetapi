using dotnetapi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dotnetapi.Database.Configuration
{
    internal partial class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> b)
        {
            b.HasKey(e => e.ClientId);
            b.ToTable("Clients");

            b.Property(e => e.ClientId).UseMySqlIdentityColumn();
            b.Property(e => e.Name).IsRequired().HasColumnType("varchar(100)");
            b.Property(e => e.Street).IsRequired().HasColumnType("varchar(100)");
            b.Property(e => e.City).IsRequired().HasColumnType("varchar(100)");
            b.Property(e => e.State).IsRequired().HasColumnType("varchar(10)");
            b.Property(e => e.Zip).IsRequired();
            b.Property(e => e.Phone).IsRequired();
            b.Property(e => e.TaxId);
            b.Property(e => e.Active).IsRequired();
            b.Property(e => e.ModifiedBy).IsRequired();
            b.Property(e => e.CreatedAt);
            b.Property(e => e.UpdatedAt);
            b.Property(e => e.DeletedAt);
        }
    }
}