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
            modelBuilder.Entity<StudyRoute>().HasData(
    new StudyRoute { Id = 1, Name = "Computer Science", Approved_sb = true, Approved_eb = true, Note = "This is a note", Send_sb = true, Send_eb = true, UserId = 1 }
    );

            modelBuilder.Entity<SemesterItem>().HasData(
                 new SemesterItem
                 {
                     Id = 1,
                     Name = "Semester Item 1",
                     Description = "Description for Semester Item 1",
                     Year = new List<int> { 1 },
                     Semester = 1,
                     RequiredSemesterItem = new List<SemesterItem>(),
                     DependentSemesterItem = new List<SemesterItem>()
                 },
                 new SemesterItem
                 {
                     Id = 2,
                     Name = "Semester Item 2",
                     Description = "Description for Semester Item 2",
                     Year = new List<int> { 1 },
                     Semester = 2,
                     RequiredSemesterItem = new List<SemesterItem>(),
                     DependentSemesterItem = new List<SemesterItem>()
                 },
                 new SemesterItem
                 {
                     Id = 3,
                     Name = "Semester Item 3",
                     Description = "Description for Semester Item 3",
                     Year = new List<int> { 2 },
                     Semester = 1,
                     RequiredSemesterItem = new List<SemesterItem>(),
                     DependentSemesterItem = new List<SemesterItem>()
                 },
                 new SemesterItem
                 {
                     Id = 4,
                     Name = "Semester Item 4",
                     Description = "Description for Semester Item 4",
                     Year = new List<int> { 2 },
                     Semester = 2,
                     RequiredSemesterItem = new List<SemesterItem>(),
                     DependentSemesterItem = new List<SemesterItem>()
                 }, 
                 new SemesterItem
                 {
                     Id = 5,
                     Name = "Semester Item 5",
                     Description = "Description for Semester Item 5",
                     Year = new List<int> { 2 },
                     Semester = 2,
                     RequiredSemesterItem = new List<SemesterItem>(),
                     DependentSemesterItem = new List<SemesterItem>()
                 },
                 new SemesterItem
                 {
                     Id = 6,
                     Name = "Semester Item 6",
                     Description = "Description for Semester Item 6",
                     Year = new List<int> { 2 },
                     Semester = 2,
                     RequiredSemesterItem = new List<SemesterItem>(),
                     DependentSemesterItem = new List<SemesterItem>()
                 },  
                 new SemesterItem
                 {
                     Id = 7,
                     Name = "Semester Item 7",
                     Description = "Description for Semester Item 7",
                     Year = new List<int> { 2 },
                     Semester = 2,
                     RequiredSemesterItem = new List<SemesterItem>(),
                     DependentSemesterItem = new List<SemesterItem>()
                 },   
                 new SemesterItem
                 {
                     Id = 8,
                     Name = "Semester Item 8",
                     Description = "Description for Semester Item 8",
                     Year = new List<int> { 2 },
                     Semester = 2,
                     RequiredSemesterItem = new List<SemesterItem>(),
                     DependentSemesterItem = new List<SemesterItem>()
                 }
             );


            var cohorts = new List<Cohort>
            {
                new Cohort(1, "Cohort 1", 2020),
                new Cohort(2, "Cohort 2", 2021),
                new Cohort(3, "Cohort 3", 2022),
                new Cohort(4, "Cohort 4", 2023),
            };

            modelBuilder.Entity<Cohort>().HasData(cohorts);

            var modules = new List<Module>
            {
                new Module(1, "Module 1", 1),
                new Module(2, "Module 2", 2),
                new Module(3, "Module 3", 3),
                new Module(4, "Module 4", 4)
            };


            modelBuilder.Entity<Module>().HasData(modules);

            modelBuilder.Entity<Cohort>()
                .HasMany(c => c.SemesterItems)
                .WithMany(m => m.Cohorts)
                .UsingEntity(j =>
                {
                    j.ToTable("CohortSemesterItems");
                    j.HasData(
                        new { CohortsId = 4, SemesterItemsId = 1 },
                        new { CohortsId = 4, SemesterItemsId = 2 },
                        new { CohortsId = 4, SemesterItemsId = 3 },
                        new { CohortsId = 4, SemesterItemsId = 4 },
                        new { CohortsId = 4, SemesterItemsId = 5 },
                        new { CohortsId = 4, SemesterItemsId = 6 },
                        new { CohortsId = 4, SemesterItemsId = 7 },
                        new { CohortsId = 4, SemesterItemsId = 8 }
                    );
                });

            modelBuilder.Entity<SemesterItem>()
                .HasMany(m => m.RequiredSemesterItem)
                .WithMany(m => m.DependentSemesterItem)
                .UsingEntity(j =>
                {
                    j.ToTable("SemesterItemRelationships");
                    j.HasData(
                        new { RequiredSemesterItemId = 1, DependentSemesterItemId = 2 },
                        new { RequiredSemesterItemId = 2, DependentSemesterItemId = 3 },
                        new { RequiredSemesterItemId = 3, DependentSemesterItemId = 4 },
                        new { RequiredSemesterItemId = 1, DependentSemesterItemId = 4 }
                    );
                });



            modelBuilder.Entity<StudyRouteItem>().HasData(
                new StudyRouteItem { Id = 1, Year = 2023, Semester = 1, StudyRouteId = 1, SemesterItemId = 1 },
                new StudyRouteItem { Id = 2, Year = 2023, Semester = 1, StudyRouteId = 1, SemesterItemId = 2 },
                new StudyRouteItem { Id = 3, Year = 2023, Semester = 1, StudyRouteId = 1, SemesterItemId = 3 },
                new StudyRouteItem { Id = 4, Year = 2023, Semester = 1, StudyRouteId = 1, SemesterItemId = 4 }
                );

        }
    }
}
