using OrdersApi.Domain.Entities.ParcelAutomats;

namespace OrdersApi.Web.Models.ParcelAutomats
{
    public class ParcelAutomatCreateForm : IParcelAutomatCreateForm
    {
        public string Id { get; set; }

        public string Address { get; set; }

        public bool IsActive { get; set; }
    }
}
