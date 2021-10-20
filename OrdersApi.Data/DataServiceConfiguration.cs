using OrdersApi.Data.Repositories;
using OrdersApi.Data.Repositories.Orders;
using OrdersApi.Data.Repositories.ParcelAutomats;
using OrdersApi.Domain.Common;
using OrdersApi.Domain.Repositories;

namespace OrdersApi.Application.Common
{
    public static class DataServiceConfiguration
    {
        public static void AddDataServices(IServiceConfigurator serviceConfigurator)
        {
            serviceConfigurator
                .AddService(typeof(IOrdersRepository), typeof(OrdersRepository))
                .AddService(typeof(IParcelAutomatsRepository), typeof(ParcelAutomatsRepository))
                .AddService(typeof(ISaver), typeof(Saver));
        }
    }
}
