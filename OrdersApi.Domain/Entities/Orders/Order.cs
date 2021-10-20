using OrdersApi.Domain.Entities.Common;
using OrdersApi.Domain.Entities.Orders.Validators;
using OrdersApi.Domain.Entities.ParcelAutomats;
using System.Linq;

namespace OrdersApi.Domain.Entities.Orders
{
    public class Order : IEntity<int>
    {
        public int Id { get; private set; }

        public OrderStatus Status { get; private set; }

        public string[] Products { get; private set; }

        public decimal Price { get; private set; }

        public string RecipientPhoneNumber { get; private set; }

        public string RecipientFullName { get; private set; }


        public string ParcelAutomatId { get; private set; }

        public ParcelAutomat ParcelAutomat { get; private set; }

        private Order()
        {
        }

        public Order(ICreateOrderForm form, IOrderValidator orderValidator)
        {
            Status = OrderStatus.Registered;
            ParcelAutomatId = form.ParcelAutomatId;

            this.Update(form);

            orderValidator.Validate(this);
        }

        public void Cancel()
        {
            Status = OrderStatus.Сanceled;
        }

        public void Update(IOrderUpdateForm form, IOrderValidator orderValidator)
        {
            this.Update(form);

            orderValidator.Validate(this);
        }

        private void Update(IOrderUpdateForm form)
        {
            Products = form.Products.ToArray();
            Price = form.Price;
            RecipientPhoneNumber = form.RecipientPhoneNumber;
            RecipientFullName = form.RecipientFullName;
        }
    }
}
