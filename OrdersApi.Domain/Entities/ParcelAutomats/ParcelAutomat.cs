using OrdersApi.Domain.Entities.Common;
using OrdersApi.Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public ParcelAutomat(IParcelAutomatCreateForm form)
        {
            Id = form.Id;
            Address = form.Address;
            IsActive = form.IsActive;
        }
    }
}
