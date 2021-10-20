using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApi.Domain.Entities.Orders.Validators
{
    public interface IOrderValidator
    {
        void Validate(Order order);
    }
}
