using MediatR;
using System.Threading;
using System.Threading.Tasks;
using OrdersApi.Domain.Dipatchers;
using OrdersApi.Domain.Usecases;

namespace OrdersApi.Application.Dispatchers
{
    internal class QueryDispatcher : IQueryDispatcher
    {
        private readonly IMediator _mediator;

        public QueryDispatcher(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task<TReponse> DispatchAsync<TReponse>(IQuery<TReponse> query, CancellationToken cancellationToken)
        {
            return _mediator.Send(query, cancellationToken);
        }
    }
}
