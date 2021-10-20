using Microsoft.EntityFrameworkCore;
using OrdersApi.Data.DataBase;
using OrdersApi.Domain.Entities.ParcelAutomats;
using OrdersApi.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OrdersApi.Data.Repositories.ParcelAutomats
{
    internal class ParcelAutomatsRepository : Repository<ParcelAutomat, string>, IParcelAutomatsRepository
    {
        public ParcelAutomatsRepository(OrdersDatabaseContext db) : base(db)
        {
        }

        public async Task<IReadOnlyCollection<ParcelAutomat>> GetCollection(ParcelAutomatFilter filter, CancellationToken token)
        {
            var parcelAutomats = (IQueryable<ParcelAutomat>)_entities;

            if (filter.IsActive.HasValue)
            {
                parcelAutomats = parcelAutomats.Where(x => x.IsActive == filter.IsActive);
            }

            return await parcelAutomats
                .OrderBy(x => x.Id)
                .ToArrayAsync(token)
                .ConfigureAwait(false);
        }

        public Task<bool> IsItemExist(string id, CancellationToken token)
        {
            return _entities.AnyAsync(x => x.Id == id, token);
        }
    }
}
