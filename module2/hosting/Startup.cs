using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace hosting
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app){
            app.Run(context => context.Response.WriteAsync("Olá Mundo 2"));
        }
    }
}