using System.Text.RegularExpressions;

namespace OrdersApi.Domain.Entities.Validators
{
    class ParcelAutomatsIdValidator : IParcelAutomatsIdValidator
    {
        private readonly Regex _regex = new(@"\d{4}-\d{3}");

        public bool Validate(string parcelAutomatsId)
        {
            return _regex.IsMatch(parcelAutomatsId);
        }
    }
}
