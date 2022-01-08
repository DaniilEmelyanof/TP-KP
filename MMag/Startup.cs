using System;
using System.Collections.Generic;
using System.Linq;
using MMag.Data.Interfaces;
using MMag.Data.mocks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;



namespace MMag 
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services) { 
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddMvcCore();
            services.AddRazorPages();
            services.AddControllersWithViews();
            services.AddTransient<IInst, MockInstruments>();
            services.AddTransient<IInstrumentsCategory, MockCategory>();

        }

        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseStatusCodePages();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action}/{id?}");
            });
            //app.UseMvcWithDefaultRoute();
        }
    }
}
