using OrdersApi.Domain.Common;
using OrdersApi.Domain.Entities.Orders;
using OrdersApi.Domain.Entities.Orders.Validators;
using OrdersApi.Domain.Entities.ParcelAutomats.Validators;
using OrdersApi.Domain.Entities.Validators;

namespace OrdersApi.Domain
{
    public static class DomainServiceConfiguration
    {
        public static void AddDomainServices(IServiceConfigurator serviceConfigurator)
        {
            serviceConfigurator
                .AddService(typeof(IAddressValidator), typeof(AddressValidator))
                .AddService(typeof(IParcelAutomatsIdValidator), typeof(ParcelAutomatsIdValidator))
                .AddService(typeof(IPhoneNumberValidator), typeof(PhoneNumberValidator))
                .AddService(typeof(IPriceValidator), typeof(PriceValidator))
                .AddService(typeof(IProductsValidator), typeof(ProductsValidator))
                .AddService(typeof(IOrderValidator), typeof(OrderValidator))
                .AddService(typeof(IParcelAutomatValidator), typeof(ParcelAutomatValidator));
        }
    }
}
