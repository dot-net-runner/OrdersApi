using OrdersApi.Domain.Entities.ParcelAutomats;

namespace OrdersApi.Application.UseCases.ParcelAutomats
{
    public class GetInfoAboutParcelAutomatOutputDto
    {
        public string Id { get; }

        public string Address { get; }

        public bool IsActive { get; }

        public GetInfoAboutParcelAutomatOutputDto(ParcelAutomat parcelAutomat)
        {
            Id = parcelAutomat.Id;
            Address = parcelAutomat.Address;
            IsActive = parcelAutomat.IsActive;
        }
    }
}
