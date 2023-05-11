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
            modelBuilder.Entity<Module>()
                .HasMany(m => m.RequiredModules)
                .WithMany(m => m.DependentModules)
                .UsingEntity(j => j.ToTable("ModuleRelationships"));


            modelBuilder.Entity<Cohort>()
                .HasMany(c => c.Modules)
                .WithMany(m => m.Cohorts)
                .UsingEntity(j =>
                {
                    j.ToTable("CohortModules");
                });

            // Your other configurations...
            base.OnModelCreating(modelBuilder);

            var passwordHasher = new PasswordHasher<User>();

            modelBuilder.Entity<User>().HasData(
                    new User
                    {
                        Id = "1",
                        UserName = "john@example.com",
                        Email = "john@example.com",
                        Name = "John Doe",
                        FirstName = "John",
                        LastName = "Doe",
                        PasswordHash = passwordHasher.HashPassword(null, "welkom")
                    },
                    new User
                    {
                        Id = "2",
                        UserName = "jane@example.com",
                        Email = "jane@example.com",
                        Name = "Jane Smith",
                        FirstName = "Jane",
                        LastName = "Smith",
                        PasswordHash = passwordHasher.HashPassword(null, "welkom")
                    }
                );

            var cohorts = new List<Cohort>
            {
                new Cohort(1, "Cohort 1", 1),
                new Cohort(2, "Cohort 2", 1),
                new Cohort(3, "Cohort 3", 2),
                new Cohort(4, "Cohort 4", 2),
            };

            modelBuilder.Entity<Cohort>().HasData(cohorts);

            var modules = new List<Module>
            {
                new Module(1, "Module 1", "Description for Module 1", 1, 2023),
                new Module(2, "Module 2", "Description for Module 2", 2, 2023),
                new Module(3, "Module 3", "Description for Module 3", 1, 2024),
                new Module(4, "Module 4", "Description for Module 4", 2, 2024),
            };


            modelBuilder.Entity<Module>().HasData(modules);

            modelBuilder.Entity<Cohort>()
                .HasMany(c => c.Modules)
                .WithMany(m => m.Cohorts)
                .UsingEntity(j =>
                    {
                        j.ToTable("CohortModules");
                        j.HasData(
                            new { CohortsId = 1, ModulesId = 1 },
                            new { CohortsId = 1, ModulesId = 2 },
                            new { CohortsId = 2, ModulesId = 1 },
                            new { CohortsId = 2, ModulesId = 2 },
                            new { CohortsId = 3, ModulesId = 3 },
                            new { CohortsId = 3, ModulesId = 4 },
                            new { CohortsId = 4, ModulesId = 3 },
                            new { CohortsId = 4, ModulesId = 4 }
                        );
                    });

            modelBuilder.Entity<Module>()
                .HasMany(m => m.RequiredModules)
                .WithMany(m => m.DependentModules)
                .UsingEntity(j =>
                {
                    j.ToTable("ModuleRelationships");
                    j.HasData(
                        new { RequiredModulesId = 1, DependentModulesId = 2 },
                        new { RequiredModulesId = 2, DependentModulesId = 3 },
                        new { RequiredModulesId = 3, DependentModulesId = 4 },
                        new { RequiredModulesId = 1, DependentModulesId = 4 }
                    );
                });

        }
    }
}
