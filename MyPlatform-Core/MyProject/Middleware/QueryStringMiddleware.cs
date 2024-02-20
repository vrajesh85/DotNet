using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MyProject.Middleware
{
    public class QueryStringMiddleware
    {
        private RequestDelegate _next;

        public QueryStringMiddleware(RequestDelegate next){
            _next = next;
        }

        public async Task Invoke(HttpContext context){
            if (context.Request.Method == "GET" && context.Request.Query["custom"].ToString().ToLower() == "true")
                await context.Response.WriteAsync("This is custom class middleware component \n");

            await _next(context);
        }
    }
}
