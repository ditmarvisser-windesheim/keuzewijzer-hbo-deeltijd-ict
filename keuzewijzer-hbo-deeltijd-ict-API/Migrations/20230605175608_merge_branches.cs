using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace keuzewijzer_hbo_deeltijd_ict_API.Migrations
{
    public partial class merge_branches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cohorts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cohorts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SemesterItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Semester = table.Column<int>(type: "int", nullable: false),
                    YearJson = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SemesterItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CohortId1 = table.Column<int>(type: "int", nullable: true),
                    TimedOut = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Cohorts_CohortId1",
                        column: x => x.CohortId1,
                        principalTable: "Cohorts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CohortSemesterItems",
                columns: table => new
                {
                    CohortsId = table.Column<int>(type: "int", nullable: false),
                    SemesterItemsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CohortSemesterItems", x => new { x.CohortsId, x.SemesterItemsId });
                    table.ForeignKey(
                        name: "FK_CohortSemesterItems_Cohorts_CohortsId",
                        column: x => x.CohortsId,
                        principalTable: "Cohorts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CohortSemesterItems_SemesterItems_SemesterItemsId",
                        column: x => x.SemesterItemsId,
                        principalTable: "SemesterItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModuleLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SemesterItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modules_SemesterItems_SemesterItemId",
                        column: x => x.SemesterItemId,
                        principalTable: "SemesterItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SemesterItemRelationships",
                columns: table => new
                {
                    DependentSemesterItemId = table.Column<int>(type: "int", nullable: false),
                    RequiredSemesterItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SemesterItemRelationships", x => new { x.DependentSemesterItemId, x.RequiredSemesterItemId });
                    table.ForeignKey(
                        name: "FK_SemesterItemRelationships_SemesterItems_DependentSemesterItemId",
                        column: x => x.DependentSemesterItemId,
                        principalTable: "SemesterItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SemesterItemRelationships_SemesterItems_RequiredSemesterItemId",
                        column: x => x.RequiredSemesterItemId,
                        principalTable: "SemesterItems",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudyRoutes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved_sb = table.Column<bool>(type: "bit", nullable: false),
                    Approved_eb = table.Column<bool>(type: "bit", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Send_sb = table.Column<bool>(type: "bit", nullable: false),
                    Send_eb = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyRoutes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudyRoutes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserSemesterItems",
                columns: table => new
                {
                    SemesterItemsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSemesterItems", x => new { x.SemesterItemsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_UserSemesterItems_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSemesterItems_SemesterItems_SemesterItemsId",
                        column: x => x.SemesterItemsId,
                        principalTable: "SemesterItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudyRouteItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Semester = table.Column<int>(type: "int", nullable: false),
                    StudyRouteId = table.Column<int>(type: "int", nullable: true),
                    SemesterItemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyRouteItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudyRouteItems_SemesterItems_SemesterItemId",
                        column: x => x.SemesterItemId,
                        principalTable: "SemesterItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudyRouteItems_StudyRoutes_StudyRouteId",
                        column: x => x.StudyRouteId,
                        principalTable: "StudyRoutes",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "0e94b60c-e885-4187-a2f1-7e5bd67d7a7a", "Administrator", "ADMINISTRATOR" },
                    { "2", "fd732c56-fdb1-48cf-9495-7fb45ae94524", "Student", "STUDENT" },
                    { "3", "76e31498-77dc-4cf4-9066-6ad5b1fafe7b", "Studiebegeleider", "STUDIEBEGELEIDER" },
                    { "4", "a95edb51-0519-4eec-b267-07493407119c", "Moduleverantwoordelijke", "MODULEVERANTWOORDELIJKE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CohortId1", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TimedOut", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, null, "064bea66-5b56-4f46-8588-69d67b37d6ba", "admin@example.com", false, "Arnold", "Min", false, null, "Arnold Dirk Min", "admin@example.com", "admin", "AQAAAAEAACcQAAAAEOemOwOxlRsFryKBHBOq91bX5N1vvpkWrERSpsPAUBt7ErssQZcQ5/Pi4z6iOUJ4qQ==", null, false, null, null, false, "admin" },
                    { "10", 0, null, "9d732a09-3c9e-4e4c-8d42-c16e2af433c5", "nikhuijskens@example.com", false, "Nik", "Huijskens", false, null, "Nik Huijskens", "nikhuijskens@example.com", "nikhuijskens", "AQAAAAEAACcQAAAAEO5zNfaZrNSeG20cYnl4gEAhjkaDyugf94CJF0KMB0Ba+ANqU8uARHiPpPbItAnsZQ==", null, false, null, null, false, "nikhuijskens" },
                    { "11", 0, null, "991e4ad4-2575-4e82-a886-9edb0cc391d1", "duranpetiet@example.com", false, "Duran", "Petiet", false, null, "Duran Petiet", "duranpetiet@example.com", "duranpetiet", "AQAAAAEAACcQAAAAENe5xbo09yyE5yhF8hK4v74bf61FnNewUT9M4VMMMK+dDjDG5QKIc/K5/jWCA/vuhw==", null, false, null, null, false, "duranpetiet" },
                    { "12", 0, null, "7394e3eb-c41f-4d36-b375-b5da64d41cdd", "veroniekbravenboer@example.com", false, "Veroniek", "Bravenboer", false, null, "Veroniek Bravenboer", "veroniekbravenboer@example.com", "veroniekbravenboer", "AQAAAAEAACcQAAAAEFilGDEou19oQBb0AXrsFRt6OdRgbltqn/BSSV0CecaYDeCoXkSLYvpac40cLlVuyw==", null, false, null, null, false, "veroniekbravenboer" },
                    { "13", 0, null, "7146aca2-edde-4135-b254-d2a8e4b1ffeb", "kaynejagtenberg@example.com", false, "Kayne", "Jagtenberg", false, null, "Kayne Jagtenberg", "kaynejagtenberg@example.com", "kaynejagtenberg", "AQAAAAEAACcQAAAAEB5eppW+JcpanPTuu0RujYDUrnfPqsM3hS/+FN2wheXG9apo1ZwSF+Uolypx52w1/w==", null, false, null, null, false, "kaynejagtenberg" },
                    { "14", 0, null, "bdfff9c0-72c0-4069-9337-305cfbf765c0", "siebrigjeabdi@example.com", false, "Siebrigje", "Abdi", false, null, "Siebrigje Abdi", "siebrigjeabdi@example.com", "siebrigjeabdi", "AQAAAAEAACcQAAAAEGFIQ0Zt+MPSzQifkI7QcNRrFXue30W+CToLVni40Qsb7xUzXjGMGSHQGR/EffXqVw==", null, false, null, null, false, "siebrigjeabdi" },
                    { "15", 0, null, "f344bfbd-5faf-4eae-b4c3-ea410d19d24a", "sterrelambert@example.com", false, "Sterre", "Lambert", false, null, "Sterre Lambert", "sterrelambert@example.com", "sterrelambert", "AQAAAAEAACcQAAAAEORDTmibuh07zGdsb/iluvJFSlkpwTwaTw33ifCSaX6x3HSZmlv8yCOPOABKfW3btw==", null, false, null, null, false, "sterrelambert" },
                    { "16", 0, null, "62b779d9-ddb7-430f-a667-df9b8678996d", "milicavandergouw@example.com", false, "Milica", "Van der Gouw", false, null, "Milica Van der Gouw", "milicavandergouw@example.com", "milicavandergouw", "AQAAAAEAACcQAAAAEC5Z9DuWeyOe6q7pYBfbctyw2dh26hbB4uHltUEKiy9JkZXgxSJiUYlsJRyx3TthJA==", null, false, null, null, false, "milicavandergouw" },
                    { "17", 0, null, "e173276e-1a96-4fca-bacb-fef18149fd32", "yvonbrussaard@example.com", false, "Yvon", "Brussaard", false, null, "Yvon Brussaard", "yvonbrussaard@example.com", "yvonbrussaard", "AQAAAAEAACcQAAAAECcIhpT3dGvwNjvkgn5Zk8PKC8MKQJ/llLjKQbtJ8NuEoKiOyttDfCa7mV3p92Fhww==", null, false, null, null, false, "yvonbrussaard" },
                    { "18", 0, null, "b34e9eb7-8f9f-41c7-87a6-1a2f0c3692a9", "bodhidatema@example.com", false, "Bodhi", "Datema", false, null, "Bodhi Datema", "bodhidatema@example.com", "bodhidatema", "AQAAAAEAACcQAAAAEPvjvlhSqvm2aOow1TLf6z5k4iHJ9QDhRfFQmnKaf9DTzqTXMpQGeehHWcme2aMQHA==", null, false, null, null, false, "bodhidatema" },
                    { "19", 0, null, "36b426ac-443b-4c00-bbaa-72be1a48641b", "noachschutrups@example.com", false, "Noach", "Schutrups", false, null, "Noach Schutrups", "noachschutrups@example.com", "noachschutrups", "AQAAAAEAACcQAAAAEJhFmtro3AkpYURhs0LRivT6FJZIhQxhnI43YBWWixeKyzzAS1mvSCumgHXvZlUGTA==", null, false, null, null, false, "noachschutrups" },
                    { "2", 0, null, "00669581-aef2-4611-8134-3afc413b5a08", "eugenevanroden@example.com", false, "Eugene", "Van Roden", false, null, "Eugene Van Roden", "eugenevanroden@example.com", "eugenevanroden", "AQAAAAEAACcQAAAAEEK+MZODX2RakLuSW+IuJQkE5TdwWaXp8cn6mNusrzQlQd1jnoPt06XJ7/wl19xKlA==", null, false, null, null, false, "eugenevanroden" },
                    { "20", 0, null, "971f31b5-3b37-4ab5-8c69-4313c5fb2b9f", "ouassimbekking@example.com", false, "Ouassim", "Bekking", false, null, "Ouassim Bekking", "ouassimbekking@example.com", "ouassimbekking", "AQAAAAEAACcQAAAAEGpEfRsnaAe4fHw1kx2yUlEtXv92uZHYSyODXqd7kKWZSDqY0TijrQlV1hEPTzCw3A==", null, false, null, null, false, "ouassimbekking" },
                    { "21", 0, null, "ec8de0dc-1be8-46ab-969e-c6dba9d24027", "noervanderkruit@example.com", false, "Noer", "Van der Kruit", false, null, "Noer Van der Kruit", "noervanderkruit@example.com", "noervanderkruit", "AQAAAAEAACcQAAAAECTSlq9aFbDMK5SMYwu8lZZKW9z6dXQHarN80Bfj5vSsPs8wiUmLfYPiwGPqmIl9SA==", null, false, null, null, false, "noervanderkruit" },
                    { "22", 0, null, "cc8abcbb-3a96-4d53-bac0-dd4c2bdcc357", "kaanvanmaarseveen@example.com", false, "Kaan", "Van Maarseveen", false, null, "Kaan Van Maarseveen", "kaanvanmaarseveen@example.com", "kaanvanmaarseveen", "AQAAAAEAACcQAAAAEDgCgLo3u5GOI4gpnct8cU1HvQ0Zn+KrUBB5OlSysi34UAi/Rsl4TcR6gTgLuriajw==", null, false, null, null, false, "kaanvanmaarseveen" },
                    { "23", 0, null, "42634c5b-b4da-4d7d-a5e6-e36cab6f1e75", "owenkaal@example.com", false, "Owen", "Kaal", false, null, "Owen Kaal", "owenkaal@example.com", "owenkaal", "AQAAAAEAACcQAAAAEMoj//FqDb11e58oZrb7nkeJ6QkYF2NxwXVT0d1HHnRq3VMAjjCTXPiNqGCCoxtA7Q==", null, false, null, null, false, "owenkaal" },
                    { "24", 0, null, "4dc8634b-a79d-40e7-8ea4-af4138dfd350", "paulinebah@example.com", false, "Pauline", "Bah", false, null, "Pauline Bah", "paulinebah@example.com", "paulinebah", "AQAAAAEAACcQAAAAEH2vLNEy5fESV8YIgaNm3BMBjgXuO9kEd5t/53PslAk+FFGMcl3O2+wVOmpC6tVzZQ==", null, false, null, null, false, "paulinebah" },
                    { "25", 0, null, "541b1943-72f6-4797-b6f8-6cbd1861c8e4", "caterinatas@example.com", false, "Caterina", "Tas", false, null, "Caterina Tas", "caterinatas@example.com", "caterinatas", "AQAAAAEAACcQAAAAENQr4OlAFb18JHNI5C+tM3Ubm3HVmK2sX+AAh+tEwxbSTVkHcnvz1ULxVAXn/qz5yQ==", null, false, null, null, false, "caterinatas" },
                    { "26", 0, null, "6800abc6-224e-4002-8096-b5ef259c911a", "edtouw@example.com", false, "Ed", "Touw", false, null, "Ed Touw", "edtouw@example.com", "edtouw", "AQAAAAEAACcQAAAAEAWcCjHW5esjGMURMlFjdFXy9pOlz+CdElzCNm00VWsP87aZQG75kYwlW37NeLZzDw==", null, false, null, null, false, "edtouw" },
                    { "27", 0, null, "2dccff83-69b6-4d57-acfe-b9ba5bf24a8d", "hugofidom@example.com", false, "Hugo", "Fidom", false, null, "Hugo Fidom", "hugofidom@example.com", "hugofidom", "AQAAAAEAACcQAAAAEEePFxjxoNUTTSQsGZXMgwi1fukk+itMCB0aCHrHt8mNRGx0AXnyrSsRA1inOi4/OA==", null, false, null, null, false, "hugofidom" },
                    { "28", 0, null, "ad20e70c-76e2-4bdc-91ca-05b35938d23b", "nannebesseling@example.com", false, "Nanne", "Besseling", false, null, "Nanne Besseling", "nannebesseling@example.com", "nannebesseling", "AQAAAAEAACcQAAAAED4XtctQW9GkYsx4oOop2Hgvt+OviKqA5+jsRPXxrjtD6AR1kMs1Vdly0n2qk2EKrQ==", null, false, null, null, false, "nannebesseling" },
                    { "29", 0, null, "eea42411-9c3e-445c-b152-3c0226678c01", "teunisjesalden@example.com", false, "Teunisje", "Salden", false, null, "Teunisje Salden", "teunisjesalden@example.com", "teunisjesalden", "AQAAAAEAACcQAAAAEHZ37nQgTbi2F9a2VZbneG1ZS+qYr5Ib9JbWKRjKTVrTu7amWBLC0LaXqFMs7ydOEg==", null, false, null, null, false, "teunisjesalden" },
                    { "3", 0, null, "5a70191d-8fe7-4e15-beb1-dd2b0d2d0d80", "theotan@example.com", false, "Theo", "Tan", false, null, "Theo Tan", "theotan@example.com", "theotan", "AQAAAAEAACcQAAAAEEDaejRu6o50LSRp/Dkl/Nx3lpl5C3Hd7I6p21ZjjQcRtW6DTmn3CVS/2loxpfkejQ==", null, false, null, null, false, "theotan" },
                    { "30", 0, null, "ffff981c-311a-43be-8083-c1f32ae66f93", "rochedoornink@example.com", false, "Roché", "Doornink", false, null, "Roché Doornink", "rochedoornink@example.com", "rochedoornink", "AQAAAAEAACcQAAAAEJ/Age77nUZTJz4FKuoeg6Hnh9H1rNyY5DHHvgVcvO62qhMChtRpBM88tDHfvf5gNg==", null, false, null, null, false, "rochedoornink" },
                    { "31", 0, null, "32dfdc92-33ad-4e70-b029-000643f6be71", "yuenboertien@example.com", false, "Yuen", "Boertien", false, null, "Yuen Boertien", "yuenboertien@example.com", "yuenboertien", "AQAAAAEAACcQAAAAEAV+9O3yXndfrQ4wpMkrE98TeZ4fHUB5WclSCKpRbjAKc0p39CEa5Zx/EkabmwK4Hg==", null, false, null, null, false, "yuenboertien" },
                    { "32", 0, null, "b263dd86-e329-4042-8c98-f6015179dcce", "heinrichmook@example.com", false, "Heinrich", "Mook", false, null, "Heinrich Mook", "heinrichmook@example.com", "heinrichmook", "AQAAAAEAACcQAAAAEFwE3uf/PPx3nabAy+IGa3tazMUrv8HvXbgSnCLkzUcl0xF4bhhCCdYG4rzRj3DLUA==", null, false, null, null, false, "heinrichmook" },
                    { "33", 0, null, "22acdddd-8e23-4239-a995-7c8c01906bca", "keriantonisse@example.com", false, "Keri", "Antonisse", false, null, "Keri Antonisse", "keriantonisse@example.com", "keriantonisse", "AQAAAAEAACcQAAAAEC+SIN3LlvGHJH59IOZM/jG+pqUVcWvO8UHZwYUcAtYNLKjlrkAlIvVTt9NLskuM5g==", null, false, null, null, false, "keriantonisse" },
                    { "34", 0, null, "0d524a04-f26f-4c6b-ae51-7b5c60b5b9d1", "beerrebergen@example.com", false, "Beer", "Rebergen", false, null, "Beer Rebergen", "beerrebergen@example.com", "beerrebergen", "AQAAAAEAACcQAAAAECQOOPOOFjnkoHEis2Fx0/cQ986WNcjHffpdfr/iH9tyECQokGQtrZ8/cOdn8MRVBQ==", null, false, null, null, false, "beerrebergen" },
                    { "35", 0, null, "e5187f47-6954-496b-b267-b05c4e97dfae", "kainvandergun@example.com", false, "Kaïn", "Van der Gun", false, null, "Kaïn Van der Gun", "kainvandergun@example.com", "kainvandergun", "AQAAAAEAACcQAAAAEEDL4QIhVU065CLTQTwsyeRsSGeRshA1Ua8qm+5ujAn87u6hVNfiGT4B4PET6aBUhQ==", null, false, null, null, false, "kainvandergun" },
                    { "36", 0, null, "59ae4fe6-c69e-4ade-9b19-328a64eef1eb", "marloeswesterdijk@example.com", false, "Marloes", "Westerdijk", false, null, "Marloes Westerdijk", "marloeswesterdijk@example.com", "marloeswesterdijk", "AQAAAAEAACcQAAAAEMCljywJNlUtcfGAAg+5FnFBUvVhoF19kZYXmglGdBrcpQcgBoCICOTKyuaqmBLZMg==", null, false, null, null, false, "marloeswesterdijk" },
                    { "37", 0, null, "6ebfcfdd-af99-4dc0-a0e2-4430c470fdf4", "aurelieesajas@example.com", false, "Aurélie", "Esajas", false, null, "Aurélie Esajas", "aurelieesajas@example.com", "aurelieesajas", "AQAAAAEAACcQAAAAEJZxgtgRuA/tUEvmKJynUo/+F7fbZuKuh7OAETsB6lYgl+Zjjr6GGg+c2sWyKgRnCA==", null, false, null, null, false, "aurelieesajas" },
                    { "38", 0, null, "649181c8-b299-4e19-b560-e3ab2a6139e2", "gerlindenooijens@example.com", false, "Gerlinde", "Nooijens", false, null, "Gerlinde Nooijens", "gerlindenooijens@example.com", "gerlindenooijens", "AQAAAAEAACcQAAAAEKtLIZBrNlJyphISzVE7Secl0IQ2NpEaFjdKQ5StEsoNRQ4T/i6HehSLbTi0wADLEA==", null, false, null, null, false, "gerlindenooijens" },
                    { "39", 0, null, "d6c98240-9e00-4a5e-8c85-210aefae6afc", "summerbrinkhuis@example.com", false, "Summer", "Brinkhuis", false, null, "Summer Brinkhuis", "summerbrinkhuis@example.com", "summerbrinkhuis", "AQAAAAEAACcQAAAAEKKd68bTNlE1RSQV3Qf83HWibn7QsjhIIVqSnAZ7knUx8/8zZPZhQbL1hIU7XGTvaQ==", null, false, null, null, false, "summerbrinkhuis" },
                    { "4", 0, null, "70af6f72-083e-49b2-bda2-5c14c61c560f", "floruscicek@example.com", false, "Florus", "Çiçek", false, null, "Florus Çiçek", "floruscicek@example.com", "floruscicek", "AQAAAAEAACcQAAAAEPKY5649aPYAn2u0TxFQ2XrZGDxBXS5tRIelXN5jfvVXlF2VOIOm55DotawVAtk1aw==", null, false, null, null, false, "floruscicek" },
                    { "40", 0, null, "dabf79f0-0a09-4a18-b3f6-0ebf20c70616", "quirinavandusschoten@example.com", false, "Quirina", "Van Dusschoten", false, null, "Quirina Van Dusschoten", "quirinavandusschoten@example.com", "quirinavandusschoten", "AQAAAAEAACcQAAAAEIKL3JfHKZWksC+d+yR3EBTNXAcnNCV0ByAjA9nEdbdAbNtbXb0F1sLYJS99dJ/qwA==", null, false, null, null, false, "quirinavandusschoten" },
                    { "41", 0, null, "20d157d1-5c6d-4fe0-8a25-09e88d9ebff3", "emmelienhandels@example.com", false, "Emmelien", "Handels", false, null, "Emmelien Handels", "emmelienhandels@example.com", "emmelienhandels", "AQAAAAEAACcQAAAAEJ4S0L77hJAFBg5yQ1659FglFMFZ+SsXIhiIFaI5OG3LBMtsLaN0pi0ifrwYE9QaAQ==", null, false, null, null, false, "emmelienhandels" },
                    { "42", 0, null, "0ed17907-fec7-4f8e-8b55-c8f81964da99", "wensleycurvers@example.com", false, "Wensley", "Curvers", false, null, "Wensley Curvers", "wensleycurvers@example.com", "wensleycurvers", "AQAAAAEAACcQAAAAEICfUKtS106EFqwgeCyl0/MWikelvNKdOmHE6gyH4snu/4Uz1vvrGCPZ/kkSN+DyqA==", null, false, null, null, false, "wensleycurvers" },
                    { "43", 0, null, "233f3360-0ba6-408f-a666-a8a3e9ec9c6a", "dawidvanaart@example.com", false, "Dawid", "Van Aart", false, null, "Dawid Van Aart", "dawidvanaart@example.com", "dawidvanaart", "AQAAAAEAACcQAAAAEBegGqfMmiN0RzI5/m1Q/Mj9IPXdFBH34+6tu/prkfbXedMllZ5qykekLfzQTexcvw==", null, false, null, null, false, "dawidvanaart" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CohortId1", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TimedOut", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5", 0, null, "77801ebd-3954-4b44-b964-2cdba3e1c6bc", "marlenewolf@example.com", false, "Marlène", "Wolf", false, null, "Marlène Wolf", "marlenewolf@example.com", "marlenewolf", "AQAAAAEAACcQAAAAEOS279zVUdVK88RbI0fft2hLUovnA/rq0ZFNLE9vAq3YehTd4hjOsBdhN4QcETapIQ==", null, false, null, null, false, "marlenewolf" },
                    { "6", 0, null, "046a2bf7-a36f-4bf7-90aa-151a7f2bbfd4", "bilalsteentjes@example.com", false, "Bilal", "Steentjes", false, null, "Bilal Steentjes", "bilalsteentjes@example.com", "bilalsteentjes", "AQAAAAEAACcQAAAAEAVf171/m6lJNbR5tFmL+hc39cvBLeTh+0QKslmullqurnfQcS8VtlP3kuYGeHlEsA==", null, false, null, null, false, "bilalsteentjes" },
                    { "7", 0, null, "9361c9d8-9bcf-4b89-9e64-a5c7885fde65", "marlijngiebels@example.com", false, "Marlijn", "Giebels", false, null, "Marlijn Giebels", "marlijngiebels@example.com", "marlijngiebels", "AQAAAAEAACcQAAAAEENy58PsQsm9nKfRt+ClgpyfcaE75echa19rE+RepxOuudptqbtWYx5xzziftxI5Qw==", null, false, null, null, false, "marlijngiebels" },
                    { "8", 0, null, "69ca07f5-562c-484f-abaf-ce18460e60b5", "sabrivandereijk@example.com", false, "Sabri", "Van der Eijk", false, null, "Sabri Van der Eijk", "sabrivandereijk@example.com", "sabrivandereijk", "AQAAAAEAACcQAAAAEHGKq0yH9gB+wLtp6RBSBNuS9qm29DT4m31mo40xXpOs6Z3KuU679IPUW6DRb7zmww==", null, false, null, null, false, "sabrivandereijk" },
                    { "9", 0, null, "f0410d5c-f77f-4337-9eb8-3357e249a422", "caseyandriesse@example.com", false, "Casey", "Andriesse", false, null, "Casey Andriesse", "caseyandriesse@example.com", "caseyandriesse", "AQAAAAEAACcQAAAAEKC6AQzAYi/yP2wUsNn2a97t7IOsFZe4wZZeGgBqXpSozmAIYrDqROBVDuWVIPTozw==", null, false, null, null, false, "caseyandriesse" }
                });

            migrationBuilder.InsertData(
                table: "Cohorts",
                columns: new[] { "Id", "Name", "UserId", "Year" },
                values: new object[,]
                {
                    { 1, "Cohort 1", null, 2020 },
                    { 2, "Cohort 2", null, 2021 },
                    { 3, "Cohort 3", null, 2022 },
                    { 4, "Cohort 4", null, 2023 }
                });

            migrationBuilder.InsertData(
                table: "SemesterItems",
                columns: new[] { "Id", "Description", "Name", "Semester", "YearJson" },
                values: new object[,]
                {
                    { 1, "Description for Semester Item 1", "Semester Item 1", 1, "[1]" },
                    { 2, "Description for Semester Item 2", "Semester Item 2", 2, "[1]" },
                    { 3, "Description for Semester Item 3", "Semester Item 3", 1, "[2]" },
                    { 4, "Description for Semester Item 4", "Semester Item 4", 2, "[2]" },
                    { 5, "Description for Semester Item 5", "Semester Item 5", 2, "[2]" },
                    { 6, "Description for Semester Item 6", "Semester Item 6", 2, "[2]" },
                    { 7, "Description for Semester Item 7", "Semester Item 7", 2, "[2]" },
                    { 8, "Description for Semester Item 8", "Semester Item 8", 2, "[2]" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "2", "10" },
                    { "2", "11" },
                    { "2", "12" },
                    { "2", "13" },
                    { "2", "14" },
                    { "2", "15" },
                    { "2", "16" },
                    { "2", "17" },
                    { "2", "18" },
                    { "2", "19" },
                    { "3", "2" },
                    { "4", "2" },
                    { "2", "20" },
                    { "2", "21" },
                    { "2", "22" },
                    { "2", "23" },
                    { "2", "24" },
                    { "2", "25" },
                    { "2", "26" },
                    { "2", "27" },
                    { "2", "28" },
                    { "2", "29" },
                    { "3", "3" },
                    { "4", "3" },
                    { "2", "30" },
                    { "2", "31" },
                    { "2", "32" },
                    { "2", "33" },
                    { "2", "34" },
                    { "2", "35" },
                    { "2", "36" },
                    { "2", "37" },
                    { "2", "38" },
                    { "2", "39" },
                    { "2", "4" },
                    { "2", "40" },
                    { "2", "41" },
                    { "2", "42" },
                    { "2", "43" },
                    { "2", "5" },
                    { "2", "6" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2", "7" },
                    { "2", "8" },
                    { "2", "9" }
                });

            migrationBuilder.InsertData(
                table: "CohortSemesterItems",
                columns: new[] { "CohortsId", "SemesterItemsId" },
                values: new object[,]
                {
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 5 },
                    { 4, 6 },
                    { 4, 7 },
                    { 4, 8 }
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "ModuleLink", "Name", "SemesterItemId" },
                values: new object[,]
                {
                    { 1, null, "Module 1", 1 },
                    { 2, null, "Module 2", 2 },
                    { 3, null, "Module 3", 3 },
                    { 4, null, "Module 4", 4 }
                });

            migrationBuilder.InsertData(
                table: "SemesterItemRelationships",
                columns: new[] { "DependentSemesterItemId", "RequiredSemesterItemId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 1 },
                    { 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "StudyRoutes",
                columns: new[] { "Id", "Approved_eb", "Approved_sb", "Name", "Note", "Send_eb", "Send_sb", "UserId" },
                values: new object[] { 1, true, true, "Computer Science", "This is a note", true, true, "1" });

            migrationBuilder.InsertData(
                table: "StudyRouteItems",
                columns: new[] { "Id", "Semester", "SemesterItemId", "StudyRouteId", "Year" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 1 },
                    { 2, 2, 2, 1, 1 },
                    { 3, 1, 3, 1, 2 },
                    { 4, 2, 4, 1, 2 },
                    { 5, 1, 5, 1, 3 },
                    { 6, 2, 6, 1, 3 },
                    { 7, 1, 7, 1, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CohortId1",
                table: "AspNetUsers",
                column: "CohortId1");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CohortSemesterItems_SemesterItemsId",
                table: "CohortSemesterItems",
                column: "SemesterItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_SemesterItemId",
                table: "Modules",
                column: "SemesterItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SemesterItemRelationships_RequiredSemesterItemId",
                table: "SemesterItemRelationships",
                column: "RequiredSemesterItemId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyRouteItems_SemesterItemId",
                table: "StudyRouteItems",
                column: "SemesterItemId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyRouteItems_StudyRouteId",
                table: "StudyRouteItems",
                column: "StudyRouteId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyRoutes_UserId",
                table: "StudyRoutes",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserSemesterItems_UsersId",
                table: "UserSemesterItems",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CohortSemesterItems");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "SemesterItemRelationships");

            migrationBuilder.DropTable(
                name: "StudyRouteItems");

            migrationBuilder.DropTable(
                name: "UserSemesterItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "StudyRoutes");

            migrationBuilder.DropTable(
                name: "SemesterItems");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Cohorts");
        }
    }
}
