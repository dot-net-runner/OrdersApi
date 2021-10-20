using OrdersApi.Domain.Entities.Orders;
using OrdersApi.Domain.Usecases;

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
