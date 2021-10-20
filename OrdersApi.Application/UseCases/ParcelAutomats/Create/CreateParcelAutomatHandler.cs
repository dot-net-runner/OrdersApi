using OrdersApi.Domain.Entities.ParcelAutomats;
using OrdersApi.Domain.Repositories;
using OrdersApi.Domain.Usecases.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OrdersApi.Application.UseCases.ParcelAutomats.Create
{
    class CreateParcelAutomatHandler : ICommandHandler<CreateParcelAutomatInputDto, CreateParcelAutomatOutputDto>
    {
        private readonly IParcelAutomatsRepository _parcelAutomatsRepository;
        private readonly ISaver _saver;

        public CreateParcelAutomatHandler(IParcelAutomatsRepository parcelAutomatsRepository, ISaver saver)
        {
            _parcelAutomatsRepository = parcelAutomatsRepository;
            _saver = saver;
        }

        public async Task<CreateParcelAutomatOutputDto> Handle(CreateParcelAutomatInputDto request, CancellationToken cancellationToken)
        {
            var parcelAutomat = new ParcelAutomat(request.Form);
            await _parcelAutomatsRepository.Add(parcelAutomat, cancellationToken).ConfigureAwait(false);
            await _saver.SaveChanges(cancellationToken).ConfigureAwait(false);

            return new CreateParcelAutomatOutputDto();
        }
    }
}
