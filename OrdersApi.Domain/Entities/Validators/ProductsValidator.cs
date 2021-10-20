using System.Collections.Generic;
using System.Linq;

namespace OrdersApi.Domain.Entities.Validators
{
    internal class ProductsValidator : IProductsValidator
    {
        private const int MAX_PRODUCTS_COUNT = 10;

        public bool Validate(IEnumerable<string> products)
        {
            return !products.Any(x => string.IsNullOrWhiteSpace(x))
                && products.Count() <= MAX_PRODUCTS_COUNT;
        }
    }
}
