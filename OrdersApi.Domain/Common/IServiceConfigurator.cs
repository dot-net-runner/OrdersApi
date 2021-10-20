using System;

namespace OrdersApi.Domain.Common
{
    public interface IServiceConfigurator
    {
        IServiceConfigurator AddService(Type serviceType, Type implementationType);
    }
}
