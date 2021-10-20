using Microsoft.Extensions.DependencyInjection;
using OrdersApi.Application;
using OrdersApi.Application.Common;
using OrdersApi.Domain;
using OrdersApi.Web.Adapters;

namespace OrdersApi.Web.Services
{
    public static class ServiceConfiguration
    {
        public static void AddOrdersApiServices(this IServiceCollection services)
        {
            var serviceConfiguratorAdapter = new ServiceConfiguratorAdapter(services);

            ApplicationServiceConfiguration.AddApplicationServices(serviceConfiguratorAdapter);
            DataServiceConfiguration.AddDataServices(serviceConfiguratorAdapter);
            DomainServiceConfiguration.AddDomainServices(serviceConfiguratorAdapter);
        }
    }
}
