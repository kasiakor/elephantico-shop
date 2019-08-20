using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Elephantico.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Elephantico
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // we dont need to create an instance of the repository in the code, we can register the intefrace here
            // the instance of the repository will be served when requested in the code
            // AddTransiet wheneever an instance asked for IER a new Mockup repository will be returned
            services.AddTransient<IElephaitemRepository, MockElephaitemRepository>();

            // enable MVC
            services.AddMvc();
           

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline. Inspect reuest change it or pass it to another component. The sequence is important!
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // when sth goes wrog we will get an exception - only when developing!
            app.UseDeveloperExceptionPage();
            //400 or 500
            app.UseStatusCodePages();
            // support for static files, will retunr static files from wwwroot folder, these request can be handled by staticfiles like images request
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            // MVS middleware component
            app.UseMvcWithDefaultRoute();
        }
    }
}
