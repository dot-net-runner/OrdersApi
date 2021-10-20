using OrdersApi.Domain.Entities.ParcelAutomats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
