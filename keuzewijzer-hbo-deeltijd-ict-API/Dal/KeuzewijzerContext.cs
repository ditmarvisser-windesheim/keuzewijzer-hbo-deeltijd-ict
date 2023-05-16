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
                new Module(1, "Module 1", "Description for Module 1", 1, 2013),
                new Module(2, "Module 2", "Description for Module 2", 2, 2014),
                new Module(3, "Module 3", "Description for Module 3", 1, 2015),
                new Module(4, "Module 4", "Description for Module 4", 2, 2016),
                new Module(5, "Module 5", "Description for Module 5", 1, 2017),
                new Module(6, "Module 6", "Description for Module 6", 2, 2018),
                new Module(7, "Module 7", "Description for Module 7", 1, 2019),
                new Module(8, "Module 8", "Description for Module 8", 2, 2020),
                new Module(9, "Module 9", "Description for Module 9", 1, 2021),
                new Module(10, "Module 10", "Description for Module 10", 2, 2022),
                new Module(11, "Module 11", "Description for Module 11", 2, 2023)
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
            modelBuilder.Entity<StudyRoute>().HasData(
                new StudyRoute { Id = 1, Name = "Computer Science", Approved_sb = true, Approved_eb = true, Note = "This is a note", Send_sb = true, Send_eb = true, UserId = 1 }
                );


            modelBuilder.Entity<StudyRouteItem>().HasData(
                new StudyRouteItem { Id = 1, Year = 2023, Semester = 1, StudyRouteId = 1, ModuleId = 1 },
                new StudyRouteItem { Id = 2, Year = 2023, Semester = 1, StudyRouteId = 1, ModuleId = 2 },
                new StudyRouteItem { Id = 3, Year = 2023, Semester = 1, StudyRouteId = 1, ModuleId = 3 },
                new StudyRouteItem { Id = 4, Year = 2023, Semester = 1, StudyRouteId = 1, ModuleId = 4 },
                new StudyRouteItem { Id = 5, Year = 2023, Semester = 1, StudyRouteId = 1, ModuleId = 5 },
                new StudyRouteItem { Id = 6, Year = 2023, Semester = 1, StudyRouteId = 1, ModuleId = 6 },
                new StudyRouteItem { Id = 7, Year = 2023, Semester = 1, StudyRouteId = 1, ModuleId = 7 },
                new StudyRouteItem { Id = 8, Year = 2023, Semester = 1, StudyRouteId = 1, ModuleId = 8 },
                new StudyRouteItem { Id = 9, Year = 2023, Semester = 2, StudyRouteId = 1, ModuleId = 9 },
                new StudyRouteItem { Id = 10, Year = 2023, Semester = 2, StudyRouteId = 1, ModuleId = 10 }
                );
        }
    }
}
