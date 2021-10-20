using MediatR;

namespace OrdersApi.Domain.Usecases
{
    public interface IQuery<TResponse> : IRequest<TResponse>
    {
    }
}
