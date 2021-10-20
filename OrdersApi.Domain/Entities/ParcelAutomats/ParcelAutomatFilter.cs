using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApi.Domain.Entities.ParcelAutomats
{
    public class ParcelAutomatFilter
    {
        public bool? IsActive { get; private set; }

        public ParcelAutomatFilter SetIsActive(bool isActive)
        {
            IsActive = isActive;

            return this;
        }
    }
}
