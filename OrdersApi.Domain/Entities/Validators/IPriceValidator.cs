namespace OrdersApi.Domain.Entities.Validators
{
    public interface IPriceValidator
    {
        bool Validate(decimal price);
    }
}
