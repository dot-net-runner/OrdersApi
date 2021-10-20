using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Routing;
using OrdersApi.Data.Common;
using OrdersApi.Domain.Common;
using OrdersApi.Web.Models.Common;
using System;
using System.Threading.Tasks;

namespace OrdersApi.Web.Services
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IActionResultExecutor<ObjectResult> _executor;

        public ExceptionHandlerMiddleware(RequestDelegate next, IActionResultExecutor<ObjectResult> executor)
        {
            _next = next;
            _executor = executor;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (DomainValidateException ex)
            {
                var response = new ApiResponse<object>(400, ex.ParamName, ex.Message);

                await ExecuteResult(response, context).ConfigureAwait(false);
            }
            catch (EntityNotFoundException ex)
            {
                var response = new ApiResponse<object>(404, "Not found", ex.Message);

                await ExecuteResult(response, context).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                var response = new ApiResponse<object>(500, "Internal server error", ex.Message);

                await ExecuteResult(response, context).ConfigureAwait(false);
            }
        }

        private async Task ExecuteResult<T>(ApiResponse<T> response, HttpContext context)
        {
            var routeData = context.GetRouteData() ?? new RouteData();

            var actionContext = new ActionContext(context, routeData, new ActionDescriptor());

            var result = new ObjectResult(response);

            await _executor.ExecuteAsync(actionContext, result);
        }
    }
}
