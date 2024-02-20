using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using MyProject.Services;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace MyProject.Middleware
{
    public class WeatherEndpoint
    {
        //public static async Task EndPoint(HttpContext context, IEndpointRouteBuilder app)
        //{
        //    ActivatorUtilities.CreateInstance<IResponseFormatter>(app.ServiceProvider);
        //    await context.Response.WriteAsync("Endpoint Class: It is cloudy in Milan");
        //}

        public static async Task EndPoint(HttpContext context)
        {
            await context.Response.WriteAsync("End point class : It is cloudy in Milan");
        }
    }
}
