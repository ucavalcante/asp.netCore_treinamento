using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace hosting
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app){
            app.UseMiddleware<MyMiddleware>();

            app.Run(context => context.Response.WriteAsync("Olá Mundo 2"));
        }
    }
}