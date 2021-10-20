using OrdersApi.Domain.Entities.Orders.Validators;
using OrdersApi.Domain.Repositories;
using OrdersApi.Domain.Usecases.Handlers;
using System.Threading;
using System.Threading.Tasks;

namespace OrdersApi.Application.UseCases.Orders.Update
{
    internal class UpdateOrderHandler : ICommandHandler<UpdateOrderInputDto, UpdateOrderOutputDto>
    {
        private readonly IOrdersRepository _ordersRepository;
        private readonly ISaver _saver;
        private readonly IOrderValidator _orderValidator;

        public UpdateOrderHandler(IOrdersRepository ordersRepository,
            ISaver saver, 
            IOrderValidator orderValidator)
        {
            _ordersRepository = ordersRepository;
            _saver = saver;
            _orderValidator = orderValidator;
        }

        public async Task<UpdateOrderOutputDto> Handle(UpdateOrderInputDto request, CancellationToken cancellationToken)
        {
            var order = await _ordersRepository.GetItem(request.Id, cancellationToken).ConfigureAwait(false);

            order.Update(request.Form, _orderValidator);
            await _saver.SaveChanges(cancellationToken).ConfigureAwait(false);

            return new UpdateOrderOutputDto();
        }
    }
}
