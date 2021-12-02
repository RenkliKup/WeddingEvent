using DugunDaveti.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DugunDaveti
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
            services.AddControllersWithViews();
            services.AddDbContext<WeddingInventDbContext>(item => 
            item.UseSqlServer(Configuration.GetConnectionString("constring")));
            services.AddScoped<IWeddingRepository, EFWeddingInventRepository>();
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
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllerRoute("catpage",
                    "{isAttend}/Page{participantPage:int}",
                    new { Controller = "Home", action = "ParticipantList" });

                endpoints.MapControllerRoute("page", "Page{participantPage:int}",
                    new { Controller = "Home", action = "ParticipantList", participantPage = 1 });

                endpoints.MapControllerRoute("isAttend", "{isAttend}",
                    new { Controller = "Home", action = "ParticipantList", participantPage = 1 });

                endpoints.MapControllerRoute("pagination",
                    "weddingInvents/Page{participantPage}",
                    new { Controller = "Home", action = "ParticipantList", participantPage = 1 });
                endpoints.MapDefaultControllerRoute();
                
            });
        }
    }
}
