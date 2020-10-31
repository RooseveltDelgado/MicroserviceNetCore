using Microsoft.EntityFrameworkCore;
using OrdersApi.Configuration;

namespace OrdersApi.models
{
    public class AppOrdersContext : DbContext
    {
        public AppOrdersContext(DbContextOptions<AppOrdersContext> options)
       : base(options)
        {
        }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("Orders");
            ModelConfig(modelBuilder);
        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new OrdersConfiguration(modelBuilder.Entity<Order>());
        }
    }
}