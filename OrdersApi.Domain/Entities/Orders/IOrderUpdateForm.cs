using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApi.Domain.Entities.Orders
{
    public interface IOrderUpdateForm
    {
        public IReadOnlyCollection<string> Products { get; }

        public decimal Price { get; }

        public string RecipientPhoneNumber { get; }

        public string RecipientFullName { get; }
    }
}
