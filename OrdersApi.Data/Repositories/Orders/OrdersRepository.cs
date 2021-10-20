using OrdersApi.Data.DataBase;
using OrdersApi.Domain.Entities.Orders;
using OrdersApi.Domain.Repositories;

namespace OrdersApi.Data.Repositories.Orders
{
    internal class OrdersRepository : Repository<Order, int>, IOrdersRepository
    {
        public OrdersRepository(OrdersDatabaseContext db) : base(db)
        {
        }
    }
}
