using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using DivarProject.Models;

namespace DivarProject.Data
{
    public class AdvertisementDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Advertisement> advertisements { get; set; }
        public DbSet<User> Users { get; set; }

        public AdvertisementDbContext(DbContextOptions<AdvertisementDbContext> options) : base(options) { }

    }

}


