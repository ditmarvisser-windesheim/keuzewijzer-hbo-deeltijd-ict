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

            modelBuilder.Entity<User>()
                .HasMany(u => u.Students)
                .WithOne(u => u.Mentor)
                .HasForeignKey(u => u.MentorId);


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
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId= "2",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "2",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "2",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "2",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "2",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "2",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "2",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "2",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "2",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "2",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "2",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "2",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "2",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "2",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "2",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "2",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "2",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "2",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "2",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "2",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "3",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "3",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "3",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "3",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "3",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "3",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "3",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "3",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "3",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "3",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "3",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "3",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "3",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "3",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "3",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "3",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "3",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "3",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "3",
                    SecurityStamp = Guid.NewGuid().ToString(),
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
                    MentorId = "3",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }
            );

            modelBuilder.Entity<StudyRoute>().HasData(
                new StudyRoute { Id = 4, Send_sb = true, Approved_sb = null, Send_eb = null, Approved_eb = null, UserId = "4" },
                new StudyRoute { Id = 5, Send_sb = true, Approved_sb = null, Send_eb = null, Approved_eb = null, UserId = "5" },
                new StudyRoute { Id = 6, Send_sb = false, Approved_sb = null, Send_eb = null, Approved_eb = null, UserId = "6" },
                new StudyRoute { Id = 7, Send_sb = false, Approved_sb = null, Send_eb = null, Approved_eb = null, UserId = "7" },
                new StudyRoute { Id = 8, Send_sb = false, Approved_sb = null, Send_eb = null, Approved_eb = null, UserId = "8" },
                new StudyRoute { Id = 9, Send_sb = true, Approved_sb = null, Send_eb = null, Approved_eb = null, UserId = "9" },
                new StudyRoute { Id = 10, Send_sb = false, Approved_sb = null, Send_eb = null, Approved_eb = null, UserId = "10" },
                new StudyRoute { Id = 11, Send_sb = true, Approved_sb = null, Send_eb = null, Approved_eb = null, UserId = "11" },
                new StudyRoute { Id = 12, Send_sb = true, Approved_sb = true, Send_eb = true, Approved_eb = false, UserId = "12" },
                new StudyRoute { Id = 13, Send_sb = false, Approved_sb = null, Send_eb = null, Approved_eb = null, UserId = "13" },
                new StudyRoute { Id = 14, Send_sb = true, Approved_sb = false, Send_eb = false, Approved_eb = null, UserId = "14" },
                new StudyRoute { Id = 15, Send_sb = false, Approved_sb = null, Send_eb = null, Approved_eb = null, UserId = "15" },
                new StudyRoute { Id = 16, Send_sb = false, Approved_sb = null, Send_eb = null, Approved_eb = null, UserId = "16" },
                new StudyRoute { Id = 17, Send_sb = true, Approved_sb = false, Send_eb = false, Approved_eb = null, UserId = "17" },
                new StudyRoute { Id = 18, Send_sb = false, Approved_sb = null, Send_eb = null, Approved_eb = null, UserId = "18" },
                new StudyRoute { Id = 19, Send_sb = false, Approved_sb = null, Send_eb = null, Approved_eb = null, UserId = "19" },
                new StudyRoute { Id = 20, Send_sb = false, Approved_sb = null, Send_eb = null, Approved_eb = null, UserId = "20" },
                new StudyRoute { Id = 21, Send_sb = true, Approved_sb = false, Send_eb = false, Approved_eb = null, UserId = "21" },
                new StudyRoute { Id = 22, Send_sb = true, Approved_sb = null, Send_eb = null, Approved_eb = null, UserId = "22" },
                new StudyRoute { Id = 23, Send_sb = false, Approved_sb = null, Send_eb = null, Approved_eb = null, UserId = "23" },
                new StudyRoute { Id = 24, Send_sb = true, Approved_sb = true, Send_eb = true, Approved_eb = false, UserId = "24" },
                new StudyRoute { Id = 25, Send_sb = false, Approved_sb = null, Send_eb = null, Approved_eb = null, UserId = "25" },
                new StudyRoute { Id = 26, Send_sb = false, Approved_sb = null, Send_eb = null, Approved_eb = null, UserId = "26" },
                new StudyRoute { Id = 27, Send_sb = false, Approved_sb = null, Send_eb = null, Approved_eb = null, UserId = "27" },
                new StudyRoute { Id = 28, Send_sb = false, Approved_sb = null, Send_eb = null, Approved_eb = null, UserId = "28" },
                new StudyRoute { Id = 29, Send_sb = false, Approved_sb = null, Send_eb = null, Approved_eb = null, UserId = "29" },
                new StudyRoute { Id = 30, Send_sb = false, Approved_sb = null, Send_eb = null, Approved_eb = null, UserId = "30" },
                new StudyRoute { Id = 31, Send_sb = false, Approved_sb = null, Send_eb = null, Approved_eb = null, UserId = "31" },
                new StudyRoute { Id = 32, Send_sb = false, Approved_sb = null, Send_eb = null, Approved_eb = null, UserId = "32" },
                new StudyRoute { Id = 33, Send_sb = true, Approved_sb = false, Send_eb = false, Approved_eb = null, UserId = "33" },
                new StudyRoute { Id = 34, Send_sb = false, Approved_sb = null, Send_eb = null, Approved_eb = null, UserId = "34" },
                new StudyRoute { Id = 35, Send_sb = true, Approved_sb = null, Send_eb = null, Approved_eb = null, UserId = "35" },
                new StudyRoute { Id = 36, Send_sb = false, Approved_sb = null, Send_eb = null, Approved_eb = null, UserId = "36" },
                new StudyRoute { Id = 37, Send_sb = true, Approved_sb = null, Send_eb = null, Approved_eb = null, UserId = "37" },
                new StudyRoute { Id = 38, Send_sb = false, Approved_sb = null, Send_eb = null, Approved_eb = null, UserId = "38" },
                new StudyRoute { Id = 39, Send_sb = false, Approved_sb = null, Send_eb = null, Approved_eb = null, UserId = "39" },
                new StudyRoute { Id = 40, Send_sb = true, Approved_sb = true, Send_eb = true, Approved_eb = false, UserId = "40" },
                new StudyRoute { Id = 41, Send_sb = true, Approved_sb = null, Send_eb = null, Approved_eb = null, UserId = "41" },
                new StudyRoute { Id = 42, Send_sb = true, Approved_sb = false, Send_eb = false, Approved_eb = null, UserId = "42" },
                new StudyRoute { Id = 43, Send_sb = true, Approved_sb = null, Send_eb = null, Approved_eb = null, UserId = "43" }
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
                 },
                 new SemesterItem
                 {
                     Id = 999,
                     Name = "Reparatiesemester",
                     Description = "Reparatiesemester",
                     Year = new List<int> { 1,2 },
                     Semester = 1,
                     RequiredSemesterItem = new List<SemesterItem>(),
                     DependentSemesterItem = new List<SemesterItem>()
                 }
             );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new { UserId = "1", RoleId = "1" },
                new { UserId = "2", RoleId = "3" },
                new { UserId = "2", RoleId = "4" },
                new { UserId = "3", RoleId = "3" },
                new { UserId = "3", RoleId = "4" },
                new { UserId = "4", RoleId = "2" },
                new { UserId = "5", RoleId = "2" },
                new { UserId = "6", RoleId = "2" },
                new { UserId = "7", RoleId = "2" },
                new { UserId = "8", RoleId = "2" },
                new { UserId = "9", RoleId = "2" },
                new { UserId = "10", RoleId = "2" },
                new { UserId = "11", RoleId = "2" },
                new { UserId = "12", RoleId = "2" },
                new { UserId = "13", RoleId = "2" },
                new { UserId = "14", RoleId = "2" },
                new { UserId = "15", RoleId = "2" },
                new { UserId = "16", RoleId = "2" },
                new { UserId = "17", RoleId = "2" },
                new { UserId = "18", RoleId = "2" },
                new { UserId = "19", RoleId = "2" },
                new { UserId = "20", RoleId = "2" },
                new { UserId = "21", RoleId = "2" },
                new { UserId = "22", RoleId = "2" },
                new { UserId = "23", RoleId = "2" },
                new { UserId = "24", RoleId = "2" },
                new { UserId = "25", RoleId = "2" },
                new { UserId = "26", RoleId = "2" },
                new { UserId = "27", RoleId = "2" },
                new { UserId = "28", RoleId = "2" },
                new { UserId = "29", RoleId = "2" },
                new { UserId = "30", RoleId = "2" },
                new { UserId = "31", RoleId = "2" },
                new { UserId = "32", RoleId = "2" },
                new { UserId = "33", RoleId = "2" },
                new { UserId = "34", RoleId = "2" },
                new { UserId = "35", RoleId = "2" },
                new { UserId = "36", RoleId = "2" },
                new { UserId = "37", RoleId = "2" },
                new { UserId = "38", RoleId = "2" },
                new { UserId = "39", RoleId = "2" },
                new { UserId = "40", RoleId = "2" },
                new { UserId = "41", RoleId = "2" },
                new { UserId = "42", RoleId = "2" },
                new { UserId = "43", RoleId = "2" }
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
                        new { CohortsId = 4, SemesterItemsId = 8 },
                        new { CohortsId = 4, SemesterItemsId = 999 }
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
                new StudyRouteItem { Id = 1, Year = 1, Semester = 1, StudyRouteId = 4, SemesterItemId = 2 },
                new StudyRouteItem { Id = 2, Year = 1, Semester = 2, StudyRouteId = 4, SemesterItemId = 5 },
                new StudyRouteItem { Id = 3, Year = 2, Semester = 1, StudyRouteId = 4, SemesterItemId = 1 },
                new StudyRouteItem { Id = 4, Year = 2, Semester = 2, StudyRouteId = 4, SemesterItemId = 4 },
                new StudyRouteItem { Id = 5, Year = 1, Semester = 1, StudyRouteId = 5, SemesterItemId = 1 },
                new StudyRouteItem { Id = 6, Year = 1, Semester = 2, StudyRouteId = 5, SemesterItemId = 5 },
                new StudyRouteItem { Id = 7, Year = 1, Semester = 1, StudyRouteId = 6, SemesterItemId = 6 },
                new StudyRouteItem { Id = 8, Year = 1, Semester = 2, StudyRouteId = 6, SemesterItemId = 8 },
                new StudyRouteItem { Id = 9, Year = 2, Semester = 1, StudyRouteId = 6, SemesterItemId = 4 },
                new StudyRouteItem { Id = 10, Year = 2, Semester = 2, StudyRouteId = 6, SemesterItemId = 2 },
                new StudyRouteItem { Id = 11, Year = 1, Semester = 1, StudyRouteId = 7, SemesterItemId = 8 },
                new StudyRouteItem { Id = 12, Year = 1, Semester = 2, StudyRouteId = 7, SemesterItemId = 1 },
                new StudyRouteItem { Id = 13, Year = 1, Semester = 1, StudyRouteId = 8, SemesterItemId = 5 },
                new StudyRouteItem { Id = 14, Year = 1, Semester = 2, StudyRouteId = 8, SemesterItemId = 6 },
                new StudyRouteItem { Id = 15, Year = 1, Semester = 1, StudyRouteId = 9, SemesterItemId = 4 },
                new StudyRouteItem { Id = 16, Year = 1, Semester = 2, StudyRouteId = 9, SemesterItemId = 5 },
                new StudyRouteItem { Id = 17, Year = 2, Semester = 1, StudyRouteId = 9, SemesterItemId = 6 },
                new StudyRouteItem { Id = 18, Year = 2, Semester = 2, StudyRouteId = 9, SemesterItemId = 8 },
                new StudyRouteItem { Id = 19, Year = 1, Semester = 1, StudyRouteId = 10, SemesterItemId = 3 },
                new StudyRouteItem { Id = 20, Year = 1, Semester = 2, StudyRouteId = 10, SemesterItemId = 7 },
                new StudyRouteItem { Id = 21, Year = 2, Semester = 1, StudyRouteId = 10, SemesterItemId = 5 },
                new StudyRouteItem { Id = 22, Year = 2, Semester = 2, StudyRouteId = 10, SemesterItemId = 6 },
                new StudyRouteItem { Id = 23, Year = 3, Semester = 1, StudyRouteId = 10, SemesterItemId = 8 },
                new StudyRouteItem { Id = 24, Year = 3, Semester = 2, StudyRouteId = 10, SemesterItemId = 4 },
                new StudyRouteItem { Id = 25, Year = 1, Semester = 1, StudyRouteId = 11, SemesterItemId = 3 },
                new StudyRouteItem { Id = 26, Year = 1, Semester = 2, StudyRouteId = 11, SemesterItemId = 8 },
                new StudyRouteItem { Id = 27, Year = 2, Semester = 1, StudyRouteId = 11, SemesterItemId = 5 },
                new StudyRouteItem { Id = 28, Year = 1, Semester = 1, StudyRouteId = 12, SemesterItemId = 7 },
                new StudyRouteItem { Id = 29, Year = 1, Semester = 2, StudyRouteId = 12, SemesterItemId = 1 },
                new StudyRouteItem { Id = 30, Year = 2, Semester = 1, StudyRouteId = 12, SemesterItemId = 3 },
                new StudyRouteItem { Id = 31, Year = 2, Semester = 2, StudyRouteId = 12, SemesterItemId = 2 },
                new StudyRouteItem { Id = 32, Year = 3, Semester = 1, StudyRouteId = 12, SemesterItemId = 5 },
                new StudyRouteItem { Id = 33, Year = 1, Semester = 1, StudyRouteId = 13, SemesterItemId = 2 },
                new StudyRouteItem { Id = 34, Year = 1, Semester = 2, StudyRouteId = 13, SemesterItemId = 7 },
                new StudyRouteItem { Id = 35, Year = 2, Semester = 1, StudyRouteId = 13, SemesterItemId = 5 },
                new StudyRouteItem { Id = 36, Year = 2, Semester = 2, StudyRouteId = 13, SemesterItemId = 8 },
                new StudyRouteItem { Id = 37, Year = 3, Semester = 1, StudyRouteId = 13, SemesterItemId = 3 },
                new StudyRouteItem { Id = 38, Year = 3, Semester = 2, StudyRouteId = 13, SemesterItemId = 6 },
                new StudyRouteItem { Id = 39, Year = 1, Semester = 1, StudyRouteId = 14, SemesterItemId = 6 },
                new StudyRouteItem { Id = 40, Year = 1, Semester = 2, StudyRouteId = 14, SemesterItemId = 3 },
                new StudyRouteItem { Id = 41, Year = 1, Semester = 1, StudyRouteId = 15, SemesterItemId = 6 },
                new StudyRouteItem { Id = 42, Year = 1, Semester = 2, StudyRouteId = 15, SemesterItemId = 8 },
                new StudyRouteItem { Id = 43, Year = 2, Semester = 1, StudyRouteId = 15, SemesterItemId = 1 },
                new StudyRouteItem { Id = 44, Year = 2, Semester = 2, StudyRouteId = 15, SemesterItemId = 4 },
                new StudyRouteItem { Id = 45, Year = 3, Semester = 1, StudyRouteId = 15, SemesterItemId = 2 },
                new StudyRouteItem { Id = 46, Year = 3, Semester = 2, StudyRouteId = 15, SemesterItemId = 3 },
                new StudyRouteItem { Id = 47, Year = 4, Semester = 1, StudyRouteId = 15, SemesterItemId = 7 },
                new StudyRouteItem { Id = 48, Year = 1, Semester = 1, StudyRouteId = 16, SemesterItemId = 6 },
                new StudyRouteItem { Id = 49, Year = 1, Semester = 2, StudyRouteId = 16, SemesterItemId = 5 },
                new StudyRouteItem { Id = 50, Year = 2, Semester = 1, StudyRouteId = 16, SemesterItemId = 7 },
                new StudyRouteItem { Id = 51, Year = 2, Semester = 2, StudyRouteId = 16, SemesterItemId = 3 },
                new StudyRouteItem { Id = 52, Year = 1, Semester = 1, StudyRouteId = 17, SemesterItemId = 1 },
                new StudyRouteItem { Id = 53, Year = 1, Semester = 2, StudyRouteId = 17, SemesterItemId = 8 },
                new StudyRouteItem { Id = 54, Year = 1, Semester = 1, StudyRouteId = 18, SemesterItemId = 5 },
                new StudyRouteItem { Id = 55, Year = 1, Semester = 2, StudyRouteId = 18, SemesterItemId = 8 },
                new StudyRouteItem { Id = 56, Year = 2, Semester = 1, StudyRouteId = 18, SemesterItemId = 2 },
                new StudyRouteItem { Id = 57, Year = 1, Semester = 1, StudyRouteId = 19, SemesterItemId = 5 },
                new StudyRouteItem { Id = 58, Year = 1, Semester = 2, StudyRouteId = 19, SemesterItemId = 3 },
                new StudyRouteItem { Id = 59, Year = 2, Semester = 1, StudyRouteId = 19, SemesterItemId = 7 },
                new StudyRouteItem { Id = 60, Year = 2, Semester = 2, StudyRouteId = 19, SemesterItemId = 2 },
                new StudyRouteItem { Id = 61, Year = 3, Semester = 1, StudyRouteId = 19, SemesterItemId = 4 },
                new StudyRouteItem { Id = 62, Year = 3, Semester = 2, StudyRouteId = 19, SemesterItemId = 6 },
                new StudyRouteItem { Id = 63, Year = 1, Semester = 1, StudyRouteId = 20, SemesterItemId = 8 },
                new StudyRouteItem { Id = 64, Year = 1, Semester = 2, StudyRouteId = 20, SemesterItemId = 5 },
                new StudyRouteItem { Id = 65, Year = 2, Semester = 1, StudyRouteId = 20, SemesterItemId = 2 },
                new StudyRouteItem { Id = 66, Year = 2, Semester = 2, StudyRouteId = 20, SemesterItemId = 3 },
                new StudyRouteItem { Id = 67, Year = 3, Semester = 1, StudyRouteId = 20, SemesterItemId = 6 },
                new StudyRouteItem { Id = 68, Year = 3, Semester = 2, StudyRouteId = 20, SemesterItemId = 4 },
                new StudyRouteItem { Id = 69, Year = 1, Semester = 1, StudyRouteId = 21, SemesterItemId = 4 },
                new StudyRouteItem { Id = 70, Year = 1, Semester = 2, StudyRouteId = 21, SemesterItemId = 6 },
                new StudyRouteItem { Id = 71, Year = 2, Semester = 1, StudyRouteId = 21, SemesterItemId = 1 },
                new StudyRouteItem { Id = 72, Year = 1, Semester = 1, StudyRouteId = 22, SemesterItemId = 6 },
                new StudyRouteItem { Id = 73, Year = 1, Semester = 2, StudyRouteId = 22, SemesterItemId = 4 },
                new StudyRouteItem { Id = 74, Year = 2, Semester = 1, StudyRouteId = 22, SemesterItemId = 7 },
                new StudyRouteItem { Id = 75, Year = 2, Semester = 2, StudyRouteId = 22, SemesterItemId = 3 },
                new StudyRouteItem { Id = 76, Year = 3, Semester = 1, StudyRouteId = 22, SemesterItemId = 5 },
                new StudyRouteItem { Id = 77, Year = 1, Semester = 1, StudyRouteId = 23, SemesterItemId = 3 },
                new StudyRouteItem { Id = 78, Year = 1, Semester = 2, StudyRouteId = 23, SemesterItemId = 4 },
                new StudyRouteItem { Id = 79, Year = 2, Semester = 1, StudyRouteId = 23, SemesterItemId = 1 },
                new StudyRouteItem { Id = 80, Year = 1, Semester = 1, StudyRouteId = 24, SemesterItemId = 8 },
                new StudyRouteItem { Id = 81, Year = 1, Semester = 2, StudyRouteId = 24, SemesterItemId = 2 },
                new StudyRouteItem { Id = 82, Year = 1, Semester = 1, StudyRouteId = 25, SemesterItemId = 6 },
                new StudyRouteItem { Id = 83, Year = 1, Semester = 2, StudyRouteId = 25, SemesterItemId = 5 },
                new StudyRouteItem { Id = 84, Year = 1, Semester = 1, StudyRouteId = 26, SemesterItemId = 7 },
                new StudyRouteItem { Id = 85, Year = 1, Semester = 2, StudyRouteId = 26, SemesterItemId = 8 },
                new StudyRouteItem { Id = 86, Year = 2, Semester = 1, StudyRouteId = 26, SemesterItemId = 4 },
                new StudyRouteItem { Id = 87, Year = 2, Semester = 2, StudyRouteId = 26, SemesterItemId = 1 },
                new StudyRouteItem { Id = 88, Year = 3, Semester = 1, StudyRouteId = 26, SemesterItemId = 5 },
                new StudyRouteItem { Id = 89, Year = 1, Semester = 1, StudyRouteId = 27, SemesterItemId = 1 },
                new StudyRouteItem { Id = 90, Year = 1, Semester = 2, StudyRouteId = 27, SemesterItemId = 8 },
                new StudyRouteItem { Id = 91, Year = 1, Semester = 1, StudyRouteId = 28, SemesterItemId = 7 },
                new StudyRouteItem { Id = 92, Year = 1, Semester = 2, StudyRouteId = 28, SemesterItemId = 6 },
                new StudyRouteItem { Id = 93, Year = 2, Semester = 1, StudyRouteId = 28, SemesterItemId = 5 },
                new StudyRouteItem { Id = 94, Year = 1, Semester = 1, StudyRouteId = 29, SemesterItemId = 1 },
                new StudyRouteItem { Id = 95, Year = 1, Semester = 2, StudyRouteId = 29, SemesterItemId = 2 },
                new StudyRouteItem { Id = 96, Year = 2, Semester = 1, StudyRouteId = 29, SemesterItemId = 3 },
                new StudyRouteItem { Id = 97, Year = 2, Semester = 2, StudyRouteId = 29, SemesterItemId = 8 },
                new StudyRouteItem { Id = 98, Year = 3, Semester = 1, StudyRouteId = 29, SemesterItemId = 6 },
                new StudyRouteItem { Id = 99, Year = 3, Semester = 2, StudyRouteId = 29, SemesterItemId = 7 },
                new StudyRouteItem { Id = 100, Year = 1, Semester = 1, StudyRouteId = 30, SemesterItemId = 6 },
                new StudyRouteItem { Id = 101, Year = 1, Semester = 2, StudyRouteId = 30, SemesterItemId = 3 },
                new StudyRouteItem { Id = 102, Year = 2, Semester = 1, StudyRouteId = 30, SemesterItemId = 4 },
                new StudyRouteItem { Id = 103, Year = 2, Semester = 2, StudyRouteId = 30, SemesterItemId = 1 },
                new StudyRouteItem { Id = 104, Year = 3, Semester = 1, StudyRouteId = 30, SemesterItemId = 2 },
                new StudyRouteItem { Id = 105, Year = 3, Semester = 2, StudyRouteId = 30, SemesterItemId = 7 },
                new StudyRouteItem { Id = 106, Year = 4, Semester = 1, StudyRouteId = 30, SemesterItemId = 5 },
                new StudyRouteItem { Id = 107, Year = 1, Semester = 1, StudyRouteId = 31, SemesterItemId = 6 },
                new StudyRouteItem { Id = 108, Year = 1, Semester = 2, StudyRouteId = 31, SemesterItemId = 1 },
                new StudyRouteItem { Id = 109, Year = 2, Semester = 1, StudyRouteId = 31, SemesterItemId = 4 },
                new StudyRouteItem { Id = 110, Year = 2, Semester = 2, StudyRouteId = 31, SemesterItemId = 2 },
                new StudyRouteItem { Id = 111, Year = 1, Semester = 1, StudyRouteId = 32, SemesterItemId = 8 },
                new StudyRouteItem { Id = 112, Year = 1, Semester = 2, StudyRouteId = 32, SemesterItemId = 4 },
                new StudyRouteItem { Id = 113, Year = 2, Semester = 1, StudyRouteId = 32, SemesterItemId = 1 },
                new StudyRouteItem { Id = 114, Year = 2, Semester = 2, StudyRouteId = 32, SemesterItemId = 2 },
                new StudyRouteItem { Id = 115, Year = 3, Semester = 1, StudyRouteId = 32, SemesterItemId = 5 },
                new StudyRouteItem { Id = 116, Year = 3, Semester = 2, StudyRouteId = 32, SemesterItemId = 3 },
                new StudyRouteItem { Id = 117, Year = 4, Semester = 1, StudyRouteId = 32, SemesterItemId = 7 },
                new StudyRouteItem { Id = 118, Year = 1, Semester = 1, StudyRouteId = 33, SemesterItemId = 3 },
                new StudyRouteItem { Id = 119, Year = 1, Semester = 2, StudyRouteId = 33, SemesterItemId = 6 },
                new StudyRouteItem { Id = 120, Year = 2, Semester = 1, StudyRouteId = 33, SemesterItemId = 4 },
                new StudyRouteItem { Id = 121, Year = 2, Semester = 2, StudyRouteId = 33, SemesterItemId = 5 },
                new StudyRouteItem { Id = 122, Year = 1, Semester = 1, StudyRouteId = 34, SemesterItemId = 5 },
                new StudyRouteItem { Id = 123, Year = 1, Semester = 2, StudyRouteId = 34, SemesterItemId = 7 },
                new StudyRouteItem { Id = 124, Year = 2, Semester = 1, StudyRouteId = 34, SemesterItemId = 1 },
                new StudyRouteItem { Id = 125, Year = 2, Semester = 2, StudyRouteId = 34, SemesterItemId = 4 },
                new StudyRouteItem { Id = 126, Year = 3, Semester = 1, StudyRouteId = 34, SemesterItemId = 6 },
                new StudyRouteItem { Id = 127, Year = 3, Semester = 2, StudyRouteId = 34, SemesterItemId = 2 },
                new StudyRouteItem { Id = 128, Year = 4, Semester = 1, StudyRouteId = 34, SemesterItemId = 8 },
                new StudyRouteItem { Id = 129, Year = 1, Semester = 1, StudyRouteId = 35, SemesterItemId = 6 },
                new StudyRouteItem { Id = 130, Year = 1, Semester = 2, StudyRouteId = 35, SemesterItemId = 4 },
                new StudyRouteItem { Id = 131, Year = 2, Semester = 1, StudyRouteId = 35, SemesterItemId = 5 },
                new StudyRouteItem { Id = 132, Year = 1, Semester = 1, StudyRouteId = 36, SemesterItemId = 4 },
                new StudyRouteItem { Id = 133, Year = 1, Semester = 2, StudyRouteId = 36, SemesterItemId = 1 },
                new StudyRouteItem { Id = 134, Year = 1, Semester = 1, StudyRouteId = 37, SemesterItemId = 8 },
                new StudyRouteItem { Id = 135, Year = 1, Semester = 2, StudyRouteId = 37, SemesterItemId = 5 },
                new StudyRouteItem { Id = 136, Year = 2, Semester = 1, StudyRouteId = 37, SemesterItemId = 1 },
                new StudyRouteItem { Id = 137, Year = 2, Semester = 2, StudyRouteId = 37, SemesterItemId = 3 },
                new StudyRouteItem { Id = 138, Year = 3, Semester = 1, StudyRouteId = 37, SemesterItemId = 2 },
                new StudyRouteItem { Id = 139, Year = 3, Semester = 2, StudyRouteId = 37, SemesterItemId = 7 },
                new StudyRouteItem { Id = 140, Year = 4, Semester = 1, StudyRouteId = 37, SemesterItemId = 4 },
                new StudyRouteItem { Id = 141, Year = 1, Semester = 1, StudyRouteId = 38, SemesterItemId = 1 },
                new StudyRouteItem { Id = 142, Year = 1, Semester = 2, StudyRouteId = 38, SemesterItemId = 4 },
                new StudyRouteItem { Id = 143, Year = 2, Semester = 1, StudyRouteId = 38, SemesterItemId = 5 },
                new StudyRouteItem { Id = 144, Year = 1, Semester = 1, StudyRouteId = 39, SemesterItemId = 6 },
                new StudyRouteItem { Id = 145, Year = 1, Semester = 2, StudyRouteId = 39, SemesterItemId = 5 },
                new StudyRouteItem { Id = 146, Year = 2, Semester = 1, StudyRouteId = 39, SemesterItemId = 2 },
                new StudyRouteItem { Id = 147, Year = 2, Semester = 2, StudyRouteId = 39, SemesterItemId = 3 },
                new StudyRouteItem { Id = 148, Year = 3, Semester = 1, StudyRouteId = 39, SemesterItemId = 8 },
                new StudyRouteItem { Id = 149, Year = 3, Semester = 2, StudyRouteId = 39, SemesterItemId = 7 },
                new StudyRouteItem { Id = 150, Year = 4, Semester = 1, StudyRouteId = 39, SemesterItemId = 1 },
                new StudyRouteItem { Id = 151, Year = 1, Semester = 1, StudyRouteId = 40, SemesterItemId = 7 },
                new StudyRouteItem { Id = 152, Year = 1, Semester = 2, StudyRouteId = 40, SemesterItemId = 3 },
                new StudyRouteItem { Id = 153, Year = 2, Semester = 1, StudyRouteId = 40, SemesterItemId = 2 },
                new StudyRouteItem { Id = 154, Year = 1, Semester = 1, StudyRouteId = 41, SemesterItemId = 4 },
                new StudyRouteItem { Id = 155, Year = 1, Semester = 2, StudyRouteId = 41, SemesterItemId = 3 },
                new StudyRouteItem { Id = 156, Year = 2, Semester = 1, StudyRouteId = 41, SemesterItemId = 1 },
                new StudyRouteItem { Id = 157, Year = 2, Semester = 2, StudyRouteId = 41, SemesterItemId = 6 },
                new StudyRouteItem { Id = 158, Year = 3, Semester = 1, StudyRouteId = 41, SemesterItemId = 2 },
                new StudyRouteItem { Id = 159, Year = 3, Semester = 2, StudyRouteId = 41, SemesterItemId = 7 },
                new StudyRouteItem { Id = 160, Year = 1, Semester = 1, StudyRouteId = 42, SemesterItemId = 8 },
                new StudyRouteItem { Id = 161, Year = 1, Semester = 2, StudyRouteId = 42, SemesterItemId = 1 },
                new StudyRouteItem { Id = 162, Year = 2, Semester = 1, StudyRouteId = 42, SemesterItemId = 2 },
                new StudyRouteItem { Id = 163, Year = 2, Semester = 2, StudyRouteId = 42, SemesterItemId = 5 },
                new StudyRouteItem { Id = 164, Year = 3, Semester = 1, StudyRouteId = 42, SemesterItemId = 3 },
                new StudyRouteItem { Id = 165, Year = 1, Semester = 1, StudyRouteId = 43, SemesterItemId = 2 },
                new StudyRouteItem { Id = 166, Year = 1, Semester = 2, StudyRouteId = 43, SemesterItemId = 6 },
                new StudyRouteItem { Id = 167, Year = 2, Semester = 1, StudyRouteId = 43, SemesterItemId = 7 },
                new StudyRouteItem { Id = 168, Year = 2, Semester = 2, StudyRouteId = 43, SemesterItemId = 3 },
                new StudyRouteItem { Id = 169, Year = 3, Semester = 1, StudyRouteId = 43, SemesterItemId = 1 },
                new StudyRouteItem { Id = 170, Year = 3, Semester = 2, StudyRouteId = 43, SemesterItemId = 5 },
                new StudyRouteItem { Id = 171, Year = 4, Semester = 1, StudyRouteId = 43, SemesterItemId = 4 }
            );

        }
    }
}
