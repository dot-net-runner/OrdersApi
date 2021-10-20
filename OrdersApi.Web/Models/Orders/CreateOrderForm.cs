using OrdersApi.Domain.Entities.Orders;
using System.Collections.Generic;

namespace OrdersApi.Web.Models.Orders
{
    public class CreateOrderForm : ICreateOrderForm
    {
        public IReadOnlyCollection<string> Products { get; set; }

        public string ParcelAutomatId { get; set; }

        public decimal Price { get; set; }

        public string RecipientPhoneNumber { get; set; }

        public string RecipientFullName { get; set; }
    }
}
