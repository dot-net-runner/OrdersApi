namespace OrdersApi.Domain.Entities.Common
{
    public interface IEntity<TId>
    {
        TId Id { get; }
    }
}
