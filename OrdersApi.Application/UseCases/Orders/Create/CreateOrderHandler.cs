using OrdersApi.Domain.Common;
using OrdersApi.Domain.Entities.Orders;
using OrdersApi.Domain.Entities.Orders.Validators;
using OrdersApi.Domain.Entities.ParcelAutomats;
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
        private readonly IOrderValidator _orderValidator;

        public CreateOrderHandler(IOrdersRepository ordersRepository,
            IParcelAutomatsRepository parcelAutomatsRepository,
            ISaver saver,
            IOrderValidator orderValidator)
        {
            _ordersRepository = ordersRepository;
            _parcelAutomatsRepository = parcelAutomatsRepository;
            _saver = saver;
            _orderValidator = orderValidator;
        }

        public async Task<CreateOrderOutputDto> Handle(CreateOrderInputDto request, CancellationToken cancellationToken)
        {
            var order = new Order(request.CreateOrderForm, _orderValidator);

            var parcelAutomat = await _parcelAutomatsRepository.GetItem(order.ParcelAutomatId, cancellationToken).ConfigureAwait(false);
            if (!parcelAutomat.IsActive)
            {
                throw new StatusException(nameof(ParcelAutomat), "Parcel automat is not active");
            }

            var addedOrder = await _ordersRepository.Add(order, cancellationToken).ConfigureAwait(false);

            await _saver.SaveChanges(cancellationToken).ConfigureAwait(false);

            return new CreateOrderOutputDto(addedOrder.Id);
        }
    }
}
