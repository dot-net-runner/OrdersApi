using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrdersApi.Domain.Entities.ParcelAutomats;

namespace OrdersApi.Data.DataBase.Configurations
{
    static internal class ParcelAutomatsConfiguration
    {
        public static void Configure(EntityTypeBuilder<ParcelAutomat> builder)
        {
            builder.Property(x => x.Id).HasMaxLength(8);
        }
    }
}
