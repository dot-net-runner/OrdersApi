using OrdersApi.Domain.Repositories;
using OrdersApi.Domain.Usecases.Handlers;
using System.Threading;
using System.Threading.Tasks;

namespace OrdersApi.Application.UseCases.ParcelAutomats.GetInfo.GetInfoAboutParcelAutomat
{
    public class GetInfoAboutParcelAutomatHandler : IQueryHandler<GetInfoAboutParcelAutomatInputDto, GetInfoAboutParcelAutomatOutputDto>
    {
        private readonly IParcelAutomatsRepository _parcelAutomatsRepository;
        private readonly ISaver _saver;

        public GetInfoAboutParcelAutomatHandler(IParcelAutomatsRepository parcelAutomatsRepository, ISaver saver)
        {
            _parcelAutomatsRepository = parcelAutomatsRepository;
            _saver = saver;
        }

        public async Task<GetInfoAboutParcelAutomatOutputDto> Handle(GetInfoAboutParcelAutomatInputDto request, CancellationToken cancellationToken)
        {
            var parcelAutomat = await _parcelAutomatsRepository.GetItem(request.Id, cancellationToken).ConfigureAwait(false);

            return new GetInfoAboutParcelAutomatOutputDto(parcelAutomat);
        }
    }
}
