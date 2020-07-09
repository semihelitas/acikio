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
using APP.Repository.CategoryRepository;
using APP.Repository.UserRepository;
using APP.Repository.DealRepository;
using APP.Repository.OrderOfferRepository;
using APP.Repository.NotificationRepository;

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
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            // Services
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IOrderOffersService, OrderOffersService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IDealService, DealService>();
            services.AddTransient<INotificationService, NotificationService>();
            services.AddTransient<IOrderOffersRepository, OrderOffersRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IDealRepository, DealRepository>();
            services.AddTransient<INotificationRepository, NotificationRepository>();

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

                // .com/ustalar
                endpoints.MapControllerRoute(
                         name: "ustalar",
                         pattern: "ustalar",
                         defaults: new { controller = "User", action = "Users" });

                // .com/ustalar/{*category}
                endpoints.MapControllerRoute(
                         name: "ustalar-category",
                         pattern: "ustalar/{*category}",
                         defaults: new { controller = "User", action = "FilteredUsersByCategory" });

                // .com/anasayfa
                endpoints.MapControllerRoute(
                         name: "homepage",
                         pattern: "anasayfa",
                         defaults: new { controller = "Home", action = "Index" });

                // .com/siparisler
                endpoints.MapControllerRoute(
                         name: "orderOffers",
                         pattern: "siparis-teklifleri",
                         defaults: new { controller = "OrderOffer", action = "Index" });

                // .com/yonetim-paneli
                endpoints.MapControllerRoute(
                         name: "dashboard",
                         pattern: "/yonetim-paneli",
                         defaults: new { controller = "Dashboard", action = "Summary" });

                // .com/yonetim-paneli/profili-duzenle
                endpoints.MapControllerRoute(
                         name: "profileEdit",
                         pattern: "/yonetim-paneli/profili-duzenle",
                         defaults: new { controller = "Dashboard", action = "ProfileEdit" });

                // .com/yonetim-paneli/gelen-teklifler
                endpoints.MapControllerRoute(
                         name: "manageOffers",
                         pattern: "/yonetim-paneli/gelen-teklifler",
                         defaults: new { controller = "OrderOffer", action = "IncomingOffers" });

                // .com/yonetim-paneli/gelen-teklifler
                endpoints.MapControllerRoute(
                         name: "manageOffersOfSingleAd",
                         pattern: "/yonetim-paneli/gelen-teklifler/{*id}",
                         defaults: new { controller = "OrderOffer", action = "IncomingOffersOfSingleAd" });

                // .com/yonetim-paneli/teklifler
                endpoints.MapControllerRoute(
                         name: "manageOffers",
                         pattern: "/yonetim-paneli/tekliflerim",
                         defaults: new { controller = "OrderOffer", action = "SentOffers" });

                // .com/yonetim-paneli/gelen-teklifler
                endpoints.MapControllerRoute(
                         name: "message",
                         pattern: "mesajlar/{*receiverId}",
                         defaults: new { controller = "Message", action = "Inbox" });

                endpoints.MapRazorPages();
            });
        }
    }
}
