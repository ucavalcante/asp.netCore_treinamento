using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace hosting
{
    public class MyMiddleware
    {
        private RequestDelegate _next;
        public MyMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public  async Task Invoke(HttpContext context){
            //Request
            await _next(context);
            //Response
        }
    }
}