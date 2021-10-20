using OrdersApi.Domain.Repositories;
using OrdersApi.Domain.Usecases.Handlers;
using System.Threading;
using System.Threading.Tasks;

namespace OrdersApi.Application.UseCases.Orders.Create
{
    internal class CreateOrderHandler : ICommandHandler<CreateOrderInputDto, CreateOrderOutputDto>
    {
        private readonly IOrdersRepository _ordersRepository;
        private readonly IParcelAutomatsRepository _parcelAutomatsRepository;
        private readonly ISaver _saver;

        public CreateOrderHandler(IOrdersRepository ordersRepository,
            IParcelAutomatsRepository parcelAutomatsRepository, 
            ISaver saver)
        {
            _ordersRepository = ordersRepository;
            _parcelAutomatsRepository = parcelAutomatsRepository;
            _saver = saver;
        }

        public async Task<CreateOrderOutputDto> Handle(CreateOrderInputDto request, CancellationToken cancellationToken)
        {
            var order = await _ordersRepository.Add(new Domain.Entities.Orders.Order(request.CreateOrderForm), cancellationToken).ConfigureAwait(false);

            await _saver.SaveChanges(cancellationToken).ConfigureAwait(false);

            return new CreateOrderOutputDto(order.Id);
        }
    }
}
