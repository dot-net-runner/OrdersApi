namespace OrdersApi.Domain.Entities.Validators
{
    public interface IParcelAutomatsIdValidator
    {
        bool Validate(string parcelAutomatsId);
    }
}
