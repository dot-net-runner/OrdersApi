using OrdersApi.Domain.Usecases;

namespace OrdersApi.Application.UseCases.Orders.Cancel
{
    public class CancelOrderInputDto : ICommand<CancelOrderOutputDto>
    {
        public int Id { get; }

        public CancelOrderInputDto(int id)
        {
            Id = id;
        }
    }
}
