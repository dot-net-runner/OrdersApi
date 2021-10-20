using System.Collections.Generic;

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
