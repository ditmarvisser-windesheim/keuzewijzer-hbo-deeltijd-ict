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
        public DbSet<SemesterItems> Modules { get; set; }

        public DbSet<StudyRoute> StudyRoutes { get; set; }

        public DbSet<SemesterItem> SemesterItems { get; set; }

        public DbSet<StudyRouteItem> StudyRouteItems { get; set; }

        public DbSet<Cohort> Cohorts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SemesterItem>()
                .HasMany(m => m.RequiredSemesterItem)
                .WithMany(m => m.DependentSemesterItem)
                .UsingEntity(j => j.ToTable("SemesterItemRelationships"));


            modelBuilder.Entity<Cohort>()
                .HasMany(c => c.SemesterItems)
                .WithMany(m => m.Cohorts)
                .UsingEntity(j =>
                {
                    j.ToTable("CohortSemesterItems");
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

            var modules = new List<SemesterItems>
            {
                new SemesterItems(1, "Module 1", 1),
                new SemesterItems(2, "Module 2", 2),
                new SemesterItems(3, "Module 3", 3),
                new SemesterItems(4, "Module 4", 4),
                new SemesterItems(5, "Module 5", 5),
                new SemesterItems(6, "Module 6", 6),
                new SemesterItems(7, "Module 7", 7),
                new SemesterItems(8, "Module 8", 8),
                new SemesterItems(9, "Module 9", 9),
                new SemesterItems(10, "Module 10", 10),
                new SemesterItems(11, "Module 11", 11)
            };


            modelBuilder.Entity<SemesterItems>().HasData(modules);

            modelBuilder.Entity<Cohort>()
                .HasMany(c => c.SemesterItems)
                .WithMany(m => m.Cohorts)
                .UsingEntity(j =>
                    {
                        j.ToTable("CohortSemesterItems");
                        j.HasData(
                            new { CohortsId = 1, SemesterItemId = 1 },
                            new { CohortsId = 1, SemesterItemId = 2 },
                            new { CohortsId = 2, SemesterItemId = 1 },
                            new { CohortsId = 2, SemesterItemId = 2 },
                            new { CohortsId = 3, SemesterItemId = 3 },
                            new { CohortsId = 3, SemesterItemId = 4 },
                            new { CohortsId = 4, SemesterItemId = 3 },
                            new { CohortsId = 4, SemesterItemId = 4 }
                        );
                    });

            modelBuilder.Entity<SemesterItem>()
                .HasMany(m => m.RequiredSemesterItem)
                .WithMany(m => m.DependentSemesterItem)
                .UsingEntity(j =>
                {
                    j.ToTable("SemesterItemRelationships");
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
