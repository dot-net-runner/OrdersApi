using MediatR;

namespace OrdersApi.Domain.Usecases.Handlers
{
    public interface ICommandHandler<in TCommand, TResponse>
        : IRequestHandler<TCommand, TResponse>
        where TCommand : ICommand<TResponse>
    {
    }
}
