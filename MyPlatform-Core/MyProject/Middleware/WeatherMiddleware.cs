using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MyProject.Services;
using System.Threading.Tasks;

namespace MyProject.Middleware
{
    public class WeatherMiddleware
    {
        private RequestDelegate next;

        public WeatherMiddleware(RequestDelegate requestDelegate)
        {
            next = requestDelegate;
        }

        public async Task Invoke (HttpContext context)
        {
            if (context.Request.Path == "/middleware/class")
            {
                context.RequestServices.GetRequiredService<IResponseFormatter>();
                await context.Response.WriteAsync("Middleware class : It is raining in london");
            }
            else 
            await next(context);
        }
    }
}
