using OrdersApi.Data.DataBase;
using OrdersApi.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OrdersApi.Data.Repositories
{
    class Saver: ISaver
    {
        private readonly Func<CancellationToken, Task> _save;

        public Saver(OrdersDatabaseContext db)
        {
            _save = (CancellationToken token) => db.SaveChangesAsync(token);
        }

        public Task SaveChanges(CancellationToken token)
        {
            return _save(token);
        }
    }
}
