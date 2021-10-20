using OrdersApi.Domain.Entities.Orders;
using OrdersApi.Domain.Usecases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApi.Application.UseCases.Orders.Create
{
    public class CreateOrderInputDto : ICommand<CreateOrderOutputDto>
    {
        public ICreateOrderForm CreateOrderForm { get; }

        public CreateOrderInputDto(ICreateOrderForm createOrderForm)
        {
            CreateOrderForm = createOrderForm;
        }
    }
}
