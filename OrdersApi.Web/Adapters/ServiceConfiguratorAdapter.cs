using Microsoft.Extensions.DependencyInjection;
using System;
using OrdersApi.Domain.Common;

namespace OrdersApi.Web.Adapters
{
    public class ServiceConfiguratorAdapter : IServiceConfigurator
    {
        private readonly IServiceCollection _services;

        public ServiceConfiguratorAdapter(IServiceCollection services)
        {
            _services = services;
        }

        public IServiceConfigurator AddService(Type serviceType, Type implementationType)
        {
            _services.AddScoped(serviceType, implementationType);

            return this;
        }
    }
}
