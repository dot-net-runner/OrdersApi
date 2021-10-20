using OrdersApi.Domain.Usecases;

namespace OrdersApi.Application.UseCases.ParcelAutomats.GetInfo.GetInfoAboutParcelAutomat
{
    public class GetInfoAboutParcelAutomatInputDto : IQuery<GetInfoAboutParcelAutomatOutputDto>
    {
        public string Id { get; }

        public GetInfoAboutParcelAutomatInputDto(string id)
        {
            Id = id;
        }
    }
}
