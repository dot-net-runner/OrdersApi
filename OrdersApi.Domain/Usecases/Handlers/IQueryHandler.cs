using MediatR;

namespace OrdersApi.Domain.Usecases.Handlers
{
    public interface IQueryHandler<in TQuery, TResponse>
        : IRequestHandler<TQuery, TResponse>
        where TQuery : IQuery<TResponse>
    {
    }
}
