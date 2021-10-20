namespace OrdersApi.Domain.Entities.Orders
{
    public enum OrderStatus
    {
        None = 0,

        Registered = 1,

        ReceivedAtWarehouse = 2,

        IssuedToCourier = 3,

        DeliveredToParcelAutomat = 4,

        DeliveredToRecipient = 5,

        Сanceled = 6
    }
}
