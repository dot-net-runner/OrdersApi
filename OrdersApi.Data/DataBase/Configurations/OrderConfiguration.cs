using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrdersApi.Domain.Entities.Orders;

namespace OrdersApi.Data.DataBase.Configurations
{
    static internal class OrderConfiguration
    {
        public static void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(x => x.ParcelAutomatId).HasMaxLength(8);
            builder.Property(x => x.RecipientPhoneNumber).HasMaxLength(15);
        }
    }
}
