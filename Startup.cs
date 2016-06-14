using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HandsOn.Models;


namespace HandsOn
{
    public class Startup
    {
        private IHostingEnvironment _environment;
        public Startup(IHostingEnvironment environment)
        { 
            _environment = environment;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            // registering our own services 
            services.AddSingleton<IFloorMonitor, FloorMonitor>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            if(_environment.IsDevelopment())
                app.UseDeveloperExceptionPage(); 

            //"default"
            // /{controller=Home}/{action=Index}/{id?}
            app.UseMvcWithDefaultRoute();

            app.UseDefaultFiles();
            app.UseStaticFiles();
        }
    }
}
