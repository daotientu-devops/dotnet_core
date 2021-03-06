using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyFirstCoreWebApp.Models;
using MyFirstCoreWebApp.Repositories;

namespace MyFirstCoreWebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                DeveloperExceptionPageOptions developerExceptionPageOptions = new DeveloperExceptionPageOptions
                {
                    SourceCodeLineCount = 5
                };
                app.UseDeveloperExceptionPage(developerExceptionPageOptions);
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            /*
            // Use UseFileServer instead of UseDefaultFiles & UseStaticFiles
            FileServerOptions fileServerOptions = new FileServerOptions();
            fileServerOptions.DefaultFilesOptions.DefaultFileNames.Clear();
            fileServerOptions.DefaultFilesOptions.DefaultFileNames.Add("MyCustomPage2.html");
            app.UseFileServer(fileServerOptions);
            */
            // Specify the MyCustomPage1.html as the default page
            //DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
            //defaultFilesOptions.DefaultFileNames.Clear();
            //defaultFilesOptions.DefaultFileNames.Add("MyCustomPage1.html");
            // Setting the default files
            //app.UseDefaultFiles(defaultFilesOptions);
            // Adding static files middleware to serve the static files
            app.UseStaticFiles();
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            /*
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Middleware1: Incoming Request\n");
                await next();
                await context.Response.WriteAsync("Middleware1: Outgoing Response\n");
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Middleware2: Incoming Request\n");
                await next();
                await context.Response.WriteAsync("Middleware2: Outgoing Response\n");
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Middleware3: Incoming Request handled and response generated\n");
            });
            */
            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapGet("/", async context =>{await context.Response.WriteAsync(Configuration["APP_KEY"]);});
                endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
