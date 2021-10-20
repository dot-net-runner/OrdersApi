namespace OrdersApi.Application.UseCases.Orders.Create
{
    public class CreateOrderOutputDto
    {
        public int Id { get; }

        public CreateOrderOutputDto(int id)
        {
            Id = id;
        }
    }
}
