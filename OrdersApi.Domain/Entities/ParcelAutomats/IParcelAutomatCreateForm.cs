using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApi.Domain.Entities.ParcelAutomats
{
    public interface IParcelAutomatCreateForm
    {
        public string Id { get; }

        public string Address { get; }

        public bool IsActive { get; }
    }
}
