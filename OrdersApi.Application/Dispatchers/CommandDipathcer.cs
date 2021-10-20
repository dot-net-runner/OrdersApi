using MediatR;
using System.Threading;
using System.Threading.Tasks;
using OrdersApi.Domain.Dipatchers;
using OrdersApi.Domain.Usecases;

namespace OrdersApi.DataAccess.Dispatchers
{
    internal class CommandDipathcer : ICommandDispatcher
    {
        private readonly IMediator _mediator;

        public CommandDipathcer(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task<TReponse> DispatchAsync<TReponse>(ICommand<TReponse> command, CancellationToken cancellationToken)
        {
            return _mediator.Send(command, cancellationToken);
        }
    }
}
