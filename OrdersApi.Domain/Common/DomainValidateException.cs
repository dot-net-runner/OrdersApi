using System;

namespace OrdersApi.Domain.Common
{
    public class DomainValidateException : ArgumentException
    {
        public DomainValidateException(string propertyName, string message) : base(message, propertyName)
        {
        }
    }
}
