using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.DependencyInjection;

namespace AzmanovRC1Update1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseDefaultFiles();
            app.UseStaticFiles();
            //            app.UseIISPlatformHandler();

  //          var html = @"<!DOCTYPE html>
  //<html>
  //<head>
  //    <meta charset = ""utf-8""/>
  //     <title></title>
  // </head>
  // <body>
  //     <h2> Azmanov </h2>
  // </body>
  // </html>";

  //          app.Run(async (context) =>
  //          {
  //              await context.Response.WriteAsync(html);
  //          });
        }



        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
