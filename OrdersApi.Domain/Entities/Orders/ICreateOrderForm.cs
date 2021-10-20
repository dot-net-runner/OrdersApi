using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApi.Domain.Entities.Orders
{
    public interface ICreateOrderForm : IOrderUpdateForm
    {
        public string ParcelAutomatId { get; }
    }
}
