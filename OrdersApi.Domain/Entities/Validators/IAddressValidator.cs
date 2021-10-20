namespace OrdersApi.Domain.Entities.Validators
{
    public interface IAddressValidator
    {
        bool Validate(string address);
    }
}
