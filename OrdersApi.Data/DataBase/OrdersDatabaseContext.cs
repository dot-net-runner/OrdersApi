using Microsoft.EntityFrameworkCore;
using OrdersApi.Data.DataBase.Configurations;
using OrdersApi.Domain.Entities.Orders;
using OrdersApi.Domain.Entities.ParcelAutomats;

namespace OrdersApi.Data.DataBase
{
    public class OrdersDatabaseContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<ParcelAutomat> ParcelAutomats { get; set; }

        public OrdersDatabaseContext(DbContextOptions<OrdersDatabaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OrderConfiguration.Configure(modelBuilder.Entity<Order>());
            ParcelAutomatsConfiguration.Configure(modelBuilder.Entity<ParcelAutomat>());
        }
    }
}
