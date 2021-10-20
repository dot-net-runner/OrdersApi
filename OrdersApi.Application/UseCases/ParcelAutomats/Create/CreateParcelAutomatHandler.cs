using OrdersApi.Domain.Common;
using OrdersApi.Domain.Entities.ParcelAutomats;
using OrdersApi.Domain.Entities.ParcelAutomats.Validators;
using OrdersApi.Domain.Repositories;
using OrdersApi.Domain.Usecases.Handlers;
using System.Threading;
using System.Threading.Tasks;

namespace OrdersApi.Application.UseCases.ParcelAutomats.Create
{
    internal class CreateParcelAutomatHandler : ICommandHandler<CreateParcelAutomatInputDto, CreateParcelAutomatOutputDto>
    {
        private readonly IParcelAutomatsRepository _parcelAutomatsRepository;
        private readonly ISaver _saver;
        private readonly IParcelAutomatValidator _parcelAutomatValidator;

        public CreateParcelAutomatHandler(IParcelAutomatsRepository parcelAutomatsRepository,
            ISaver saver,
            IParcelAutomatValidator parcelAutomatValidator)
        {
            _parcelAutomatsRepository = parcelAutomatsRepository;
            _saver = saver;
            _parcelAutomatValidator = parcelAutomatValidator;
        }

        public async Task<CreateParcelAutomatOutputDto> Handle(CreateParcelAutomatInputDto request, CancellationToken cancellationToken)
        {
            var parcelAutomat = new ParcelAutomat(request.Form, _parcelAutomatValidator);

            var isParcelAutomatExist = await _parcelAutomatsRepository.IsItemExist(parcelAutomat.Id, cancellationToken).ConfigureAwait(false);
            if (isParcelAutomatExist)
            {
                throw new StatusException(nameof(ParcelAutomat), "Parcel automat is already exist");
            }

            await _parcelAutomatsRepository.Add(parcelAutomat, cancellationToken).ConfigureAwait(false);
            await _saver.SaveChanges(cancellationToken).ConfigureAwait(false);

            return new CreateParcelAutomatOutputDto();
        }
    }
}
