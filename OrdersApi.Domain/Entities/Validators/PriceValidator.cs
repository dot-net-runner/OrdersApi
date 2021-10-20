using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApi.Domain.Entities.Validators
{
    class PriceValidator : IPriceValidator
    {
        public bool Validate(decimal price)
        {
            return price >= 0;
        }
    }
}
