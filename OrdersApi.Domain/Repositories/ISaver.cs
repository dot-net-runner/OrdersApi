using System.Threading;
using System.Threading.Tasks;

namespace OrdersApi.Domain.Repositories
{
    public interface ISaver
    {
        Task SaveChanges(CancellationToken token);
    }
}
