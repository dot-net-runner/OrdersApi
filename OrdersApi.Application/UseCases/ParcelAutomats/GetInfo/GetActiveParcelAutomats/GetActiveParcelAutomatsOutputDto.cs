using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApi.Application.UseCases.ParcelAutomats.GetInfo.GetActiveParcelAutomats
{
    public class GetActiveParcelAutomatsOutputDto
    {
        public IReadOnlyCollection<GetInfoAboutParcelAutomatOutputDto> ActiveParcelAutomats { get; }

        public GetActiveParcelAutomatsOutputDto(IEnumerable<GetInfoAboutParcelAutomatOutputDto> activeParcelAutomats)
        {
            ActiveParcelAutomats = activeParcelAutomats.ToArray();
        }
    }
}
