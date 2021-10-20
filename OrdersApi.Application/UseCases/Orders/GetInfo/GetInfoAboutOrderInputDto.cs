using OrdersApi.Domain.Repositories;
using OrdersApi.Domain.Usecases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApi.Application.UseCases.Orders.GetInfo
{
    public class GetInfoAboutOrderInputDto: IQuery<GetInfoAboutOrderOutputDto>
    {
        public int Id { get; }

        public GetInfoAboutOrderInputDto(int id)
        {
            Id = id;
        }
    }
}
