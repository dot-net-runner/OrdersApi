using System.Threading;
using System.Threading.Tasks;
using OrdersApi.Domain.Usecases;

namespace OrdersApi.Domain.Dipatchers
{
    public interface IQueryDispatcher
    {
        Task<TReponse> DispatchAsync<TReponse>(IQuery<TReponse> query, CancellationToken cancellationToken);
    }
}
