namespace OrdersApi.Domain.Entities.ParcelAutomats
{
    public interface IParcelAutomatCreateForm
    {
        public string Id { get; }

        public string Address { get; }

        public bool IsActive { get; }
    }
}
