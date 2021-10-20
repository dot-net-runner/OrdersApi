using System.Collections.Generic;
using System.Linq;

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
