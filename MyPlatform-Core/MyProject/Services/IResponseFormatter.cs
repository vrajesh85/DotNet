using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MyProject.Services
{
    public interface IResponseFormatter
    {
        Task Format(HttpContext context, string content);
    }
}
