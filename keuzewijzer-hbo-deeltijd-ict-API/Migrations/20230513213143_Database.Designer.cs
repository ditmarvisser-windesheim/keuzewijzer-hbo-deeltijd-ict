﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using keuzewijzer_hbo_deeltijd_ict_API.Dal;

#nullable disable

namespace keuzewijzer_hbo_deeltijd_ict_API.Migrations
{
    [DbContext(typeof(KeuzewijzerContext))]
    [Migration("20230513213143_Database")]
    partial class Database
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CohortModule", b =>
                {
                    b.Property<int>("CohortsId")
                        .HasColumnType("int");

                    b.Property<int>("ModulesId")
                        .HasColumnType("int");

                    b.HasKey("CohortsId", "ModulesId");

                    b.HasIndex("ModulesId");

                    b.ToTable("CohortModules", (string)null);

                    b.HasData(
                        new
                        {
                            CohortsId = 1,
                            ModulesId = 1
                        },
                        new
                        {
                            CohortsId = 1,
                            ModulesId = 2
                        },
                        new
                        {
                            CohortsId = 2,
                            ModulesId = 1
                        },
                        new
                        {
                            CohortsId = 2,
                            ModulesId = 2
                        },
                        new
                        {
                            CohortsId = 3,
                            ModulesId = 3
                        },
                        new
                        {
                            CohortsId = 3,
                            ModulesId = 4
                        },
                        new
                        {
                            CohortsId = 4,
                            ModulesId = 3
                        },
                        new
                        {
                            CohortsId = 4,
                            ModulesId = 4
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

                    b.ToTable("Cohorts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Cohort 1",
                            Year = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Cohort 2",
                            Year = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Cohort 3",
                            Year = 2
                        },
                        new
                        {
                            Id = 4,
                            Name = "Cohort 4",
                            Year = 2
                        });
                });

            modelBuilder.Entity("keuzewijzer_hbo_deeltijd_ict_API.Models.Module", b =>
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

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Modules");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Description for Module 1",
                            Name = "Module 1",
                            Semester = 1,
                            Year = 2013
                        },
                        new
                        {
                            Id = 2,
                            Description = "Description for Module 2",
                            Name = "Module 2",
                            Semester = 2,
                            Year = 2014
                        },
                        new
                        {
                            Id = 3,
                            Description = "Description for Module 3",
                            Name = "Module 3",
                            Semester = 1,
                            Year = 2015
                        },
                        new
                        {
                            Id = 4,
                            Description = "Description for Module 4",
                            Name = "Module 4",
                            Semester = 2,
                            Year = 2016
                        },
                        new
                        {
                            Id = 5,
                            Description = "Description for Module 5",
                            Name = "Module 5",
                            Semester = 1,
                            Year = 2017
                        },
                        new
                        {
                            Id = 6,
                            Description = "Description for Module 6",
                            Name = "Module 6",
                            Semester = 2,
                            Year = 2018
                        },
                        new
                        {
                            Id = 7,
                            Description = "Description for Module 7",
                            Name = "Module 7",
                            Semester = 1,
                            Year = 2019
                        },
                        new
                        {
                            Id = 8,
                            Description = "Description for Module 8",
                            Name = "Module 8",
                            Semester = 2,
                            Year = 2020
                        },
                        new
                        {
                            Id = 9,
                            Description = "Description for Module 9",
                            Name = "Module 9",
                            Semester = 1,
                            Year = 2021
                        },
                        new
                        {
                            Id = 10,
                            Description = "Description for Module 10",
                            Name = "Module 10",
                            Semester = 2,
                            Year = 2022
                        },
                        new
                        {
                            Id = 11,
                            Description = "Description for Module 11",
                            Name = "Module 11",
                            Semester = 2,
                            Year = 2023
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

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

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
                            UserId = 1
                        });
                });

            modelBuilder.Entity("keuzewijzer_hbo_deeltijd_ict_API.Models.StudyRouteItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ModuleId")
                        .HasColumnType("int");

                    b.Property<int>("Semester")
                        .HasColumnType("int");

                    b.Property<int>("StudyRouteId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ModuleId");

                    b.HasIndex("StudyRouteId");

                    b.ToTable("StudyRouteItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ModuleId = 1,
                            Semester = 1,
                            StudyRouteId = 1,
                            Year = 2023
                        },
                        new
                        {
                            Id = 2,
                            ModuleId = 2,
                            Semester = 1,
                            StudyRouteId = 1,
                            Year = 2023
                        },
                        new
                        {
                            Id = 3,
                            ModuleId = 3,
                            Semester = 1,
                            StudyRouteId = 1,
                            Year = 2023
                        },
                        new
                        {
                            Id = 4,
                            ModuleId = 4,
                            Semester = 1,
                            StudyRouteId = 1,
                            Year = 2023
                        },
                        new
                        {
                            Id = 5,
                            ModuleId = 5,
                            Semester = 1,
                            StudyRouteId = 1,
                            Year = 2023
                        },
                        new
                        {
                            Id = 6,
                            ModuleId = 6,
                            Semester = 1,
                            StudyRouteId = 1,
                            Year = 2023
                        },
                        new
                        {
                            Id = 7,
                            ModuleId = 7,
                            Semester = 1,
                            StudyRouteId = 1,
                            Year = 2023
                        },
                        new
                        {
                            Id = 8,
                            ModuleId = 8,
                            Semester = 1,
                            StudyRouteId = 1,
                            Year = 2023
                        },
                        new
                        {
                            Id = 9,
                            ModuleId = 9,
                            Semester = 2,
                            StudyRouteId = 1,
                            Year = 2023
                        },
                        new
                        {
                            Id = 10,
                            ModuleId = 10,
                            Semester = 2,
                            StudyRouteId = 1,
                            Year = 2023
                        });
                });

            modelBuilder.Entity("keuzewijzer_hbo_deeltijd_ict_API.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int?>("CohortId1")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StudyRouteId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("TimedOut")
                        .HasColumnType("datetime2");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CohortId1");

                    b.HasIndex("StudyRouteId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8f1c0471-21da-4ce7-afd9-3c45f772b670",
                            Email = "john@example.com",
                            EmailConfirmed = false,
                            FirstName = "John",
                            LastName = "Doe",
                            LockoutEnabled = false,
                            Name = "John Doe",
                            PasswordHash = "AQAAAAEAACcQAAAAENextsNiz4T+5/w2dF6BwyJCo2JnqoC6bUmpu5NsyR3h+uDF8vHhwFNkADZJmN1WWg==",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "john@example.com"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9d23031c-e838-47e7-9fa8-4a908b03ae33",
                            Email = "jane@example.com",
                            EmailConfirmed = false,
                            FirstName = "Jane",
                            LastName = "Smith",
                            LockoutEnabled = false,
                            Name = "Jane Smith",
                            PasswordHash = "AQAAAAEAACcQAAAAEL1jLISit2HaeEXJqIaUxTIQSJK0ZBQBmFnEp7JCDPD233OsD/GzDNSgs8Q4Uwl0dQ==",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "jane@example.com"
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

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

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
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

            modelBuilder.Entity("ModuleModule", b =>
                {
                    b.Property<int>("DependentModulesId")
                        .HasColumnType("int");

                    b.Property<int>("RequiredModulesId")
                        .HasColumnType("int");

                    b.HasKey("DependentModulesId", "RequiredModulesId");

                    b.HasIndex("RequiredModulesId");

                    b.ToTable("ModuleRelationships", (string)null);

                    b.HasData(
                        new
                        {
                            DependentModulesId = 2,
                            RequiredModulesId = 1
                        },
                        new
                        {
                            DependentModulesId = 3,
                            RequiredModulesId = 2
                        },
                        new
                        {
                            DependentModulesId = 4,
                            RequiredModulesId = 3
                        },
                        new
                        {
                            DependentModulesId = 4,
                            RequiredModulesId = 1
                        });
                });

            modelBuilder.Entity("CohortModule", b =>
                {
                    b.HasOne("keuzewijzer_hbo_deeltijd_ict_API.Models.Cohort", null)
                        .WithMany()
                        .HasForeignKey("CohortsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("keuzewijzer_hbo_deeltijd_ict_API.Models.Module", null)
                        .WithMany()
                        .HasForeignKey("ModulesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("keuzewijzer_hbo_deeltijd_ict_API.Models.StudyRouteItem", b =>
                {
                    b.HasOne("keuzewijzer_hbo_deeltijd_ict_API.Models.Module", "Modules")
                        .WithMany()
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("keuzewijzer_hbo_deeltijd_ict_API.Models.StudyRoute", "StudyRoute")
                        .WithMany()
                        .HasForeignKey("StudyRouteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Modules");

                    b.Navigation("StudyRoute");
                });

            modelBuilder.Entity("keuzewijzer_hbo_deeltijd_ict_API.Models.User", b =>
                {
                    b.HasOne("keuzewijzer_hbo_deeltijd_ict_API.Models.Cohort", "Cohort")
                        .WithMany()
                        .HasForeignKey("CohortId1");

                    b.HasOne("keuzewijzer_hbo_deeltijd_ict_API.Models.StudyRoute", "StudyRoute")
                        .WithMany()
                        .HasForeignKey("StudyRouteId");

                    b.Navigation("Cohort");

                    b.Navigation("StudyRoute");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ModuleModule", b =>
                {
                    b.HasOne("keuzewijzer_hbo_deeltijd_ict_API.Models.Module", null)
                        .WithMany()
                        .HasForeignKey("DependentModulesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("keuzewijzer_hbo_deeltijd_ict_API.Models.Module", null)
                        .WithMany()
                        .HasForeignKey("RequiredModulesId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}