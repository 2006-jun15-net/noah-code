using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HelloWorldWebApp
{
    // a controller will take responsibility for ahndling some subset of requests to the app
    // usually based upon the path in the URL
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //teach asp.net about controllers
            //services.AddControllers();
            services.AddControllersWithViews();
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
                //C# supports anonymous types like new {prop = "a", prop2 = 1}
                // we can set up multiple routes - each one will give a 
                endpoints.MapControllerRoute("Hello-route", "hello", new { controller = "Hello", action = "Hello1" } );
                endpoints.MapControllerRoute("default", "{controller}/{action}");
            });
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});

            //for every request, just respond with hello world html
            //app.Run(async context =>
            //{
            //    context.Response.StatusCode = 200;//success
            //    context.Response.ContentType = "text/html";
            //    await context.Response.WriteAsync("<!DOCTYPE html> <html><head></head><body>Hello world</bod></html>");
            //});

            // for every request, loook in the url for a relative path, and repsond
            // with the contents of that file
            app.Run(async context =>
            {
                string path = $"wwwroot{context.Request.Path}";
                

                try
                {
                    string text = await File.ReadAllTextAsync(path);
                    context.Response.StatusCode = 200;//success
                    context.Response.ContentType = "text/html";
                    await context.Response.WriteAsync(text);
                }
                catch (Exception ex)
                {

                    context.Response.StatusCode = 500; //error
                }

                
                //await context.Response.WriteAsync($"<!DOCTYPE html> <html><head></head><body>Path: {context.Request.Path}</bod></html>");
            });

        }
    }
}
