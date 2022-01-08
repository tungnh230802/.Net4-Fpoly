using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace bai1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseMvc();

            // CÂU 1A
            // app.UseMvcWithDefaultRoute();

            // CÂU 1B
            // app.UseMvc(routers =>
            // {
            //     routers.MapRoute("default", "{controller=Student}/{action=Index}/{id?}");
            // });

            // CÂU 1C
            // app.UseMvc(routers =>
            // {
            //     routers.MapRoute("default", "{controller=Student}/{action=Details}/{id?}");
            // });

            // CÂU 1D
            // app.UseMvc(routers =>
            // {
            //     routers.MapRoute("default", "{controller=Student}/{action=Details}/{id='id_string'}");
            // });

            // CÂU 2
            // app.UseMvc();

            // CÂU 3A
            // app.UseMvc(routers =>
            // {
            //     routers.MapRoute("default", "{controller=Home}/{action=Index}/{id:int?}");
            // });

            // CÂU 3B
            // app.UseMvc(routers =>
            // {
            //     routers.MapRoute("default", "{controller}/{action}/{id}",
            //     new { controller = "Home", action = "Index" },
            //     new { id = new IntRouteConstraint() });
            // });


            // CÂU 4A
            // app.UseMvc(routers =>
            // {
            //     routers.MapRoute("default",
            //     "{controller}/{action}/{year:regex(^\\d{{4}}$)}",
            //     new { controller = "HomeBai4", action = "Index" });
            // });

            // CÂU 4B
            // Constraint Method
            // app.UseMvc(routers =>
            // {
            //     routers.MapRoute("default",
            //     "{controller}/{action}/{year}",
            //     new { controller = "HomeBai4", action = "Index" },
            //     new { year = new RegexRouteConstraint("^\\d{{4}}$") });
            // });

            app.UseEndpoints(endpoints =>
            {
                // endpoints.MapControllerRoute();
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
