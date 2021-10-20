using Microsoft.AspNetCore.Mvc;
using OrdersApi.Application.UseCases.Orders.Cancel;
using OrdersApi.Application.UseCases.Orders.Create;
using OrdersApi.Application.UseCases.Orders.GetInfo;
using OrdersApi.Application.UseCases.Orders.Update;
using OrdersApi.Domain.Dipatchers;
using OrdersApi.Web.Models.Common;
using OrdersApi.Web.Models.Orders;
using System.Threading;
using System.Threading.Tasks;

namespace OrdersApi.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly ICommandDispatcher _commandDispatcher;
        private readonly IQueryDispatcher _queryDispatcher;

        public OrdersController(ICommandDispatcher commandDispatcher,
            IQueryDispatcher queryDispatcher)
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
        }

        [HttpPost]
        public async Task<ApiResponse<CreateOrderOutputDto>> CreateOrder(CreateOrderForm createOrder, CancellationToken cancellationToken)
        {
            var response = await _commandDispatcher
                .DispatchAsync(new CreateOrderInputDto(createOrder), cancellationToken)
                .ConfigureAwait(false);

            return ApiResponse<CreateOrderOutputDto>.Success(response);
        }

        [HttpPut("{orderId}")]
        public async Task<ApiResponse<UpdateOrderOutputDto>> UpdateOrder(int orderId, UpdateOrderForm updateOrder, CancellationToken cancellationToken)
        {
            var response = await _commandDispatcher
                .DispatchAsync(new UpdateOrderInputDto(orderId, updateOrder), cancellationToken)
                .ConfigureAwait(false);

            return ApiResponse<UpdateOrderOutputDto>.Success(response);
        }

        [HttpGet("{orderId}")]
        public async Task<ApiResponse<GetInfoAboutOrderOutputDto>> GetOrder(int orderId, CancellationToken cancellationToken)
        {
            var response = await _queryDispatcher
                .DispatchAsync(new GetInfoAboutOrderInputDto(orderId), cancellationToken)
                .ConfigureAwait(false);

            return ApiResponse<GetInfoAboutOrderOutputDto>.Success(response);
        }


        [HttpDelete("{orderId}")]
        public async Task<ApiResponse<CancelOrderOutputDto>> CancelOrder(int orderId, CancellationToken cancellationToken)
        {
            var response = await _commandDispatcher
                .DispatchAsync(new CancelOrderInputDto(orderId), cancellationToken)
                .ConfigureAwait(false);

            return ApiResponse<CancelOrderOutputDto>.Success(response);
        }
    }
}
