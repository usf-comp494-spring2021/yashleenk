/**
 * Author:           Yashleen Kheterpal
 * Date:             03/29/2021
 * Assignment:       Midterm
 * Course: COMP494:  C#
 * Purpose: Entry oint for the application so it connects to the services the application will use
 *
 */


using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Formatters;
using System;
using System.Net.Http.Headers;
using Microsoft.OpenApi.Models;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;


// This file handles configuration and setup for th eapplication at startup
namespace KheterpalFinalAplication
{
    public class Startup
    {
        //Config is passed
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //using httpclient to connect api 
            services.AddHttpClient(name: "WeatherForecast",
              configureClient: options =>
              {
                  options.BaseAddress = new Uri("http://csc494a-sp21-final.azurewebsites.net/");
                  options.DefaultRequestHeaders.Accept.Add(
              new MediaTypeWithQualityHeaderValue(
              "application/json", 1.0));
              });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "COMP494A", Version = "v1" });
            }); 

            services.AddControllersWithViews();
            services.AddControllers();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
               
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "COMP494A v1");
            });
            app.UseHttpsRedirection();
          
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=index}/{id?}") ;

                endpoints.MapRazorPages();
            });

        }

    }
}
