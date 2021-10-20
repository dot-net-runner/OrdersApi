using OrdersApi.Domain.Entities.Common;
using System.Threading;
using System.Threading.Tasks;

namespace OrdersApi.Domain.Repositories
{
    public interface IRepository<TEntity, TId> where TEntity : class, IEntity<TId>
    {
        Task<TEntity> GetItem(TId id, CancellationToken cancellationToken);

        Task<TEntity> Add(TEntity entity, CancellationToken cancellationToken);
    }
}
