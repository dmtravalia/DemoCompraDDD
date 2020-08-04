using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace DemoCompra.Service.Api.Filters
{
    public class BadRequestFilter : IAsyncResultFilter
    {
        public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            if (!context.ModelState.IsValid)
            {

            }

            await next();
        }
    }
}
