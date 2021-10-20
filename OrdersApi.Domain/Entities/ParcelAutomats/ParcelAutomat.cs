using OrdersApi.Domain.Entities.Common;
using OrdersApi.Domain.Entities.Orders;
using OrdersApi.Domain.Entities.ParcelAutomats.Validators;
using System.Collections.Generic;

namespace OrdersApi.Domain.Entities.ParcelAutomats
{
    public class ParcelAutomat : IEntity<string>
    {
        public string Id { get; private set; }

        public string Address { get; private set; }

        public bool IsActive { get; private set; }

        public IReadOnlyCollection<Order> Orders { get; private set; }

        private ParcelAutomat()
        {
        }

        public ParcelAutomat(IParcelAutomatCreateForm form, IParcelAutomatValidator parcelAutomatValidator)
        {
            Id = form.Id;
            Address = form.Address;
            IsActive = form.IsActive;

            parcelAutomatValidator.Validate(this);
        }
    }
}
