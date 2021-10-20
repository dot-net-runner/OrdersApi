using OrdersApi.Domain.Common;
using OrdersApi.Domain.Entities.Validators;

namespace OrdersApi.Domain.Entities.ParcelAutomats.Validators
{
    internal class ParcelAutomatValidator : IParcelAutomatValidator
    {
        private readonly IParcelAutomatsIdValidator _parcelAutomatsIdValidator;
        private readonly IAddressValidator _addressValidator;

        public ParcelAutomatValidator(IParcelAutomatsIdValidator parcelAutomatsIdValidator,
            IAddressValidator addressValidator)
        {
            _parcelAutomatsIdValidator = parcelAutomatsIdValidator;
            _addressValidator = addressValidator;
        }

        public void Validate(ParcelAutomat parcelAutomat)
        {
            if (!_parcelAutomatsIdValidator.Validate(parcelAutomat.Id))
            {
                throw new DomainValidateException(nameof(ParcelAutomat.Id), "Invalid parcel automat Id");
            }

            if (!_addressValidator.Validate(parcelAutomat.Address))
            {
                throw new DomainValidateException(nameof(ParcelAutomat.Address), "Invalid address");
            }
        }
    }
}
