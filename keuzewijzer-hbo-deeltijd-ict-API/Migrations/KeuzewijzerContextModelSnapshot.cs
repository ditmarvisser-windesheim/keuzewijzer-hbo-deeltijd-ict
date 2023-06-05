// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using keuzewijzer_hbo_deeltijd_ict_API.Dal;

#nullable disable

namespace keuzewijzer_hbo_deeltijd_ict_API.Migrations
{
    [DbContext(typeof(KeuzewijzerContext))]
    partial class KeuzewijzerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CohortSemesterItem", b =>
                {
                    b.Property<int>("CohortsId")
                        .HasColumnType("int");

                    b.Property<int>("SemesterItemsId")
                        .HasColumnType("int");

                    b.HasKey("CohortsId", "SemesterItemsId");

                    b.HasIndex("SemesterItemsId");

                    b.ToTable("CohortSemesterItems", (string)null);

                    b.HasData(
                        new
                        {
                            CohortsId = 4,
                            SemesterItemsId = 1
                        },
                        new
                        {
                            CohortsId = 4,
                            SemesterItemsId = 2
                        },
                        new
                        {
                            CohortsId = 4,
                            SemesterItemsId = 3
                        },
                        new
                        {
                            CohortsId = 4,
                            SemesterItemsId = 4
                        },
                        new
                        {
                            CohortsId = 4,
                            SemesterItemsId = 5
                        },
                        new
                        {
                            CohortsId = 4,
                            SemesterItemsId = 6
                        },
                        new
                        {
                            CohortsId = 4,
                            SemesterItemsId = 7
                        },
                        new
                        {
                            CohortsId = 4,
                            SemesterItemsId = 8
                        });
                });

            modelBuilder.Entity("keuzewijzer_hbo_deeltijd_ict_API.Models.Cohort", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("Cohorts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Cohort 1",
                            Year = 2020
                        },
                        new
                        {
                            Id = 2,
                            Name = "Cohort 2",
                            Year = 2021
                        },
                        new
                        {
                            Id = 3,
                            Name = "Cohort 3",
                            Year = 2022
                        },
                        new
                        {
                            Id = 4,
                            Name = "Cohort 4",
                            Year = 2023
                        });
                });

            modelBuilder.Entity("keuzewijzer_hbo_deeltijd_ict_API.Models.Module", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ModuleLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SemesterItemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SemesterItemId");

                    b.ToTable("Modules");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Module 1",
                            SemesterItemId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Module 2",
                            SemesterItemId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Module 3",
                            SemesterItemId = 3
                        },
                        new
                        {
                            Id = 4,
                            Name = "Module 4",
                            SemesterItemId = 4
                        });
                });

            modelBuilder.Entity("keuzewijzer_hbo_deeltijd_ict_API.Models.SemesterItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Semester")
                        .HasColumnType("int");

                    b.Property<string>("YearJson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SemesterItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Description for Semester Item 1",
                            Name = "Semester Item 1",
                            Semester = 1,
                            YearJson = "[1]"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Description for Semester Item 2",
                            Name = "Semester Item 2",
                            Semester = 2,
                            YearJson = "[1]"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Description for Semester Item 3",
                            Name = "Semester Item 3",
                            Semester = 1,
                            YearJson = "[2]"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Description for Semester Item 4",
                            Name = "Semester Item 4",
                            Semester = 2,
                            YearJson = "[2]"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Description for Semester Item 5",
                            Name = "Semester Item 5",
                            Semester = 2,
                            YearJson = "[2]"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Description for Semester Item 6",
                            Name = "Semester Item 6",
                            Semester = 2,
                            YearJson = "[2]"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Description for Semester Item 7",
                            Name = "Semester Item 7",
                            Semester = 2,
                            YearJson = "[2]"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Description for Semester Item 8",
                            Name = "Semester Item 8",
                            Semester = 2,
                            YearJson = "[2]"
                        });
                });

            modelBuilder.Entity("keuzewijzer_hbo_deeltijd_ict_API.Models.StudyRoute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Approved_eb")
                        .HasColumnType("bit");

                    b.Property<bool>("Approved_sb")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Send_eb")
                        .HasColumnType("bit");

                    b.Property<bool>("Send_sb")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("StudyRoutes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Approved_eb = true,
                            Approved_sb = true,
                            Name = "Computer Science",
                            Note = "This is a note",
                            Send_eb = true,
                            Send_sb = true,
                            UserId = "1"
                        });
                });

            modelBuilder.Entity("keuzewijzer_hbo_deeltijd_ict_API.Models.StudyRouteItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Semester")
                        .HasColumnType("int");

                    b.Property<int?>("SemesterItemId")
                        .HasColumnType("int");

                    b.Property<int?>("StudyRouteId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SemesterItemId");

                    b.HasIndex("StudyRouteId");

                    b.ToTable("StudyRouteItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Semester = 1,
                            SemesterItemId = 1,
                            StudyRouteId = 1,
                            Year = 2023
                        });
                });

            modelBuilder.Entity("keuzewijzer_hbo_deeltijd_ict_API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("TimedOut")
                        .HasColumnType("datetime2");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("CohortId1");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5712bc34-bc03-41ae-95de-71fd4f26e7bc",
                            Email = "admin@example.com",
                            EmailConfirmed = false,
                            FirstName = "Arnold",
                            LastName = "Min",
                            LockoutEnabled = false,
                            Name = "Arnold Dirk Min",
                            NormalizedEmail = "admin@example.com",
                            NormalizedUserName = "admin",
                            PasswordHash = "AQAAAAEAACcQAAAAELWe4wMd2zNm6F7qHcroXPnCp8HW3ZGQxs73z9FiN6zezi1ksNcI4zMtKfEqpMJ+og==",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8a1d3cbf-0270-4acc-ad7e-1f187e422003",
                            Email = "eugenevanroden@example.com",
                            EmailConfirmed = false,
                            FirstName = "Eugene",
                            LastName = "Van Roden",
                            LockoutEnabled = false,
                            Name = "Eugene Van Roden",
                            NormalizedEmail = "eugenevanroden@example.com",
                            NormalizedUserName = "eugenevanroden",
                            PasswordHash = "AQAAAAEAACcQAAAAEFlsO3ORsSSy5EpeK9uj+H+hULGbCjW+XRMvtVV+Tfr/TJmNR6YVWpYwd9kCGf0rTw==",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "eugenevanroden"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ConcurrencyStamp = "ff36f47d-bff2-4ade-8ca0-7e35c32c0511",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "55495650-8b81-4698-bc79-c26e98b96b46",
                            Name = "Student",
                            NormalizedName = "STUDENT"
                        },
                        new
                        {
                            Id = "3",
                            ConcurrencyStamp = "e6dfc6f2-4e5d-404e-b0e0-103063a3d482",
                            Name = "Studiebegeleider",
                            NormalizedName = "STUDIEBEGELEIDER"
                        },
                        new
                        {
                            Id = "4",
                            ConcurrencyStamp = "04e2d1a4-79c3-49c8-8860-1cff0a63ca52",
                            Name = "Moduleverantwoordelijke",
                            NormalizedName = "MODULEVERANTWOORDELIJKE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "1",
                            RoleId = "1"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SemesterItemSemesterItem", b =>
                {
                    b.Property<int>("DependentSemesterItemId")
                        .HasColumnType("int");

                    b.Property<int>("RequiredSemesterItemId")
                        .HasColumnType("int");

                    b.HasKey("DependentSemesterItemId", "RequiredSemesterItemId");

                    b.HasIndex("RequiredSemesterItemId");

                    b.ToTable("SemesterItemRelationships", (string)null);

                    b.HasData(
                        new
                        {
                            DependentSemesterItemId = 2,
                            RequiredSemesterItemId = 1
                        },
                        new
                        {
                            DependentSemesterItemId = 3,
                            RequiredSemesterItemId = 2
                        },
                        new
                        {
                            DependentSemesterItemId = 4,
                            RequiredSemesterItemId = 3
                        },
                        new
                        {
                            DependentSemesterItemId = 4,
                            RequiredSemesterItemId = 1
                        });
                });

            modelBuilder.Entity("SemesterItemUser", b =>
                {
                    b.Property<int>("SemesterItemsId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("SemesterItemsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("UserSemesterItems", (string)null);
                });

            modelBuilder.Entity("CohortSemesterItem", b =>
                {
                    b.HasOne("keuzewijzer_hbo_deeltijd_ict_API.Models.Cohort", null)
                        .WithMany()
                        .HasForeignKey("CohortsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("keuzewijzer_hbo_deeltijd_ict_API.Models.SemesterItem", null)
                        .WithMany()
                        .HasForeignKey("SemesterItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("keuzewijzer_hbo_deeltijd_ict_API.Models.Cohort", b =>
                {
                    b.HasOne("keuzewijzer_hbo_deeltijd_ict_API.Models.User", null)
                        .WithOne("Cohort")
                        .HasForeignKey("keuzewijzer_hbo_deeltijd_ict_API.Models.Cohort", "UserId");
                });

            modelBuilder.Entity("keuzewijzer_hbo_deeltijd_ict_API.Models.Module", b =>
                {
                    b.HasOne("keuzewijzer_hbo_deeltijd_ict_API.Models.SemesterItem", "SemesterItem")
                        .WithMany("Modules")
                        .HasForeignKey("SemesterItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SemesterItem");
                });

            modelBuilder.Entity("keuzewijzer_hbo_deeltijd_ict_API.Models.StudyRoute", b =>
                {
                    b.HasOne("keuzewijzer_hbo_deeltijd_ict_API.Models.User", null)
                        .WithOne("StudyRoute")
                        .HasForeignKey("keuzewijzer_hbo_deeltijd_ict_API.Models.StudyRoute", "UserId");
                });

            modelBuilder.Entity("keuzewijzer_hbo_deeltijd_ict_API.Models.StudyRouteItem", b =>
                {
                    b.HasOne("keuzewijzer_hbo_deeltijd_ict_API.Models.SemesterItem", "SemesterItem")
                        .WithMany()
                        .HasForeignKey("SemesterItemId");

                    b.HasOne("keuzewijzer_hbo_deeltijd_ict_API.Models.StudyRoute", "StudyRoute")
                        .WithMany("StudyRouteItems")
                        .HasForeignKey("StudyRouteId");

                    b.Navigation("SemesterItem");

                    b.Navigation("StudyRoute");
                });

            modelBuilder.Entity("keuzewijzer_hbo_deeltijd_ict_API.Models.User", b =>
                {
                    b.HasOne("keuzewijzer_hbo_deeltijd_ict_API.Models.Cohort", "Cohort")
                        .WithMany()
                        .HasForeignKey("CohortId1");

                    b.Navigation("Cohort");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("keuzewijzer_hbo_deeltijd_ict_API.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("keuzewijzer_hbo_deeltijd_ict_API.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("keuzewijzer_hbo_deeltijd_ict_API.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("keuzewijzer_hbo_deeltijd_ict_API.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SemesterItemSemesterItem", b =>
                {
                    b.HasOne("keuzewijzer_hbo_deeltijd_ict_API.Models.SemesterItem", null)
                        .WithMany()
                        .HasForeignKey("DependentSemesterItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("keuzewijzer_hbo_deeltijd_ict_API.Models.SemesterItem", null)
                        .WithMany()
                        .HasForeignKey("RequiredSemesterItemId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SemesterItemUser", b =>
                {
                    b.HasOne("keuzewijzer_hbo_deeltijd_ict_API.Models.SemesterItem", null)
                        .WithMany()
                        .HasForeignKey("SemesterItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("keuzewijzer_hbo_deeltijd_ict_API.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SemesterItemUser", b =>
                {
                    b.HasOne("keuzewijzer_hbo_deeltijd_ict_API.Models.SemesterItem", null)
                        .WithMany()
                        .HasForeignKey("SemesterItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("keuzewijzer_hbo_deeltijd_ict_API.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("keuzewijzer_hbo_deeltijd_ict_API.Models.SemesterItem", b =>
                {
                    b.Navigation("Modules");
                });

            modelBuilder.Entity("keuzewijzer_hbo_deeltijd_ict_API.Models.StudyRoute", b =>
                {
                    b.Navigation("StudyRouteItems");
                });

            modelBuilder.Entity("keuzewijzer_hbo_deeltijd_ict_API.Models.User", b =>
                {
                    b.Navigation("StudyRoute");
                });
#pragma warning restore 612, 618
        }
    }
}
