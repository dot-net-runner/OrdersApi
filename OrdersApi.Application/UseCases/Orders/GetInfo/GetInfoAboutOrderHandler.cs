using OrdersApi.Domain.Repositories;
using OrdersApi.Domain.Usecases.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OrdersApi.Application.UseCases.Orders.GetInfo
{
    internal class GetInfoAboutOrderHandler : IQueryHandler<GetInfoAboutOrderInputDto, GetInfoAboutOrderOutputDto>
    {
        private readonly IOrdersRepository _ordersRepository;

        public GetInfoAboutOrderHandler(IOrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }

        public async Task<GetInfoAboutOrderOutputDto> Handle(GetInfoAboutOrderInputDto request, CancellationToken cancellationToken)
        {
            var order = await _ordersRepository.GetItem(request.Id,cancellationToken).ConfigureAwait(false);

            return new GetInfoAboutOrderOutputDto(order);
        }
    }
}
