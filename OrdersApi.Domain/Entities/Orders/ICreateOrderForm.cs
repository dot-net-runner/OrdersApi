namespace OrdersApi.Domain.Entities.Orders
{
    public interface ICreateOrderForm : IOrderUpdateForm
    {
        public string ParcelAutomatId { get; }
    }
}
