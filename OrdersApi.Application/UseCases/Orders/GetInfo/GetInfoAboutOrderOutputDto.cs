using OrdersApi.Domain.Entities.Orders;
using System.Collections.Generic;

namespace OrdersApi.Application.UseCases.Orders.GetInfo
{
    public class GetInfoAboutOrderOutputDto
    {
        public int Id { get; }

        public OrderStatus Status { get; }

        public IReadOnlyCollection<string> Products { get; }

        public decimal Price { get; }

        public string RecipientPhoneNumber { get; }

        public string RecipientFullName { get; }

        public string ParcelAutomatId { get; }

        public GetInfoAboutOrderOutputDto(Order order)
        {
            Id = order.Id;
            Status = order.Status;
            Products = order.Products;
            Price = order.Price;
            RecipientPhoneNumber = order.RecipientPhoneNumber;
            RecipientFullName = order.RecipientFullName;
            ParcelAutomatId = order.ParcelAutomatId;
        }
    }
}
