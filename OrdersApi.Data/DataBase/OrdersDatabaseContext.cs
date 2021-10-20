using Microsoft.EntityFrameworkCore;
using OrdersApi.Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApi.Data.DataBase
{
    public class OrdersDatabaseContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public OrdersDatabaseContext(DbContextOptions<OrdersDatabaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
