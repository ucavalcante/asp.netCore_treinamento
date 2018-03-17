using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace hosting
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app){
            app.Use(async (context, next) => {
                context.Response.Headers.Add("Midleware","Apreendendo");
                await next.Invoke();
            });

            app.Run(context => context.Response.WriteAsync("Olá Mundo 2"));
        }
    }
}