using APP.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APP.Repository
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Category> Category { get; set; }
        public DbSet<OrderOffers> OrderOffers { get; set; }
        public DbSet<Deal> Deal { get; set; }
        public DbSet<CompletedDeal> CompletedDeal { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<Message> Message { get; set; }
    }
}
