using MediatR;

namespace OrdersApi.Domain.Usecases
{
    public interface ICommand<TResponse> : IRequest<TResponse>
    {
    }
}
