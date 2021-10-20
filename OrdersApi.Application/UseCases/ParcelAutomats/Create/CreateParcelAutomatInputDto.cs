using OrdersApi.Domain.Entities.ParcelAutomats;
using OrdersApi.Domain.Usecases;

namespace OrdersApi.Application.UseCases.ParcelAutomats.Create
{
    public class CreateParcelAutomatInputDto : ICommand<CreateParcelAutomatOutputDto>
    {
        public IParcelAutomatCreateForm Form { get; }

        public CreateParcelAutomatInputDto(IParcelAutomatCreateForm form)
        {
            Form = form;
        }
    }
}
