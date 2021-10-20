using OrdersApi.Domain.Entities.Orders;

namespace OrdersApi.Domain.Repositories
{
    public interface IOrdersRepository : IRepository<Order, int>
    {
    }
}
