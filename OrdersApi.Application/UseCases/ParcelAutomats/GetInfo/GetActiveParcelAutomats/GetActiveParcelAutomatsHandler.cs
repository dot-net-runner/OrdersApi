using OrdersApi.Domain.Entities.ParcelAutomats;
using OrdersApi.Domain.Repositories;
using OrdersApi.Domain.Usecases.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OrdersApi.Application.UseCases.ParcelAutomats.GetInfo.GetActiveParcelAutomats
{
    public class GetActiveParcelAutomatsHandler : IQueryHandler<GetActiveParcelAutomatsInputDto, GetActiveParcelAutomatsOutputDto>
    {
        private readonly IParcelAutomatsRepository _parcelAutomatsRepository;
        private readonly ISaver _saver;

        public GetActiveParcelAutomatsHandler(IParcelAutomatsRepository parcelAutomatsRepository, ISaver saver)
        {
            _parcelAutomatsRepository = parcelAutomatsRepository;
            _saver = saver;
        }
        public async Task<GetActiveParcelAutomatsOutputDto> Handle(GetActiveParcelAutomatsInputDto request, CancellationToken cancellationToken)
        {
            var parcelAutomats = await _parcelAutomatsRepository
                .GetCollection(new ParcelAutomatFilter().SetIsActive(true), cancellationToken)
                .ConfigureAwait(false);

            return new GetActiveParcelAutomatsOutputDto(parcelAutomats
                .Select(x => new GetInfoAboutParcelAutomatOutputDto(x)));
        }
    }
}
