using System;

namespace OrdersApi.Domain.Common
{
    public class StatusException : Exception
    {
        public string EntityName { get; }

        public StatusException(string entityName, string message) : base(message)
        {
            EntityName = entityName;
        }
    }
}
