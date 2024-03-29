﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using DrankAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;


namespace DrankAPI
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddScoped<IDrankRepository, MockDrankRepository>();
            services.AddDbContextPool<AppDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DrankDBConnection")));
            /* services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.Authority = "https://accounts.google.com";      // De uitgever van het token (en waarbij dus de geldigheid kan worden afgetoetst)
                    options.Audience = "---noteer hier je client id----";   // diegene waarvoor het token bestemt is.
                });*/
        
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseStaticFiles();
            app.UseHttpsRedirection();

            //app.UseMvc(routes => {
            //   routes.MapRoute("default", "{controller=home}/{action=index}/{id?}");
            //});
            //app.UseMvcWithDefaultRoute();
            app.UseMvc();
            app.Run(async (context)=> 
            {
                await context.Response.WriteAsync("something went wrong, please check your URL or try again later . ");
            });

            /*app.UseGoogleAuthentication(new GoogleOAuth2AuthenticationOptions()
            {
                ClientId = " 746153962084-qqrpkob2971dev1u54qt6bra5p07ec65.apps.googleusercontent.com ",
                ClientSecret = "MJ0o8IyzUeJLirS9fN753jtP"
            });*/
        }
    }
}
