using OrdersApi.Domain.Entities.ParcelAutomats;
using OrdersApi.Domain.Usecases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApi.Application.UseCases.ParcelAutomats.Create
{
    public class CreateParcelAutomatInputDto: ICommand<CreateParcelAutomatOutputDto>
    {
        public IParcelAutomatCreateForm Form { get; }

        public CreateParcelAutomatInputDto(IParcelAutomatCreateForm form)
        {
            Form = form;
        }
    }
}
