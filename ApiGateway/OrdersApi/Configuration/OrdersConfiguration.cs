using System.Reflection;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OrdersApi.Configuration
{
    public class OrdersConfiguration
    {
        public OrdersConfiguration(EntityTypeBuilder<Order> entityBuilder)
        {
            entityBuilder.HasIndex(x => x.Id);
            entityBuilder.Property(x => x.Amount).IsRequired();
            entityBuilder.Property(x => x.Name).IsRequired().HasMaxLength(100);

            var orders = new List<Order>();

            for (var i = 1; i <= 100; i++)
            {
                orders.Add(new Order
                {
                    Id = i,
                    Amount = 844 * i,
                    Name = $"order{i}"
                });
            }
            entityBuilder.HasData(orders);
        }
    }
}