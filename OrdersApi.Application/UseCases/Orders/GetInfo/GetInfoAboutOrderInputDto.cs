using OrdersApi.Domain.Usecases;

namespace OrdersApi.Application.UseCases.Orders.GetInfo
{
    public class GetInfoAboutOrderInputDto : IQuery<GetInfoAboutOrderOutputDto>
    {
        public int Id { get; }

        public GetInfoAboutOrderInputDto(int id)
        {
            Id = id;
        }
    }
}
