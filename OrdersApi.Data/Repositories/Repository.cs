using Microsoft.EntityFrameworkCore;
using OrdersApi.Data.Common;
using OrdersApi.Data.DataBase;
using OrdersApi.Domain.Entities.Common;
using OrdersApi.Domain.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace OrdersApi.Data.Repositories
{
    internal abstract class Repository<TEntity, TId> : IRepository<TEntity, TId> where TEntity : class, IEntity<TId>
    {
        protected readonly DbSet<TEntity> _entities;

        public Repository(OrdersDatabaseContext db)
        {
            _entities = db.Set<TEntity>();
        }

        public virtual async Task<TEntity> Add(TEntity entity, CancellationToken cancellationToken)
        {
            var entry = await _entities.AddAsync(entity, cancellationToken).ConfigureAwait(false);

            return entry.Entity;
        }

        public async Task<TEntity> GetItem(TId id, CancellationToken cancellationToken)
        {
            return await _entities.FirstOrDefaultAsync(x => x.Id.Equals(id), cancellationToken)
                ?? throw new EntityNotFoundException($"Не удалось найти сущность c номером {id.ToString()}");
        }
    }
}
