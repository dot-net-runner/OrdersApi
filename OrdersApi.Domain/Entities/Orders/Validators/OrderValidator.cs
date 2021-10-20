using OrdersApi.Domain.Common;
using OrdersApi.Domain.Entities.Orders.Validators;
using OrdersApi.Domain.Entities.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApi.Domain.Entities.Orders
{
    public class OrderValidator : IOrderValidator
    {
        private readonly IPhoneNumberValidator _phoneNumberValidator;
        private readonly IAddressValidator _addressValidator;
        private readonly IPriceValidator _priceValidator;
        private readonly IProductsValidator _productsValidator;
        private readonly IParcelAutomatsIdValidator _parcelAutomatsIdValidator;

        public OrderValidator(IPhoneNumberValidator phoneNumberValidator,
            IAddressValidator addressValidator,
            IPriceValidator priceValidator, 
            IProductsValidator productsValidator, 
            IParcelAutomatsIdValidator parcelAutomatsIdValidator)
        {
            _phoneNumberValidator = phoneNumberValidator;
            _addressValidator = addressValidator;
            _priceValidator = priceValidator;
            _productsValidator = productsValidator;
            _parcelAutomatsIdValidator = parcelAutomatsIdValidator;
        }

        public void Validate(Order order)
        {
            if (!_priceValidator.Validate(order.Price))
            {
                throw new DomainValidateException(nameof(order.Price), "Invalid price");
            }

            if (!_productsValidator.Validate(order.Products))
            {
                throw new DomainValidateException(nameof(order.Products), "Invalid products");
            }

            if (!_phoneNumberValidator.Validate(order.RecipientPhoneNumber))
            {
                throw new DomainValidateException(nameof(order.RecipientPhoneNumber), "Invalid recipient phone number");
            }

            if (!_parcelAutomatsIdValidator.Validate(order.ParcelAutomatId))
            {
                throw new DomainValidateException(nameof(order.ParcelAutomatId), "Invalid parcel automat Id");
            }
        }
    }
}
