using System;
using ClientApi.configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ClientApi.Models
{
    public partial class appClientContext : DbContext
    {

        public appClientContext(DbContextOptions<appClientContext> options)
            : base(options)
        {
        }
        public DbSet<Client> Client { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("Customer");
            ModelConfig(modelBuilder);
        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new ClientConfiguration(modelBuilder.Entity<Client>());
        }

    }
}