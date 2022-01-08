using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    public class Startup
    {
        private IConfiguration _config;
        public Startup(IConfiguration config)
        {
            _config = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync($"<div><h1>Bai1A:</h1></div><hr>");
                    foreach (var book in _config.GetSection("book").GetChildren().ToList())
                    {
                        await context.Response.WriteAsync($"<div>id:{_config.GetSection($"book:{book.Key}:id").Value}</div>");
                        await context.Response.WriteAsync($"<div>language:{_config.GetSection($"book:{book.Key}:language").Value}</div>");
                        await context.Response.WriteAsync($"<div>edition:{_config.GetSection($"book:{book.Key}:edition").Value}</div>");
                        await context.Response.WriteAsync($"<div>author:{_config.GetSection($"book:{book.Key}:author").Value}</div><br>");
                        
                    }

                    await context.Response.WriteAsync($"<div><h1>Ba1B:</h1></div><hr>");
                    foreach (var book in _config.GetSection("book").GetChildren().ToList())
                    {
                        if (_config.GetSection($"book:{book.Key}:id").Value == "555")
                        {
                            await context.Response.WriteAsync($"<div>id:{_config.GetSection($"book:{book.Key}:id").Value}</div>");
                            await context.Response.WriteAsync($"<div>language:{_config.GetSection($"book:{book.Key}:language").Value}</div>");
                            await context.Response.WriteAsync($"<div>edition:{_config.GetSection($"book:{book.Key}:edition").Value}</div>");
                            await context.Response.WriteAsync($"<div>author:{_config.GetSection($"book:{book.Key}:author").Value}</div><br>");
                        }
                    }
                });
            });
        }
    }
}
