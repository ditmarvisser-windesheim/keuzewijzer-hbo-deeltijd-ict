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
        public DbSet<Role> Roles { get; set; }

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
                .HasMany(u => u.Roles)
                .WithMany(r => r.Users)
                .UsingEntity(j =>
                {
                    j.ToTable("UserRoles");
                });


            modelBuilder.Entity<User>()
                           .HasMany(u => u.SemesterItems)
                           .WithMany(s => s.Users)
                           .UsingEntity(join => join.ToTable("UserSemesterItems"));




            // Your other configurations...
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Role>().HasData(
                new Role{Id = 1, Name = "Administrator"},
                new Role{Id = 2, Name = "Student"},
                new Role{Id = 3, Name = "Studiebegeleider"},
                new Role{Id = 4, Name = "Moduleverantwoordelijke"}
                );

            var passwordHasher = new PasswordHasher<User>();

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    UserName = "admin@example.com",
                    Email = "admin@example.com",
                    Name = "Arnold Dirk Min",
                    FirstName = "Arnold",
                    LastName = "Min",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                },
                new User
                {
                    Id = 2,
                    UserName = "eugenevanroden@example.com",
                    Email = "eugenevanroden@example.com",
                    Name = "Eugene Van Roden",
                    FirstName = "Eugene",
                    LastName = "Van Roden",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                },
                new User
                {
                    Id = 3,
                    UserName = "theotan@example.com",
                    Email = "theotan@example.com",
                    Name = "Theo Tan",
                    FirstName = "Theo",
                    LastName = "Tan",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 4,
                    UserName = "cloekras@example.com",
                    Email = "cloekras@example.com",
                    Name = "Cloé Kras",
                    FirstName = "Cloé",
                    LastName = "Kras",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 5,
                    UserName = "maurivannuland@example.com",
                    Email = "maurivannuland@example.com",
                    Name = "Mauri Van Nuland",
                    FirstName = "Mauri",
                    LastName = "Van Nuland",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 6,
                    UserName = "jeromeheerink@example.com",
                    Email = "jeromeheerink@example.com",
                    Name = "Jerome Heerink",
                    FirstName = "Jerome",
                    LastName = "Heerink",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 7,
                    UserName = "semihvanburken@example.com",
                    Email = "semihvanburken@example.com",
                    Name = "Semih Van Burken",
                    FirstName = "Semih",
                    LastName = "Van Burken",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 8,
                    UserName = "jacomijntjemoraal@example.com",
                    Email = "jacomijntjemoraal@example.com",
                    Name = "Jacomijntje Moraal",
                    FirstName = "Jacomijntje",
                    LastName = "Moraal",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 9,
                    UserName = "sjuulalma@example.com",
                    Email = "sjuulalma@example.com",
                    Name = "Sjuul Alma",
                    FirstName = "Sjuul",
                    LastName = "Alma",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 10,
                    UserName = "sharonapouw@example.com",
                    Email = "sharonapouw@example.com",
                    Name = "Sharona Pouw",
                    FirstName = "Sharona",
                    LastName = "Pouw",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 11,
                    UserName = "ashwienabbenhuis@example.com",
                    Email = "ashwienabbenhuis@example.com",
                    Name = "Ashwien Abbenhuis",
                    FirstName = "Ashwien",
                    LastName = "Abbenhuis",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 12,
                    UserName = "raulverdaasdonk@example.com",
                    Email = "raulverdaasdonk@example.com",
                    Name = "Raul Verdaasdonk",
                    FirstName = "Raul",
                    LastName = "Verdaasdonk",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 13,
                    UserName = "majellawessels@example.com",
                    Email = "majellawessels@example.com",
                    Name = "Majella Wessels",
                    FirstName = "Majella",
                    LastName = "Wessels",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 14,
                    UserName = "kwintlogtenberg@example.com",
                    Email = "kwintlogtenberg@example.com",
                    Name = "Kwint Logtenberg",
                    FirstName = "Kwint",
                    LastName = "Logtenberg",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 15,
                    UserName = "mikhaillebbink@example.com",
                    Email = "mikhaillebbink@example.com",
                    Name = "Mikhail Lebbink",
                    FirstName = "Mikhail",
                    LastName = "Lebbink",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 16,
                    UserName = "claylier@example.com",
                    Email = "claylier@example.com",
                    Name = "Clay Lier",
                    FirstName = "Clay",
                    LastName = "Lier",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 17,
                    UserName = "rubinavanderhout@example.com",
                    Email = "rubinavanderhout@example.com",
                    Name = "Rubina Van der Hout",
                    FirstName = "Rubina",
                    LastName = "Van der Hout",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 18,
                    UserName = "abderrazakblaauwbroek@example.com",
                    Email = "abderrazakblaauwbroek@example.com",
                    Name = "Abderrazak Blaauwbroek",
                    FirstName = "Abderrazak",
                    LastName = "Blaauwbroek",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 19,
                    UserName = "yannikconsten@example.com",
                    Email = "yannikconsten@example.com",
                    Name = "Yannik Consten",
                    FirstName = "Yannik",
                    LastName = "Consten",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 20,
                    UserName = "niniboekhoudt@example.com",
                    Email = "niniboekhoudt@example.com",
                    Name = "Nini Boekhoudt",
                    FirstName = "Nini",
                    LastName = "Boekhoudt",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 21,
                    UserName = "mounssifborkent@example.com",
                    Email = "mounssifborkent@example.com",
                    Name = "Mounssif Borkent",
                    FirstName = "Mounssif",
                    LastName = "Borkent",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 22,
                    UserName = "metjeknoef@example.com",
                    Email = "metjeknoef@example.com",
                    Name = "Metje Knoef",
                    FirstName = "Metje",
                    LastName = "Knoef",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 23,
                    UserName = "lolkjehagoort@example.com",
                    Email = "lolkjehagoort@example.com",
                    Name = "Lolkje Hagoort",
                    FirstName = "Lolkje",
                    LastName = "Hagoort",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 24,
                    UserName = "sabriadenissen@example.com",
                    Email = "sabriadenissen@example.com",
                    Name = "Sabria Denissen",
                    FirstName = "Sabria",
                    LastName = "Denissen",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 25,
                    UserName = "farukvanschip@example.com",
                    Email = "farukvanschip@example.com",
                    Name = "Faruk Van Schip",
                    FirstName = "Faruk",
                    LastName = "Van Schip",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 26,
                    UserName = "zakariadraaisma@example.com",
                    Email = "zakariadraaisma@example.com",
                    Name = "Zakaria Draaisma",
                    FirstName = "Zakaria",
                    LastName = "Draaisma",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 27,
                    UserName = "oguzheessels@example.com",
                    Email = "oguzheessels@example.com",
                    Name = "Oguz Heessels",
                    FirstName = "Oguz",
                    LastName = "Heessels",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 28,
                    UserName = "mariaburggraaff@example.com",
                    Email = "mariaburggraaff@example.com",
                    Name = "Maria Burggraaff",
                    FirstName = "Maria",
                    LastName = "Burggraaff",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 29,
                    UserName = "katelijnvandekoppel@example.com",
                    Email = "katelijnvandekoppel@example.com",
                    Name = "Katelijn Van de Koppel",
                    FirstName = "Katelijn",
                    LastName = "Van de Koppel",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 30,
                    UserName = "desirescheeren@example.com",
                    Email = "desirescheeren@example.com",
                    Name = "Désiré Scheeren",
                    FirstName = "Désiré",
                    LastName = "Scheeren",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 31,
                    UserName = "daxgabriel@example.com",
                    Email = "daxgabriel@example.com",
                    Name = "Dax Gabriel",
                    FirstName = "Dax",
                    LastName = "Gabriel",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 32,
                    UserName = "tommiestel@example.com",
                    Email = "tommiestel@example.com",
                    Name = "Tommie Stel",
                    FirstName = "Tommie",
                    LastName = "Stel",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 33,
                    UserName = "raphaelkoppe@example.com",
                    Email = "raphaelkoppe@example.com",
                    Name = "Raphaël Koppe",
                    FirstName = "Raphaël",
                    LastName = "Koppe",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 34,
                    UserName = "demyjongen@example.com",
                    Email = "demyjongen@example.com",
                    Name = "Demy Jongen",
                    FirstName = "Demy",
                    LastName = "Jongen",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 35,
                    UserName = "leahharreman@example.com",
                    Email = "leahharreman@example.com",
                    Name = "Leah Harreman",
                    FirstName = "Leah",
                    LastName = "Harreman",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 36,
                    UserName = "idrisskorpershoek@example.com",
                    Email = "idrisskorpershoek@example.com",
                    Name = "Idriss Korpershoek",
                    FirstName = "Idriss",
                    LastName = "Korpershoek",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 37,
                    UserName = "rashiedbleumink@example.com",
                    Email = "rashiedbleumink@example.com",
                    Name = "Rashied Bleumink",
                    FirstName = "Rashied",
                    LastName = "Bleumink",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 38,
                    UserName = "siay@example.com",
                    Email = "siay@example.com",
                    Name = "Si Ay",
                    FirstName = "Si",
                    LastName = "Ay",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 39,
                    UserName = "manolyalebens@example.com",
                    Email = "manolyalebens@example.com",
                    Name = "Manolya Lebens",
                    FirstName = "Manolya",
                    LastName = "Lebens",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 40,
                    UserName = "mateuszmachielsen@example.com",
                    Email = "mateuszmachielsen@example.com",
                    Name = "Mateusz Machielsen",
                    FirstName = "Mateusz",
                    LastName = "Machielsen",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 41,
                    UserName = "douaavandepavert@example.com",
                    Email = "douaavandepavert@example.com",
                    Name = "Douaa Van de Pavert",
                    FirstName = "Douaa",
                    LastName = "Van de Pavert",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 42,
                    UserName = "kishanhoogkamp@example.com",
                    Email = "kishanhoogkamp@example.com",
                    Name = "Kishan Hoogkamp",
                    FirstName = "Kishan",
                    LastName = "Hoogkamp",
                    PasswordHash = passwordHasher.HashPassword(null, "welkom")
                }, new User
                {
                    Id = 43,
                    UserName = "harmjanversendaal@example.com",
                    Email = "harmjanversendaal@example.com",
                    Name = "Harmjan Versendaal",
                    FirstName = "Harmjan",
                    LastName = "Versendaal",
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
                 }
             );


            modelBuilder.Entity<User>()
                .HasMany(u => u.Roles)
                .WithMany(r => r.Users)
                .UsingEntity(j =>
                {
                    j.ToTable("UserRoles");
                    j.HasData(
                        new { UsersId = 1, RolesId = 1 },
                        new { UsersId = 2, RolesId = 3 },
                        new { UsersId = 2, RolesId = 4 },
                        new { UsersId = 3, RolesId = 3 },
                        new { UsersId = 3, RolesId = 4 },
                        new { UsersId = 4, RolesId = 2 },
                        new { UsersId = 5, RolesId = 2 },
                        new { UsersId = 6, RolesId = 2 },
                        new { UsersId = 7, RolesId = 2 },
                        new { UsersId = 8, RolesId = 2 },
                        new { UsersId = 9, RolesId = 2 },
                        new { UsersId = 10, RolesId = 2 },
                        new { UsersId = 11, RolesId = 2 },
                        new { UsersId = 12, RolesId = 2 },
                        new { UsersId = 13, RolesId = 2 },
                        new { UsersId = 14, RolesId = 2 },
                        new { UsersId = 15, RolesId = 2 },
                        new { UsersId = 16, RolesId = 2 },
                        new { UsersId = 17, RolesId = 2 },
                        new { UsersId = 18, RolesId = 2 },
                        new { UsersId = 19, RolesId = 2 },
                        new { UsersId = 20, RolesId = 2 },
                        new { UsersId = 21, RolesId = 2 },
                        new { UsersId = 22, RolesId = 2 },
                        new { UsersId = 23, RolesId = 2 },
                        new { UsersId = 24, RolesId = 2 },
                        new { UsersId = 25, RolesId = 2 },
                        new { UsersId = 26, RolesId = 2 },
                        new { UsersId = 27, RolesId = 2 },
                        new { UsersId = 28, RolesId = 2 },
                        new { UsersId = 29, RolesId = 2 },
                        new { UsersId = 30, RolesId = 2 },
                        new { UsersId = 31, RolesId = 2 },
                        new { UsersId = 32, RolesId = 2 },
                        new { UsersId = 33, RolesId = 2 },
                        new { UsersId = 34, RolesId = 2 },
                        new { UsersId = 35, RolesId = 2 },
                        new { UsersId = 36, RolesId = 2 },
                        new { UsersId = 37, RolesId = 2 },
                        new { UsersId = 38, RolesId = 2 },
                        new { UsersId = 39, RolesId = 2 },
                        new { UsersId = 40, RolesId = 2 },
                        new { UsersId = 41, RolesId = 2 },
                        new { UsersId = 42, RolesId = 2 },
                        new { UsersId = 43, RolesId = 2 }
                    );
                });

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
                new StudyRouteItem { Id = 1, Year = 2023, Semester = 1, StudyRouteId = 1, SemesterItemId = 1 },
                new StudyRouteItem { Id = 2, Year = 2023, Semester = 1, StudyRouteId = 1, SemesterItemId = 2 },
                new StudyRouteItem { Id = 3, Year = 2023, Semester = 1, StudyRouteId = 1, SemesterItemId = 3 },
                new StudyRouteItem { Id = 4, Year = 2023, Semester = 1, StudyRouteId = 1, SemesterItemId = 4 }
                );

        }
    }
}
