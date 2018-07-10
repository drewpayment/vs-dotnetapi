
using dotnetapi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dotnetapi.Database.Configuration
{
    internal partial class AgentConfiguration : IEntityTypeConfiguration<Agent>
    {
        public void Configure(EntityTypeBuilder<Agent> builder)
        {
            builder.HasKey(e => e.AgentId);
            builder.ToTable("Agents");

            builder.Property(e => e.AgentId).UseMySqlIdentityColumn();
            builder.Property(e => e.UserId).IsRequired();
            builder.Property(e => e.ManagerId);
            builder.Property(e => e.IsManager);
            builder.Property(e => e.IsActive);
            builder.Property(e => e.CreatedAt);
            builder.Property(e => e.UpdatedAt);

            // RELATIONSHIPS
            builder.HasOne(u => u.User).WithOne(a => a.Agent);
        }
    }
}