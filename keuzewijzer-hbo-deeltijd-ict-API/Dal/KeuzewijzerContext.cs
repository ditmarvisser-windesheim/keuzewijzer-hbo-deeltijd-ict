using Microsoft.EntityFrameworkCore;
using keuzewijzer_hbo_deeltijd_ict_API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace keuzewijzer_hbo_deeltijd_ict_API.Dal
{
    public class KeuzewijzerContext : IdentityDbContext
    {

        public KeuzewijzerContext(DbContextOptions<KeuzewijzerContext> options) : base(options)
        {
        }


        public DbSet<User> Users { get; set; }
        public DbSet<Module> Modules { get; set; }

        public DbSet<StudyRoute> StudyRoutes { get; set; }

        public DbSet<StudyRouteItem> StudyRouteItems { get; set; }
        public DbSet<Cohort> Cohorts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var passwordHasher = new PasswordHasher<User>();

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    UserName = "john@example.com",
                    Email = "john@example.com",
                    Name = "John Doe",
                    FirstName = "John",
                    LastName = "Doe",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                },
                new User
                {
                    Id = 2,
                    UserName = "jane@example.com",
                    Email = "jane@example.com",
                    Name = "Jane Smith",
                    FirstName = "Jane",
                    LastName = "Smith",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }
            );
        }



    }
}
