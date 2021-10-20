using System.Threading;
using System.Threading.Tasks;
using OrdersApi.Domain.Usecases;

namespace OrdersApi.Domain.Dipatchers
{
    public interface ICommandDispatcher
    {
        Task<TReponse> DispatchAsync<TReponse>(ICommand<TReponse> command, CancellationToken cancellationToken);
    }
}
