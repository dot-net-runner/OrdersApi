using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApi.Domain.Entities.Validators
{
    class AddressValidator : IAddressValidator
    {
        public bool Validate(string address)
        {
            return !string.IsNullOrWhiteSpace(address);
        }
    }
}
