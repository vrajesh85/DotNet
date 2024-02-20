using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MyProject.Services
{
    public class TextResponseFormatter : IResponseFormatter
    {
        private int _counter = 0;

        public async Task Format(HttpContext context, string content)
        {
            await context.Response.WriteAsync($"count is {++_counter} and content is {content}");
        }
    }
}
