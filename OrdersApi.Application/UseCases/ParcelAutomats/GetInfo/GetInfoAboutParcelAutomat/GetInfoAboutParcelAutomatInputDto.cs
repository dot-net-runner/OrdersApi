using OrdersApi.Domain.Usecases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApi.Application.UseCases.ParcelAutomats.GetInfo.GetInfoAboutParcelAutomat
{
    public class GetInfoAboutParcelAutomatInputDto: IQuery<GetInfoAboutParcelAutomatOutputDto>
    {
        public string Id { get; }

        public GetInfoAboutParcelAutomatInputDto(string id)
        {
            Id = id;
        }
    }
}
