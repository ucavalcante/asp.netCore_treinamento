using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace hosting
{
    public class Startup
    {
        private IConfigurationRoot _configuration;

        public Startup(IHostingEnvironment env)
        {
         var builder = new ConfigurationBuilder()
            .SetBasePath(env.ContentRootPath)   
            .AddJsonFile("appsettings.json");

        builder.AddEnvironmentVariables();

        _configuration = builder.Build();


        }
        public void Configure(IApplicationBuilder app){
            app.UseMiddleware<MyMiddleware>();

            app.Run(context => context.Response.WriteAsync("Olá Mundo 2 | "));
        }
    }
}