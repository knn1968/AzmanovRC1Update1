using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.DependencyInjection;
using Azmanov.Entities;
using Azmanov.Services.Interfaces;
using Azmanov.Services;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.Extensions.Configuration;

namespace AzmanovRC1Update1
{
    public class Startup
    {
        public static IConfigurationRoot Configuration;
        private IHostingEnvironment _hostingEnvironment;

        public Startup(IApplicationEnvironment appEnv, IHostingEnvironment hostingEnvironment)
        {
            var builder = new ConfigurationBuilder()
              .SetBasePath(appEnv.ApplicationBasePath)
              .AddJsonFile("config.json")
              .AddEnvironmentVariables();

            Configuration = builder.Build();

            _hostingEnvironment = hostingEnvironment;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            if (_hostingEnvironment.IsDevelopment())
            {
                services.AddScoped<IMailService, MailService>();
            }
            else
            {
                services.AddScoped<IMailService, MailService>();
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            //app.UseIISPlatformHandler();
            //app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseMvc();

            var defaultLanguage = new Language() { ShortDisplay = "EN" };
            app.UseMvc(config =>
            {
                config.MapRoute(
                    name: "Default",
                    template: "{language}/{controller}/{action}/{id?}",
                    defaults: new { language = defaultLanguage?.ShortDisplay, controller = "Home", action = "Index" });
            }
            );
            //todo name images consistently - create ruleset
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
