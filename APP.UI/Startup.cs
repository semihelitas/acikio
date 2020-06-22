using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using APP.Repository;
using APP.Core.Models;
using APP.Repository.Repository;
using APP.Service.UnitOfWork;
using APP.Service.Abstract;
using APP.Service.Concrete;
using APP.Repository.FoodAds;

namespace APP.UI
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
            // DbContext
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DatabaseConnection")));
            // Identity
            services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            // Services
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IFoodAdsService, FoodAdsService>();
            services.AddScoped<IFoodAdsRepository, FoodAdsRepository>();

            // Settings
            services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseDatabaseErrorPage();
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

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //default
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                // .com/anasayfa
                endpoints.MapControllerRoute(
                         name: "homepage",
                         pattern: "anasayfa",
                         defaults: new { controller = "Home", action = "Index" });

                // .com/yemek-yapanlar
                endpoints.MapControllerRoute(
                         name: "foodAdsIndex",
                         pattern: "yemek-yapanlar",
                         defaults: new { controller = "FoodAds", action = "Index" });

                endpoints.MapRazorPages();
            });
        }
    }
}
