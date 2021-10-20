using OrdersApi.Domain.Entities.ParcelAutomats;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OrdersApi.Domain.Repositories
{
    public interface IParcelAutomatsRepository : IRepository<ParcelAutomat, string>
    {
        Task<bool> IsItemExist(string id, CancellationToken token);

        Task<IReadOnlyCollection<ParcelAutomat>> GetCollection(ParcelAutomatFilter filter, CancellationToken token);
    }
}
