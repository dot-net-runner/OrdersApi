using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApi.Domain.Entities.Validators
{
    public interface IProductsValidator
    {
        bool Validate(IEnumerable<string> products);
    }
}
