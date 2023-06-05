using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace keuzewijzer_hbo_deeltijd_ict_API.Migrations
{
    public partial class test : Migration
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
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
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
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CohortId1 = table.Column<int>(type: "int", nullable: true),
                    TimedOut = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Cohorts_CohortId1",
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
                        name: "FK_StudyRoutes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    RolesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.RolesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_UserSemesterItems_SemesterItems_SemesterItemsId",
                        column: x => x.SemesterItemsId,
                        principalTable: "SemesterItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSemesterItems_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
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
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Administrator" },
                    { 2, "Student" },
                    { 3, "Studiebegeleider" },
                    { 4, "Moduleverantwoordelijke" }
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
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "CohortId1", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TimedOut", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, null, "ef5b35f7-151f-473e-ad3d-c1b7f5aaed64", "admin@example.com", false, "Arnold", "Min", false, null, "Arnold Dirk Min", null, null, "AQAAAAEAACcQAAAAEPsjuNInvpYjwqOfv2uf1JiVgFwvv49oHasbbeS/Tbk22XBjwgYsnW/kEWwZvlI9AA==", null, false, null, null, false, "admin@example.com" },
                    { "10", 0, null, "e62e8663-a047-47b2-855d-06a3428bffc0", "sharonapouw@example.com", false, "Sharona", "Pouw", false, null, "Sharona Pouw", null, null, "AQAAAAEAACcQAAAAEDIeZ4HX/X49YEaQ++oKVWMUajjLA4/zEZBR15RfLXAmDaXgLAhUNn2/lV9zwFEkvA==", null, false, null, null, false, "sharonapouw@example.com" },
                    { "11", 0, null, "caec3a1c-6547-40b7-8b44-589fae71850c", "ashwienabbenhuis@example.com", false, "Ashwien", "Abbenhuis", false, null, "Ashwien Abbenhuis", null, null, "AQAAAAEAACcQAAAAEG8jr/gdqjkWFdnBhJpphMekUP/SVnSs3wwN5Zea9RI1aD/RF5x2Azpq+SD2xo2Few==", null, false, null, null, false, "ashwienabbenhuis@example.com" },
                    { "12", 0, null, "13592591-b2ac-450f-bafc-e08d1ef7f190", "raulverdaasdonk@example.com", false, "Raul", "Verdaasdonk", false, null, "Raul Verdaasdonk", null, null, "AQAAAAEAACcQAAAAEEe8Y2cxd57JszCbzYWsAI8dIPSwqIe8USPeBbyMUsuqmSnHuj41xUcp4LzIudG2tQ==", null, false, null, null, false, "raulverdaasdonk@example.com" },
                    { "13", 0, null, "68b6e143-4646-4d8d-a340-a85c2c7bf3c3", "majellawessels@example.com", false, "Majella", "Wessels", false, null, "Majella Wessels", null, null, "AQAAAAEAACcQAAAAEOqCk+Cb+KAxfJPav9DoRsGbAnK0XlU4uSq+iwSO8tmWtGCgCTRoWlqpfRGE//Xiqw==", null, false, null, null, false, "majellawessels@example.com" },
                    { "14", 0, null, "f9d63b86-bb98-4a39-b109-c93ea138a246", "kwintlogtenberg@example.com", false, "Kwint", "Logtenberg", false, null, "Kwint Logtenberg", null, null, "AQAAAAEAACcQAAAAEEso4Cwhp8CQhcmtbbtLATIxqdZfrt5x/GF++uC3gLgFq572HgfQBe626RG2/MPUbQ==", null, false, null, null, false, "kwintlogtenberg@example.com" },
                    { "15", 0, null, "e4fb8731-7a40-4334-9013-bf49eb8e00cd", "mikhaillebbink@example.com", false, "Mikhail", "Lebbink", false, null, "Mikhail Lebbink", null, null, "AQAAAAEAACcQAAAAELCvqs1LxEeBx1ssk1hvqgfJ7rgfnWz2hLjNfcHvN/WDoY3eehaNiCcUOgBnMv4E/A==", null, false, null, null, false, "mikhaillebbink@example.com" },
                    { "16", 0, null, "c6bcf1ae-9740-4079-80ed-3bd18897c859", "claylier@example.com", false, "Clay", "Lier", false, null, "Clay Lier", null, null, "AQAAAAEAACcQAAAAEEem1zaIvLpF9S9KxvZu7q8Tz6sU5uhRbhJNnuqkD7axLHD9EI1ZiG54vPkmUv3UgA==", null, false, null, null, false, "claylier@example.com" },
                    { "17", 0, null, "ccdb375c-0322-457d-a20a-703273ef754d", "rubinavanderhout@example.com", false, "Rubina", "Van der Hout", false, null, "Rubina Van der Hout", null, null, "AQAAAAEAACcQAAAAENdtG8mtAEQSqtZ1wxSOo95Q+GEjxSuhHE3b74pvzeXejj8bpiAclPCGT0Zlb4wS1w==", null, false, null, null, false, "rubinavanderhout@example.com" },
                    { "18", 0, null, "3301dde2-251a-46c9-89e8-3e8d06e2e7b3", "abderrazakblaauwbroek@example.com", false, "Abderrazak", "Blaauwbroek", false, null, "Abderrazak Blaauwbroek", null, null, "AQAAAAEAACcQAAAAEPaBTMxXOZd6IGtYSaiyBO3lfKMb2fIWd+pG3XftcfwdsJUJQE0L0Y73eXGti+nUbw==", null, false, null, null, false, "abderrazakblaauwbroek@example.com" },
                    { "19", 0, null, "82194f7f-bab4-43ef-8275-999bc59a7be8", "yannikconsten@example.com", false, "Yannik", "Consten", false, null, "Yannik Consten", null, null, "AQAAAAEAACcQAAAAEG4RkuI8gJ5R8uakjHmShflwAo7RMsVi0/st7KOf2pMuqyAeGRQbdvnCivALlCo+LA==", null, false, null, null, false, "yannikconsten@example.com" },
                    { "2", 0, null, "64d02a7e-a752-4acf-b0b0-9453f5bb1bbf", "eugenevanroden@example.com", false, "Eugene", "Van Roden", false, null, "Eugene Van Roden", null, null, "AQAAAAEAACcQAAAAEO28A/dm08ktcjDCbQfPNvg2j++0TikeSe3uaR+xtEFfr347Ti46tvXFrPgTvdHSQw==", null, false, null, null, false, "eugenevanroden@example.com" },
                    { "20", 0, null, "fba6ccf5-158e-4125-b629-261dafbb2cdc", "niniboekhoudt@example.com", false, "Nini", "Boekhoudt", false, null, "Nini Boekhoudt", null, null, "AQAAAAEAACcQAAAAEBmq4XoUny5EGCdC3/ODBfY1l9Q5F3dRRMwKQlFDaJ6IdjJQt0SMQshXSGKMB2Mx2A==", null, false, null, null, false, "niniboekhoudt@example.com" },
                    { "21", 0, null, "15815cfa-be40-45b9-8142-f24b979a9e57", "mounssifborkent@example.com", false, "Mounssif", "Borkent", false, null, "Mounssif Borkent", null, null, "AQAAAAEAACcQAAAAEPU8pzElKiArnUB1FawmT9vmJnRxk0yLtQdYWkDLl17TgeFHA8Q3aNTsZtznwJM7FA==", null, false, null, null, false, "mounssifborkent@example.com" },
                    { "22", 0, null, "1a8ed57b-a788-4d7d-ac05-58fc610442e4", "metjeknoef@example.com", false, "Metje", "Knoef", false, null, "Metje Knoef", null, null, "AQAAAAEAACcQAAAAEGOvmnxxpyv3T8JCqpiuuknlyVQ4j7rNHGJ21vVcmdLQGV4sON00B9m59jPh81AR6w==", null, false, null, null, false, "metjeknoef@example.com" },
                    { "23", 0, null, "ec9e35d1-3412-4528-9389-f153c4f56f53", "lolkjehagoort@example.com", false, "Lolkje", "Hagoort", false, null, "Lolkje Hagoort", null, null, "AQAAAAEAACcQAAAAEO4MoBe62aSLT2LnXFE7uIa4hVRIX/UA4mXahgDEcGWu/xUpnrEftlUtSDzX47LVbw==", null, false, null, null, false, "lolkjehagoort@example.com" },
                    { "24", 0, null, "ae872b69-a5f3-4dd4-925f-36c12c68d9d6", "sabriadenissen@example.com", false, "Sabria", "Denissen", false, null, "Sabria Denissen", null, null, "AQAAAAEAACcQAAAAELwnv5EMaQijP1iyhGKT1+CYs0C8pKVhJTA+9O2TWh0h9sIyPs3X9TPZRb3iXQ6Vvg==", null, false, null, null, false, "sabriadenissen@example.com" },
                    { "25", 0, null, "e2e71490-9182-49ec-bb35-233c0b4a2f06", "farukvanschip@example.com", false, "Faruk", "Van Schip", false, null, "Faruk Van Schip", null, null, "AQAAAAEAACcQAAAAELDpyFnTgjqm+rC6bjl99IsyPom+EVbdr8yYZr4s/Rzwm81Vb1vmVA/C7EL53JjjQw==", null, false, null, null, false, "farukvanschip@example.com" },
                    { "26", 0, null, "b1ec7229-5014-4b14-b1fc-b0836187ca7d", "zakariadraaisma@example.com", false, "Zakaria", "Draaisma", false, null, "Zakaria Draaisma", null, null, "AQAAAAEAACcQAAAAECL+pmLQrZw9REdMzmR7nFIz/KwAurYGD9AeroWfwp5ympioFePinWPsGTfpG8Q0BA==", null, false, null, null, false, "zakariadraaisma@example.com" },
                    { "27", 0, null, "2674dfd0-493b-4784-9e8c-b68634062bca", "oguzheessels@example.com", false, "Oguz", "Heessels", false, null, "Oguz Heessels", null, null, "AQAAAAEAACcQAAAAEJ8OlFHBzQ2OLALy+PKARsFKk/oBuuThLzXmVYR9JyGuREoMnMyxUz2Hi6srjU172Q==", null, false, null, null, false, "oguzheessels@example.com" },
                    { "28", 0, null, "dc59e4d2-a4f8-4ac3-902a-ba7f185ccec7", "mariaburggraaff@example.com", false, "Maria", "Burggraaff", false, null, "Maria Burggraaff", null, null, "AQAAAAEAACcQAAAAEE173N6Atkuor2LjCj2iIx+FbSOY6nBBU880eKnyDIwFeJSSXvnygmXPx26KJVFYhQ==", null, false, null, null, false, "mariaburggraaff@example.com" },
                    { "29", 0, null, "c23cad12-806c-4021-b77d-9def807d9498", "katelijnvandekoppel@example.com", false, "Katelijn", "Van de Koppel", false, null, "Katelijn Van de Koppel", null, null, "AQAAAAEAACcQAAAAEAkGjdRrSt6YdXMhdp1ZjHfaruXj90ubKoO3CJ4B0tKrl2Plh2OI6SeBC/nTm+Ancw==", null, false, null, null, false, "katelijnvandekoppel@example.com" },
                    { "3", 0, null, "46f0e22c-2be3-4afc-af01-2bd962eddeff", "theotan@example.com", false, "Theo", "Tan", false, null, "Theo Tan", null, null, "AQAAAAEAACcQAAAAEKbPszWovWh8kVU4h29ZKRiYxE+E/i2uGiZaKbxEPawYNKZOM2vKyEl37cnstleQ7Q==", null, false, null, null, false, "theotan@example.com" },
                    { "30", 0, null, "b9b3a5af-eccb-483b-a498-de1274a71739", "desirescheeren@example.com", false, "Désiré", "Scheeren", false, null, "Désiré Scheeren", null, null, "AQAAAAEAACcQAAAAEOaVjTLtmM0kJsd/DijQYTNwpapCJFhSIc+hHYj9abnaDKsD8ZwDVSGoEhfUqkkRdg==", null, false, null, null, false, "desirescheeren@example.com" },
                    { "31", 0, null, "bee1a392-9142-442a-bf11-2980a8ca250a", "daxgabriel@example.com", false, "Dax", "Gabriel", false, null, "Dax Gabriel", null, null, "AQAAAAEAACcQAAAAEPt7tJkl3CvHl+8ApgmHtN1LadXMH7+NHpkKp5cZuRjLqyKvYbyC6Pw848WktUh92Q==", null, false, null, null, false, "daxgabriel@example.com" },
                    { "32", 0, null, "a53a44bf-1cf4-4963-ae1c-a3902a22c1d3", "tommiestel@example.com", false, "Tommie", "Stel", false, null, "Tommie Stel", null, null, "AQAAAAEAACcQAAAAEIpC6beoRJMoZRGbnkokB304RTDUVdA6y0/7edHGG/YW/5120TrEOx1GWIaO3o46+Q==", null, false, null, null, false, "tommiestel@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "CohortId1", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TimedOut", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "33", 0, null, "5f4cbcbd-b94a-4085-b1be-7d41d87b37be", "raphaelkoppe@example.com", false, "Raphaël", "Koppe", false, null, "Raphaël Koppe", null, null, "AQAAAAEAACcQAAAAECaDwWTdyVvuCXfQofch1fDpKw0snOi0InqGXwnYO9rNRys9DDA/5DA5LIQtvpX9mQ==", null, false, null, null, false, "raphaelkoppe@example.com" },
                    { "34", 0, null, "d90312fb-2fcb-45ba-95b9-b16c98c0f09e", "demyjongen@example.com", false, "Demy", "Jongen", false, null, "Demy Jongen", null, null, "AQAAAAEAACcQAAAAEOV3+1FOSTqiqguZ2PcW/ZJ+PmnurKJ9CX3xLqQpSHevuBd9YYxemua04nXalqSi1w==", null, false, null, null, false, "demyjongen@example.com" },
                    { "35", 0, null, "bf7a2fb7-54b1-43c7-8c47-a64fc5dfd518", "leahharreman@example.com", false, "Leah", "Harreman", false, null, "Leah Harreman", null, null, "AQAAAAEAACcQAAAAEA8oHSqFrgYInGwPE/Ly9WichlB1foNzzZ7cbkIpMon6zcAIYYD2ckTRsNkJPb7xkg==", null, false, null, null, false, "leahharreman@example.com" },
                    { "36", 0, null, "13d03aa2-11ff-464e-be04-d8d75c883f46", "idrisskorpershoek@example.com", false, "Idriss", "Korpershoek", false, null, "Idriss Korpershoek", null, null, "AQAAAAEAACcQAAAAEMMT+Fy5a5C+3nJSiySvJSnm84a2YtY0+ZHHbeiKXoSN8JfoAYAhvrO/h0BJDoTYxQ==", null, false, null, null, false, "idrisskorpershoek@example.com" },
                    { "37", 0, null, "4c3987e1-3a2a-40dd-8169-d87e25b5770e", "rashiedbleumink@example.com", false, "Rashied", "Bleumink", false, null, "Rashied Bleumink", null, null, "AQAAAAEAACcQAAAAEEm7HAFf9Abi9t7kdX1O6l84q6bRnW+pz5FvCG3A0L+LzWeNCDYvHtw6wZ08My/7cg==", null, false, null, null, false, "rashiedbleumink@example.com" },
                    { "38", 0, null, "77aa202d-1d39-4af7-8502-59f7daf1447f", "siay@example.com", false, "Si", "Ay", false, null, "Si Ay", null, null, "AQAAAAEAACcQAAAAELamTKp502p6ji0IgJkf5UOYMperU20q7HFeApJPcCT+l9RWvcNCJiUExZ3JHgCTIw==", null, false, null, null, false, "siay@example.com" },
                    { "39", 0, null, "6e5a4390-9773-4171-b79b-41410712ee8e", "manolyalebens@example.com", false, "Manolya", "Lebens", false, null, "Manolya Lebens", null, null, "AQAAAAEAACcQAAAAELwTO2a8VxirGjT9eAA4QnORRms7JgdcZjvIkTmi3MHIWdJ1LWiLsQcZZT50FWuPQQ==", null, false, null, null, false, "manolyalebens@example.com" },
                    { "4", 0, null, "c3f071eb-db76-456c-bc1e-c0af2d24ced3", "cloekras@example.com", false, "Cloé", "Kras", false, null, "Cloé Kras", null, null, "AQAAAAEAACcQAAAAEIPzpE9ye+OB+gsQ9E1mxeannLewWBMQ/lrp9VlAFK8NBkRFN8wEYBX56tANF7aFSg==", null, false, null, null, false, "cloekras@example.com" },
                    { "40", 0, null, "7f787eae-8f0b-4880-a0d9-d15c11c57000", "mateuszmachielsen@example.com", false, "Mateusz", "Machielsen", false, null, "Mateusz Machielsen", null, null, "AQAAAAEAACcQAAAAEM1wm1Kw+9JrjIUkPS3rmp0MKLnKQyDj9SJHEz2tc+5SHYkpE+iR/WSpCYebkgmRYQ==", null, false, null, null, false, "mateuszmachielsen@example.com" },
                    { "41", 0, null, "27286fa6-e260-45d0-8947-c0bf10e664c7", "douaavandepavert@example.com", false, "Douaa", "Van de Pavert", false, null, "Douaa Van de Pavert", null, null, "AQAAAAEAACcQAAAAELqrunyhmGx8lyRHSVndVejoQ+jJG/k0jcTfItLRzjH/ygo5/tF9kOfLHjsdx9MRYQ==", null, false, null, null, false, "douaavandepavert@example.com" },
                    { "42", 0, null, "7b2ba50c-69c6-433a-8266-8c80cccfcb1a", "kishanhoogkamp@example.com", false, "Kishan", "Hoogkamp", false, null, "Kishan Hoogkamp", null, null, "AQAAAAEAACcQAAAAEMLUBb1dPh88le7a7fKBS/RZ538Iis8dO7FHQpjn8s8xOEbNSxr/7uYxvIdkSCTRvQ==", null, false, null, null, false, "kishanhoogkamp@example.com" },
                    { "43", 0, null, "e40f2636-2bfa-40f8-b3e8-37ec97b28535", "harmjanversendaal@example.com", false, "Harmjan", "Versendaal", false, null, "Harmjan Versendaal", null, null, "AQAAAAEAACcQAAAAENarEf1CaD8ag0a2Hfd/Yg5pS4qcZu71nHQnYARVt9GrlbS4p/cBiZB6Isxg5r/8ow==", null, false, null, null, false, "harmjanversendaal@example.com" },
                    { "5", 0, null, "cfaefa9b-3feb-452e-ade5-d41b4788a2b2", "maurivannuland@example.com", false, "Mauri", "Van Nuland", false, null, "Mauri Van Nuland", null, null, "AQAAAAEAACcQAAAAEIxfnmG993W/6TklbMDiFbZtLa2EedRdxH1OKgU0VB3AHwFYDZhG96qjx8dKzD3XsA==", null, false, null, null, false, "maurivannuland@example.com" },
                    { "6", 0, null, "91d9d926-69d2-4f40-a765-11e241379028", "jeromeheerink@example.com", false, "Jerome", "Heerink", false, null, "Jerome Heerink", null, null, "AQAAAAEAACcQAAAAEJxrrAWLO9UgkruBtBrKrpdBxDbc+H6jfUtbEQOt8GVaXcEPZSj42Hxvy95Qc7Gg7A==", null, false, null, null, false, "jeromeheerink@example.com" },
                    { "7", 0, null, "971f6270-5171-4ba4-abef-c2178a5a614f", "semihvanburken@example.com", false, "Semih", "Van Burken", false, null, "Semih Van Burken", null, null, "AQAAAAEAACcQAAAAENVHudwOxWctmHNTvORFz+BVgZP80/YQjrcwYE3LsKm0J5QDV4ujDr2WLhV0EGFLLA==", null, false, null, null, false, "semihvanburken@example.com" },
                    { "8", 0, null, "7293b383-37ce-4e46-b4d5-e8d740b0d7de", "jacomijntjemoraal@example.com", false, "Jacomijntje", "Moraal", false, null, "Jacomijntje Moraal", null, null, "AQAAAAEAACcQAAAAEPBfHf/dV05dk7WVS8zg+8i6kx8h0axp1M0nDfRhRUI/cCvpmJjRltK99jGkOaJKzQ==", null, false, null, null, false, "jacomijntjemoraal@example.com" },
                    { "9", 0, null, "496f50ef-44f9-4b2a-bef1-200eecd475a4", "sjuulalma@example.com", false, "Sjuul", "Alma", false, null, "Sjuul Alma", null, null, "AQAAAAEAACcQAAAAEF/okmT+IRvuAqkOTZtwaEZJ7UcpNcG0xAtgaVD4Qc6yApLLVhlIUHBVQwBNbOSY1g==", null, false, null, null, false, "sjuulalma@example.com" }
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
                table: "UserRoles",
                columns: new[] { "RolesId", "UsersId" },
                values: new object[,]
                {
                    { 1, "1" },
                    { 2, "10" },
                    { 2, "11" },
                    { 2, "12" },
                    { 2, "13" },
                    { 2, "14" },
                    { 2, "15" },
                    { 2, "16" },
                    { 2, "17" },
                    { 2, "18" },
                    { 2, "19" },
                    { 2, "20" },
                    { 2, "21" },
                    { 2, "22" },
                    { 2, "23" },
                    { 2, "24" },
                    { 2, "25" },
                    { 2, "26" },
                    { 2, "27" },
                    { 2, "28" },
                    { 2, "29" },
                    { 2, "30" },
                    { 2, "31" },
                    { 2, "32" },
                    { 2, "33" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RolesId", "UsersId" },
                values: new object[,]
                {
                    { 2, "34" },
                    { 2, "35" },
                    { 2, "36" },
                    { 2, "37" },
                    { 2, "38" },
                    { 2, "39" },
                    { 2, "4" },
                    { 2, "40" },
                    { 2, "41" },
                    { 2, "42" },
                    { 2, "43" },
                    { 2, "5" },
                    { 2, "6" },
                    { 2, "7" },
                    { 2, "8" },
                    { 2, "9" },
                    { 3, "2" },
                    { 3, "3" },
                    { 4, "2" },
                    { 4, "3" }
                });

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
                name: "IX_UserRoles_UsersId",
                table: "UserRoles",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CohortId1",
                table: "Users",
                column: "CohortId1");

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
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserSemesterItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "StudyRoutes");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "SemesterItems");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Cohorts");
        }
    }
}
