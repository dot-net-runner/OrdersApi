using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrdersApi.Domain.Entities.Common;
using OrdersApi.Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApi.Data.DataBase.Configurations
{
    static internal class OrderConfiguration
    {
        public static void Configure(EntityTypeBuilder<Order> builder) { 
        }
    }
}
