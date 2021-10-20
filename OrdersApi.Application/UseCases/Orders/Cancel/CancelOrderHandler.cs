using OrdersApi.Domain.Repositories;
using OrdersApi.Domain.Usecases.Handlers;
using System.Threading;
using System.Threading.Tasks;

namespace OrdersApi.Application.UseCases.Orders.Cancel
{
    internal class CancelOrderHandler : ICommandHandler<CancelOrderInputDto, CancelOrderOutputDto>
    {
        private readonly IOrdersRepository _ordersRepository;
        private readonly ISaver _saver;

        public CancelOrderHandler(IOrdersRepository ordersRepository, ISaver saver)
        {
            _ordersRepository = ordersRepository;
            _saver = saver;
        }

        public async Task<CancelOrderOutputDto> Handle(CancelOrderInputDto request, CancellationToken cancellationToken)
        {
            var order = await _ordersRepository.GetItem(request.Id, cancellationToken).ConfigureAwait(false);

            order.Cancel();
            await _saver.SaveChanges(cancellationToken).ConfigureAwait(false);

            return new CancelOrderOutputDto();
        }
    }
}
