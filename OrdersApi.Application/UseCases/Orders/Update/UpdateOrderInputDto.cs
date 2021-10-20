using OrdersApi.Domain.Entities.Orders;
using OrdersApi.Domain.Usecases;

namespace OrdersApi.Application.UseCases.Orders.Update
{
    public class UpdateOrderInputDto : ICommand<UpdateOrderOutputDto>
    {
        public int Id { get; }

        public IOrderUpdateForm Form { get; }

        public UpdateOrderInputDto(int id, IOrderUpdateForm form)
        {
            Id = id;
            Form = form;
        }
    }
}
