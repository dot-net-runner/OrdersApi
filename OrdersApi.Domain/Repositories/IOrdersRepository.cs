using OrdersApi.Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApi.Domain.Repositories
{
    public interface IOrdersRepository: IRepository<Order, int>
    {
    }
}
