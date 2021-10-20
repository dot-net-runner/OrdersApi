using OrdersApi.Domain.Repositories;
using OrdersApi.Domain.Usecases.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OrdersApi.Application.UseCases.Orders.Update
{
    internal class UpdateOrderHandler : ICommandHandler<UpdateOrderInputDto, UpdateOrderOutputDto>
    {
        private readonly IOrdersRepository _ordersRepository;
        private readonly ISaver _saver;

        public UpdateOrderHandler(IOrdersRepository ordersRepository, ISaver saver)
        {
            _ordersRepository = ordersRepository;
            _saver = saver;
        }

        public async Task<UpdateOrderOutputDto> Handle(UpdateOrderInputDto request, CancellationToken cancellationToken)
        {
            var order = await _ordersRepository.GetItem(request.Id, cancellationToken).ConfigureAwait(false);

            order.Update(request.Form);
            await _saver.SaveChanges(cancellationToken).ConfigureAwait(false);

            return new UpdateOrderOutputDto();
        }
    }
}
