using OrdersApi.Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersApi.Web.Models.Orders
{
    public class UpdateOrderForm : IOrderUpdateForm
    {
        public IReadOnlyCollection<string> Products { get; set; }

        public decimal Price { get; set; }

        public string RecipientPhoneNumber { get; set; }

        public string RecipientFullName { get; set; }
    }
}
