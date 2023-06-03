﻿using Microsoft.EntityFrameworkCore;
using keuzewijzer_hbo_deeltijd_ict_API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace keuzewijzer_hbo_deeltijd_ict_API.Dal
{
    public class KeuzewijzerContext : IdentityDbContext<User, IdentityRole, string>
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
            

            modelBuilder.Entity<User>()
                           .HasMany(u => u.SemesterItems)
                           .WithMany(s => s.Users)
                           .UsingEntity(join => join.ToTable("UserSemesterItems"));


            // Your other configurations...
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "Administrator", NormalizedName = "ADMINISTRATOR" },
                new IdentityRole { Id = "2", Name = "Student", NormalizedName = "STUDENT" },
                new IdentityRole { Id = "3", Name = "Studiebegeleider", NormalizedName = "STUDIEBEGELEIDER" },
                new IdentityRole { Id = "4", Name = "Moduleverantwoordelijke", NormalizedName = "MODULEVERANTWOORDELIJKE" }
            );

            var passwordHasher = new PasswordHasher<User>();

            modelBuilder.Entity<User>().HasData(
                  new User
                  {
                      Id = "1",
                      UserName = "admin",
                      NormalizedUserName = "admin",
                      Email = "admin@example.com",
                      NormalizedEmail = "admin@example.com",
                      Name = "Arnold Dirk Min",
                      FirstName = "Arnold",
                      LastName = "Min",
                      PasswordHash = passwordHasher.HashPassword(null, "welkom")
                  },
                  new User
                  {
                      Id = "2",
                      UserName = "eugenevanroden",
                      NormalizedUserName = "eugenevanroden",
                      Email = "eugenevanroden@example.com",
                      NormalizedEmail = "eugenevanroden@example.com",
                      Name = "Eugene Van Roden",
                      FirstName = "Eugene",
                      LastName = "Van Roden",
                      PasswordHash = passwordHasher.HashPassword(null, "welkom")
                  }
             );

            modelBuilder.Entity<StudyRoute>().HasData(
                new StudyRoute { Id = 1, Name = "Computer Science", Approved_sb = true, Approved_eb = true, Note = "This is a note", Send_sb = true, Send_eb = true, UserId = "1" }
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
                 }
             );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new { UserId = "1", RoleId = "1" }
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
                        new { CohortsId = 1, SemesterItemsId = 1 },
                        new { CohortsId = 1, SemesterItemsId = 2 },
                        new { CohortsId = 2, SemesterItemsId = 1 },
                        new { CohortsId = 2, SemesterItemsId = 2 },
                        new { CohortsId = 3, SemesterItemsId = 3 },
                        new { CohortsId = 3, SemesterItemsId = 4 },
                        new { CohortsId = 4, SemesterItemsId = 3 },
                        new { CohortsId = 4, SemesterItemsId = 4 }
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
                new StudyRouteItem { Id = 1, Year = 2023, Semester = 1, StudyRouteId = 1, SemesterItemId = 1 }
                );

        }
    }
}
