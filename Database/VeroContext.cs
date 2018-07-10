using System;
using dotnetapi.Database.Configuration;
using dotnetapi.Models;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;

namespace dotnetapi.Database
{
    public partial class VeroContext : DbContext
    {
        // public VeroContext()
        // {
        // }

        public VeroContext(DbContextOptions<VeroContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;port=8889;database=verostackcore;uid=root;password=root");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfiguration(new EfMigrationHistoryConfiguration())
                .ApplyConfiguration(new UserConfiguration())
                .ApplyConfiguration(new UserDetailConfiguration())
                .ApplyConfiguration(new AgentConfiguration())
                .ApplyConfiguration(new ClientConfiguration())
                .ApplyConfiguration(new CampaignConfiguration())
                .ApplyConfiguration(new RoleConfiguration());
        }

        // ENTITY LISTS
        public virtual DbSet<EfmigrationsHistory> EfmigrationsHistory { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserDetail> UserDetailList { get; set; }
        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Campaign> Campaigns { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
    }
}
