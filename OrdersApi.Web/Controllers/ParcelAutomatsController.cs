using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrdersApi.Application.UseCases.ParcelAutomats;
using OrdersApi.Application.UseCases.ParcelAutomats.Create;
using OrdersApi.Application.UseCases.ParcelAutomats.GetInfo.GetActiveParcelAutomats;
using OrdersApi.Application.UseCases.ParcelAutomats.GetInfo.GetInfoAboutParcelAutomat;
using OrdersApi.Domain.Dipatchers;
using OrdersApi.Web.Models.Common;
using OrdersApi.Web.Models.ParcelAutomats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OrdersApi.Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ParcelAutomatsController : ControllerBase
    {
        private readonly ICommandDispatcher _commandDispatcher;
        private readonly IQueryDispatcher _queryDispatcher;

        public ParcelAutomatsController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher)
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
        }

        [HttpPost]
        public async Task<ApiResponse<CreateParcelAutomatOutputDto>> CreateParcelAutomat(ParcelAutomatCreateForm createParcelAutomat, CancellationToken cancellationToken)
        {
            var response = await _commandDispatcher
                .DispatchAsync(new CreateParcelAutomatInputDto(createParcelAutomat), cancellationToken)
                .ConfigureAwait(false);

            return ApiResponse<CreateParcelAutomatOutputDto>.Success(response);
        }

        [HttpGet("{parcelAutomatId}")]
        public async Task<ApiResponse<GetInfoAboutParcelAutomatOutputDto>> GetParcelAutomat(string parcelAutomatId, CancellationToken cancellationToken)
        {
            var response = await _queryDispatcher
                .DispatchAsync(new GetInfoAboutParcelAutomatInputDto(parcelAutomatId), cancellationToken)
                .ConfigureAwait(false);

            return ApiResponse<GetInfoAboutParcelAutomatOutputDto>.Success(response);
        }

        [HttpGet("active")]
        public async Task<ApiResponse<GetActiveParcelAutomatsOutputDto>> GetParcelAutomat(CancellationToken cancellationToken)
        {
            var response = await _queryDispatcher
                .DispatchAsync(new GetActiveParcelAutomatsInputDto(), cancellationToken)
                .ConfigureAwait(false);

            return ApiResponse<GetActiveParcelAutomatsOutputDto>.Success(response);
        }
    }
}
