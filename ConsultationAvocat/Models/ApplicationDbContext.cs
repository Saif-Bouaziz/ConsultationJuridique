using ConsultationAvocat.Models.ConsultationAvocat.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ConsultationAvocat.Models
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedRoles(builder);
        }
        private static void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData
                (
                    new IdentityRole() { Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "Admin" },
                    new IdentityRole() { Name = "Client", ConcurrencyStamp = "2", NormalizedName = "Client" },
                    new IdentityRole() { Name = "Avocat", ConcurrencyStamp = "3", NormalizedName = "Avocat" }
                );
        }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<AvocatAvailability> AvocatAvailabilities { get; set;}

        public DbSet<RendezVous> Appointments { get; set; }

    }
}
