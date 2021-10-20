using OrdersApi.Domain.Usecases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApi.Application.UseCases.Orders.Cancel
{
    public class CancelOrderInputDto: ICommand<CancelOrderOutputDto>
    {
        public int Id { get; }

        public CancelOrderInputDto(int id)
        {
            Id = id;
        }
    }
}
