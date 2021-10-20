using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OrdersApi.Domain.Entities.Validators
{
    class PhoneNumberValidator : IPhoneNumberValidator
    {
        private readonly Regex _regex = new(@"\+7\d{3}-\d{3}-\d{2}-\d{2}");

        public bool Validate(string phoneNumber)
        {
            return _regex.IsMatch(phoneNumber);
        }
    }
}
