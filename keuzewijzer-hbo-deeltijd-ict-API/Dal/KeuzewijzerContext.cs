using Microsoft.EntityFrameworkCore;
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
                },
                new User
                {
                    Id = "3",
                    UserName = "theotan",
                    NormalizedUserName = "theotan",
                    Email = "theotan@example.com",
                    NormalizedEmail = "theotan@example.com",
                    Name = "Theo Tan",
                    FirstName = "Theo",
                    LastName = "Tan",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "4",
                    UserName = "floruscicek",
                    NormalizedUserName = "floruscicek",
                    Email = "floruscicek@example.com",
                    NormalizedEmail = "floruscicek@example.com",
                    Name = "Florus Çiçek",
                    FirstName = "Florus",
                    LastName = "Çiçek",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "5",
                    UserName = "marlenewolf",
                    NormalizedUserName = "marlenewolf",
                    Email = "marlenewolf@example.com",
                    NormalizedEmail = "marlenewolf@example.com",
                    Name = "Marlène Wolf",
                    FirstName = "Marlène",
                    LastName = "Wolf",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "6",
                    UserName = "bilalsteentjes",
                    NormalizedUserName = "bilalsteentjes",
                    Email = "bilalsteentjes@example.com",
                    NormalizedEmail = "bilalsteentjes@example.com",
                    Name = "Bilal Steentjes",
                    FirstName = "Bilal",
                    LastName = "Steentjes",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "7",
                    UserName = "marlijngiebels",
                    NormalizedUserName = "marlijngiebels",
                    Email = "marlijngiebels@example.com",
                    NormalizedEmail = "marlijngiebels@example.com",
                    Name = "Marlijn Giebels",
                    FirstName = "Marlijn",
                    LastName = "Giebels",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "8",
                    UserName = "sabrivandereijk",
                    NormalizedUserName = "sabrivandereijk",
                    Email = "sabrivandereijk@example.com",
                    NormalizedEmail = "sabrivandereijk@example.com",
                    Name = "Sabri Van der Eijk",
                    FirstName = "Sabri",
                    LastName = "Van der Eijk",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "9",
                    UserName = "caseyandriesse",
                    NormalizedUserName = "caseyandriesse",
                    Email = "caseyandriesse@example.com",
                    NormalizedEmail = "caseyandriesse@example.com",
                    Name = "Casey Andriesse",
                    FirstName = "Casey",
                    LastName = "Andriesse",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "10",
                    UserName = "nikhuijskens",
                    NormalizedUserName = "nikhuijskens",
                    Email = "nikhuijskens@example.com",
                    NormalizedEmail = "nikhuijskens@example.com",
                    Name = "Nik Huijskens",
                    FirstName = "Nik",
                    LastName = "Huijskens",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "11",
                    UserName = "duranpetiet",
                    NormalizedUserName = "duranpetiet",
                    Email = "duranpetiet@example.com",
                    NormalizedEmail = "duranpetiet@example.com",
                    Name = "Duran Petiet",
                    FirstName = "Duran",
                    LastName = "Petiet",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "12",
                    UserName = "veroniekbravenboer",
                    NormalizedUserName = "veroniekbravenboer",
                    Email = "veroniekbravenboer@example.com",
                    NormalizedEmail = "veroniekbravenboer@example.com",
                    Name = "Veroniek Bravenboer",
                    FirstName = "Veroniek",
                    LastName = "Bravenboer",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "13",
                    UserName = "kaynejagtenberg",
                    NormalizedUserName = "kaynejagtenberg",
                    Email = "kaynejagtenberg@example.com",
                    NormalizedEmail = "kaynejagtenberg@example.com",
                    Name = "Kayne Jagtenberg",
                    FirstName = "Kayne",
                    LastName = "Jagtenberg",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "14",
                    UserName = "siebrigjeabdi",
                    NormalizedUserName = "siebrigjeabdi",
                    Email = "siebrigjeabdi@example.com",
                    NormalizedEmail = "siebrigjeabdi@example.com",
                    Name = "Siebrigje Abdi",
                    FirstName = "Siebrigje",
                    LastName = "Abdi",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "15",
                    UserName = "sterrelambert",
                    NormalizedUserName = "sterrelambert",
                    Email = "sterrelambert@example.com",
                    NormalizedEmail = "sterrelambert@example.com",
                    Name = "Sterre Lambert",
                    FirstName = "Sterre",
                    LastName = "Lambert",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "16",
                    UserName = "milicavandergouw",
                    NormalizedUserName = "milicavandergouw",
                    Email = "milicavandergouw@example.com",
                    NormalizedEmail = "milicavandergouw@example.com",
                    Name = "Milica Van der Gouw",
                    FirstName = "Milica",
                    LastName = "Van der Gouw",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "17",
                    UserName = "yvonbrussaard",
                    NormalizedUserName = "yvonbrussaard",
                    Email = "yvonbrussaard@example.com",
                    NormalizedEmail = "yvonbrussaard@example.com",
                    Name = "Yvon Brussaard",
                    FirstName = "Yvon",
                    LastName = "Brussaard",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "18",
                    UserName = "bodhidatema",
                    NormalizedUserName = "bodhidatema",
                    Email = "bodhidatema@example.com",
                    NormalizedEmail = "bodhidatema@example.com",
                    Name = "Bodhi Datema",
                    FirstName = "Bodhi",
                    LastName = "Datema",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "19",
                    UserName = "noachschutrups",
                    NormalizedUserName = "noachschutrups",
                    Email = "noachschutrups@example.com",
                    NormalizedEmail = "noachschutrups@example.com",
                    Name = "Noach Schutrups",
                    FirstName = "Noach",
                    LastName = "Schutrups",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "20",
                    UserName = "ouassimbekking",
                    NormalizedUserName = "ouassimbekking",
                    Email = "ouassimbekking@example.com",
                    NormalizedEmail = "ouassimbekking@example.com",
                    Name = "Ouassim Bekking",
                    FirstName = "Ouassim",
                    LastName = "Bekking",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "21",
                    UserName = "noervanderkruit",
                    NormalizedUserName = "noervanderkruit",
                    Email = "noervanderkruit@example.com",
                    NormalizedEmail = "noervanderkruit@example.com",
                    Name = "Noer Van der Kruit",
                    FirstName = "Noer",
                    LastName = "Van der Kruit",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "22",
                    UserName = "kaanvanmaarseveen",
                    NormalizedUserName = "kaanvanmaarseveen",
                    Email = "kaanvanmaarseveen@example.com",
                    NormalizedEmail = "kaanvanmaarseveen@example.com",
                    Name = "Kaan Van Maarseveen",
                    FirstName = "Kaan",
                    LastName = "Van Maarseveen",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "23",
                    UserName = "owenkaal",
                    NormalizedUserName = "owenkaal",
                    Email = "owenkaal@example.com",
                    NormalizedEmail = "owenkaal@example.com",
                    Name = "Owen Kaal",
                    FirstName = "Owen",
                    LastName = "Kaal",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "24",
                    UserName = "paulinebah",
                    NormalizedUserName = "paulinebah",
                    Email = "paulinebah@example.com",
                    NormalizedEmail = "paulinebah@example.com",
                    Name = "Pauline Bah",
                    FirstName = "Pauline",
                    LastName = "Bah",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "25",
                    UserName = "caterinatas",
                    NormalizedUserName = "caterinatas",
                    Email = "caterinatas@example.com",
                    NormalizedEmail = "caterinatas@example.com",
                    Name = "Caterina Tas",
                    FirstName = "Caterina",
                    LastName = "Tas",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "26",
                    UserName = "edtouw",
                    NormalizedUserName = "edtouw",
                    Email = "edtouw@example.com",
                    NormalizedEmail = "edtouw@example.com",
                    Name = "Ed Touw",
                    FirstName = "Ed",
                    LastName = "Touw",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "27",
                    UserName = "hugofidom",
                    NormalizedUserName = "hugofidom",
                    Email = "hugofidom@example.com",
                    NormalizedEmail = "hugofidom@example.com",
                    Name = "Hugo Fidom",
                    FirstName = "Hugo",
                    LastName = "Fidom",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "28",
                    UserName = "nannebesseling",
                    NormalizedUserName = "nannebesseling",
                    Email = "nannebesseling@example.com",
                    NormalizedEmail = "nannebesseling@example.com",
                    Name = "Nanne Besseling",
                    FirstName = "Nanne",
                    LastName = "Besseling",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "29",
                    UserName = "teunisjesalden",
                    NormalizedUserName = "teunisjesalden",
                    Email = "teunisjesalden@example.com",
                    NormalizedEmail = "teunisjesalden@example.com",
                    Name = "Teunisje Salden",
                    FirstName = "Teunisje",
                    LastName = "Salden",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "30",
                    UserName = "rochedoornink",
                    NormalizedUserName = "rochedoornink",
                    Email = "rochedoornink@example.com",
                    NormalizedEmail = "rochedoornink@example.com",
                    Name = "Roché Doornink",
                    FirstName = "Roché",
                    LastName = "Doornink",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "31",
                    UserName = "yuenboertien",
                    NormalizedUserName = "yuenboertien",
                    Email = "yuenboertien@example.com",
                    NormalizedEmail = "yuenboertien@example.com",
                    Name = "Yuen Boertien",
                    FirstName = "Yuen",
                    LastName = "Boertien",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "32",
                    UserName = "heinrichmook",
                    NormalizedUserName = "heinrichmook",
                    Email = "heinrichmook@example.com",
                    NormalizedEmail = "heinrichmook@example.com",
                    Name = "Heinrich Mook",
                    FirstName = "Heinrich",
                    LastName = "Mook",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "33",
                    UserName = "keriantonisse",
                    NormalizedUserName = "keriantonisse",
                    Email = "keriantonisse@example.com",
                    NormalizedEmail = "keriantonisse@example.com",
                    Name = "Keri Antonisse",
                    FirstName = "Keri",
                    LastName = "Antonisse",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "34",
                    UserName = "beerrebergen",
                    NormalizedUserName = "beerrebergen",
                    Email = "beerrebergen@example.com",
                    NormalizedEmail = "beerrebergen@example.com",
                    Name = "Beer Rebergen",
                    FirstName = "Beer",
                    LastName = "Rebergen",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "35",
                    UserName = "kainvandergun",
                    NormalizedUserName = "kainvandergun",
                    Email = "kainvandergun@example.com",
                    NormalizedEmail = "kainvandergun@example.com",
                    Name = "Kaïn Van der Gun",
                    FirstName = "Kaïn",
                    LastName = "Van der Gun",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "36",
                    UserName = "marloeswesterdijk",
                    NormalizedUserName = "marloeswesterdijk",
                    Email = "marloeswesterdijk@example.com",
                    NormalizedEmail = "marloeswesterdijk@example.com",
                    Name = "Marloes Westerdijk",
                    FirstName = "Marloes",
                    LastName = "Westerdijk",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "37",
                    UserName = "aurelieesajas",
                    NormalizedUserName = "aurelieesajas",
                    Email = "aurelieesajas@example.com",
                    NormalizedEmail = "aurelieesajas@example.com",
                    Name = "Aurélie Esajas",
                    FirstName = "Aurélie",
                    LastName = "Esajas",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "38",
                    UserName = "gerlindenooijens",
                    NormalizedUserName = "gerlindenooijens",
                    Email = "gerlindenooijens@example.com",
                    NormalizedEmail = "gerlindenooijens@example.com",
                    Name = "Gerlinde Nooijens",
                    FirstName = "Gerlinde",
                    LastName = "Nooijens",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "39",
                    UserName = "summerbrinkhuis",
                    NormalizedUserName = "summerbrinkhuis",
                    Email = "summerbrinkhuis@example.com",
                    NormalizedEmail = "summerbrinkhuis@example.com",
                    Name = "Summer Brinkhuis",
                    FirstName = "Summer",
                    LastName = "Brinkhuis",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "40",
                    UserName = "quirinavandusschoten",
                    NormalizedUserName = "quirinavandusschoten",
                    Email = "quirinavandusschoten@example.com",
                    NormalizedEmail = "quirinavandusschoten@example.com",
                    Name = "Quirina Van Dusschoten",
                    FirstName = "Quirina",
                    LastName = "Van Dusschoten",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "41",
                    UserName = "emmelienhandels",
                    NormalizedUserName = "emmelienhandels",
                    Email = "emmelienhandels@example.com",
                    NormalizedEmail = "emmelienhandels@example.com",
                    Name = "Emmelien Handels",
                    FirstName = "Emmelien",
                    LastName = "Handels",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "42",
                    UserName = "wensleycurvers",
                    NormalizedUserName = "wensleycurvers",
                    Email = "wensleycurvers@example.com",
                    NormalizedEmail = "wensleycurvers@example.com",
                    Name = "Wensley Curvers",
                    FirstName = "Wensley",
                    LastName = "Curvers",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = "43",
                    UserName = "dawidvanaart",
                    NormalizedUserName = "dawidvanaart",
                    Email = "dawidvanaart@example.com",
                    NormalizedEmail = "dawidvanaart@example.com",
                    Name = "Dawid Van Aart",
                    FirstName = "Dawid",
                    LastName = "Van Aart",
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
                new { UserId = "1", RoleId = 1 },
                new { UserId = "2", RoleId = 3 },
                new { UserId = "2", RoleId = 4 },
                new { UserId = "3", RoleId = 3 },
                new { UserId = "3", RoleId = 4 },
                new { UserId = "4", RoleId = 2 },
                new { UserId = "5", RoleId = 2 },
                new { UserId = "6", RoleId = 2 },
                new { UserId = "7", RoleId = 2 },
                new { UserId = "8", RoleId = 2 },
                new { UserId = "9", RoleId = 2 },
                new { UserId = "10", RoleId = 2 },
                new { UserId = "11", RoleId = 2 },
                new { UserId = "12", RoleId = 2 },
                new { UserId = "13", RoleId = 2 },
                new { UserId = "14", RoleId = 2 },
                new { UserId = "15", RoleId = 2 },
                new { UserId = "16", RoleId = 2 },
                new { UserId = "17", RoleId = 2 },
                new { UserId = "18", RoleId = 2 },
                new { UserId = "19", RoleId = 2 },
                new { UserId = "20", RoleId = 2 },
                new { UserId = "21", RoleId = 2 },
                new { UserId = "22", RoleId = 2 },
                new { UserId = "23", RoleId = 2 },
                new { UserId = "24", RoleId = 2 },
                new { UserId = "25", RoleId = 2 },
                new { UserId = "26", RoleId = 2 },
                new { UserId = "27", RoleId = 2 },
                new { UserId = "28", RoleId = 2 },
                new { UserId = "29", RoleId = 2 },
                new { UserId = "30", RoleId = 2 },
                new { UserId = "31", RoleId = 2 },
                new { UserId = "32", RoleId = 2 },
                new { UserId = "33", RoleId = 2 },
                new { UserId = "34", RoleId = 2 },
                new { UserId = "35", RoleId = 2 },
                new { UserId = "36", RoleId = 2 },
                new { UserId = "37", RoleId = 2 },
                new { UserId = "38", RoleId = 2 },
                new { UserId = "39", RoleId = 2 },
                new { UserId = "40", RoleId = 2 },
                new { UserId = "41", RoleId = 2 },
                new { UserId = "42", RoleId = 2 },
                new { UserId = "43", RoleId = 2 }
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
