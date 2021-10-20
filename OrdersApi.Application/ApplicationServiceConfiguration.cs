using OrdersApi.Application.Dispatchers;
using OrdersApi.DataAccess.Dispatchers;
using OrdersApi.Domain.Common;
using OrdersApi.Domain.Dipatchers;

namespace OrdersApi.Application
{
    public static class ApplicationServiceConfiguration
    {
        public static void AddApplicationServices(IServiceConfigurator serviceConfigurator)
        {
            serviceConfigurator
                .AddService(typeof(ICommandDispatcher), typeof(CommandDipathcer))
                .AddService(typeof(IQueryDispatcher), typeof(QueryDispatcher));
        }
    }
}
