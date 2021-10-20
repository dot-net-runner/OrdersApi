using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApi.Application.UseCases.Orders.Create
{
    public class CreateOrderOutputDto
    {
        public int Id { get; }

        public CreateOrderOutputDto(int id)
        {
            Id = id;
        }
    }
}
