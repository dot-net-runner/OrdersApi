namespace OrdersApi.Domain.Entities.Validators
{
    public interface IPhoneNumberValidator
    {
        bool Validate(string phoneNumber);
    }
}
