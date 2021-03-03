using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineBookstoreApp.Models;
using Microsoft.EntityFrameworkCore;

namespace OnlineBookstoreApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<BookstoreDBContext>(options =>
           {
               object p = options.UseSqlite(Configuration["ConnectionStrings:BookstoreConnection"]);
           });
            services.AddScoped<iBookRepository, EFBookRepository>();
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

            app.UseEndpoints(endpoints =>
            {
                //both page and category 
                endpoints.MapControllerRoute(
                    "categorypage",
                    "{category}/{page:int}",
                    new { Controller = "Home", action = "Index" });

                //only page 
                endpoints.MapControllerRoute(
                    "page",
                    "Books/{page:int}",
                    new { Controller = "Home", action = "Index" });

                //if they give us only the category
                endpoints.MapControllerRoute(
                    "category",
                    "{category}",
                    new { Controller = "Home", action = "Index", page = 1 });

                //endpoints /P1 or /P2
                endpoints.MapControllerRoute(
                    "pagination",
                    "P{page}",
                    new {Controller = "Home", action = "Index"});

                endpoints.MapDefaultControllerRoute();
            });

            SeedData.EnsurePopulated(app);

        }
    }
}
