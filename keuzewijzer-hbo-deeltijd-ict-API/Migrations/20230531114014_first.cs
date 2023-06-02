using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace keuzewijzer_hbo_deeltijd_ict_API.Migrations
{
    public partial class first : Migration
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
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyRoutes", x => x.Id);
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
                name: "StudyRouteItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Semester = table.Column<int>(type: "int", nullable: false),
                    StudyRouteId = table.Column<int>(type: "int", nullable: false),
                    SemesterItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyRouteItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudyRouteItems_SemesterItems_SemesterItemId",
                        column: x => x.SemesterItemId,
                        principalTable: "SemesterItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudyRouteItems_StudyRoutes_StudyRouteId",
                        column: x => x.StudyRouteId,
                        principalTable: "StudyRoutes",
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
                    StudyRouteId = table.Column<int>(type: "int", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Users_StudyRoutes_StudyRouteId",
                        column: x => x.StudyRouteId,
                        principalTable: "StudyRoutes",
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
                    { 4, "Description for Semester Item 4", "Semester Item 4", 2, "[2]" }
                });

            migrationBuilder.InsertData(
                table: "StudyRoutes",
                columns: new[] { "Id", "Approved_eb", "Approved_sb", "Name", "Note", "Send_eb", "Send_sb", "UserId" },
                values: new object[] { 1, true, true, "Computer Science", "This is a note", true, true, 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "CohortId1", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StudyRouteId", "TimedOut", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, null, "2ad0257f-c101-4a91-a03e-38c8f4aec201", "admin@example.com", false, "Arnold", "Min", false, null, "Arnold Dirk Min", null, null, "AQAAAAEAACcQAAAAEGeZhDlAbhcdgw5GultAT9scMk9uY79w3eWlAYeqVVUT+wpHquBlluCDQClxGIgBtg==", null, false, null, null, null, false, "admin@example.com" },
                    { "10", 0, null, "1784103d-fd50-4341-9359-9783c850872d", "sharonapouw@example.com", false, "Sharona", "Pouw", false, null, "Sharona Pouw", null, null, "AQAAAAEAACcQAAAAEGoyKOous3OFOT7u8w+J+0Q+LcoLv6W3mB3JnhpBkFeVHeAMwq+nRI9MfkxDgCui4Q==", null, false, null, null, null, false, "sharonapouw@example.com" },
                    { "11", 0, null, "2bec9d79-5024-4311-9215-8472ee58d110", "ashwienabbenhuis@example.com", false, "Ashwien", "Abbenhuis", false, null, "Ashwien Abbenhuis", null, null, "AQAAAAEAACcQAAAAEJ2YGt3cQg/xa2RlMZH9oPYTvP+C1dOMWMnjrSSegPt72TH8DuA5BPfuMgOjd/UOzQ==", null, false, null, null, null, false, "ashwienabbenhuis@example.com" },
                    { "12", 0, null, "12396af2-d2cc-4cca-acba-6e3e6088114c", "raulverdaasdonk@example.com", false, "Raul", "Verdaasdonk", false, null, "Raul Verdaasdonk", null, null, "AQAAAAEAACcQAAAAELr7k8eIIQi8mvAhh5H4kECVED/a7XmBX039DyN/7tF3GYi8WPxqs54voMYorvlDPA==", null, false, null, null, null, false, "raulverdaasdonk@example.com" },
                    { "13", 0, null, "5b3b1a32-c524-4b39-8f5c-34fd9cfa2026", "majellawessels@example.com", false, "Majella", "Wessels", false, null, "Majella Wessels", null, null, "AQAAAAEAACcQAAAAEIBOgN/VARTrUJknr4D5hSdx23eZ/Bs1RerE1R0JTVx/30wX6HH/1mz5sK19ivHsOw==", null, false, null, null, null, false, "majellawessels@example.com" },
                    { "14", 0, null, "697ab588-0110-4914-9d03-0ab827ea2f53", "kwintlogtenberg@example.com", false, "Kwint", "Logtenberg", false, null, "Kwint Logtenberg", null, null, "AQAAAAEAACcQAAAAEMSiUf/V5XORXHQRbohsVQAzgGNGabbEPEp4BZawudld3mUGHMjzbDC5VqGwtlE63A==", null, false, null, null, null, false, "kwintlogtenberg@example.com" },
                    { "15", 0, null, "c74f3a5d-dcbe-413c-959c-8095dc355feb", "mikhaillebbink@example.com", false, "Mikhail", "Lebbink", false, null, "Mikhail Lebbink", null, null, "AQAAAAEAACcQAAAAEHGhhht+6ae4rbbZNwc8apPlGNS1eU0eRx8HWFeYWD9GwRqpH1nPMpdKHV67Dv0HIQ==", null, false, null, null, null, false, "mikhaillebbink@example.com" },
                    { "16", 0, null, "b2dd4ba0-5aea-42b6-8815-5f165fee502c", "claylier@example.com", false, "Clay", "Lier", false, null, "Clay Lier", null, null, "AQAAAAEAACcQAAAAEGvbnwLpP6X0S4EQCGTrMwCjnEcy5MxT8XCn+TBiM+b156axksJUj/U+XCHskDh1Aw==", null, false, null, null, null, false, "claylier@example.com" },
                    { "17", 0, null, "69275918-1652-4456-bc3f-cd0a4ab16198", "rubinavanderhout@example.com", false, "Rubina", "Van der Hout", false, null, "Rubina Van der Hout", null, null, "AQAAAAEAACcQAAAAEIiggoElNqOCod79uDBrz0XTqF+fAjDLUOpJjo+CA9TrUcljcO/IsBMp4sIsQAasYA==", null, false, null, null, null, false, "rubinavanderhout@example.com" },
                    { "18", 0, null, "9f02fc34-be97-4156-b182-b83b5cd40802", "abderrazakblaauwbroek@example.com", false, "Abderrazak", "Blaauwbroek", false, null, "Abderrazak Blaauwbroek", null, null, "AQAAAAEAACcQAAAAEE/Q1yepV2EDBJlqw5ftf8QywvLp7E+lfGThIfCE1T7aw6orFi2NaVeBHmTZ/TGjKQ==", null, false, null, null, null, false, "abderrazakblaauwbroek@example.com" },
                    { "19", 0, null, "76cf2737-1b6f-4b6b-b7d6-28199d2b6098", "yannikconsten@example.com", false, "Yannik", "Consten", false, null, "Yannik Consten", null, null, "AQAAAAEAACcQAAAAEA6sGw8w9/9gOgvmRiIYDV318w4mbwE7RjqI/WUZEh2ZJsXt2ZyyD+4x/JcF3/P5VA==", null, false, null, null, null, false, "yannikconsten@example.com" },
                    { "2", 0, null, "9fc673d1-eff4-450d-b270-e99ab52751d2", "eugenevanroden@example.com", false, "Eugene", "Van Roden", false, null, "Eugene Van Roden", null, null, "AQAAAAEAACcQAAAAELY9Zed3pR4krk576n1VsdkAIrRZr3s6J1a6CPR36p7yvWHIeMqIMW9VWg8UEfUukA==", null, false, null, null, null, false, "eugenevanroden@example.com" },
                    { "20", 0, null, "00d7f750-d5c6-45f0-8d9b-c39e45411872", "niniboekhoudt@example.com", false, "Nini", "Boekhoudt", false, null, "Nini Boekhoudt", null, null, "AQAAAAEAACcQAAAAEEhHel+xJMQVaWReXgEGm2yZG+L7ooUyOwHwZLmy3UQU7N3i+YCh8+CaZBfot4v5CQ==", null, false, null, null, null, false, "niniboekhoudt@example.com" },
                    { "21", 0, null, "28892a0d-f30e-44b1-a4f9-be7889820859", "mounssifborkent@example.com", false, "Mounssif", "Borkent", false, null, "Mounssif Borkent", null, null, "AQAAAAEAACcQAAAAEKNDfCWHZNpyuVCbBOREU2CDl85hveNxq7FQnYOxt/Mxgca2MR+qs1/vPGXJ4pbsNw==", null, false, null, null, null, false, "mounssifborkent@example.com" },
                    { "22", 0, null, "8c9898e7-cd5a-4c92-b219-2be7f7aa9fe6", "metjeknoef@example.com", false, "Metje", "Knoef", false, null, "Metje Knoef", null, null, "AQAAAAEAACcQAAAAEE7Gev6Dk1ajfidHYyOX5xr0BDcAhb3xbUKMVXtjIAHwwottdOqKUcbsF17GCQEKPQ==", null, false, null, null, null, false, "metjeknoef@example.com" },
                    { "23", 0, null, "ac0f8b6d-874b-4c66-9714-1b8e6fd35031", "lolkjehagoort@example.com", false, "Lolkje", "Hagoort", false, null, "Lolkje Hagoort", null, null, "AQAAAAEAACcQAAAAEClHkirWIocKm4xcynhbL4ellFh97n2uGh+hiVywy90pkXvVk0eAurBpgMYRgETgyw==", null, false, null, null, null, false, "lolkjehagoort@example.com" },
                    { "24", 0, null, "cadf381d-64cb-4307-8b7f-81f1f92acf53", "sabriadenissen@example.com", false, "Sabria", "Denissen", false, null, "Sabria Denissen", null, null, "AQAAAAEAACcQAAAAEG9dV/ALsVjAktOwlkkHlZ1reG7ApbPqwGHbhb29DLI368YALMogvILWbFQHnAODMQ==", null, false, null, null, null, false, "sabriadenissen@example.com" },
                    { "25", 0, null, "2731b313-0371-4395-b22a-1433e23089cf", "farukvanschip@example.com", false, "Faruk", "Van Schip", false, null, "Faruk Van Schip", null, null, "AQAAAAEAACcQAAAAEHnMBOS2CWOTL7k/bDczwBU2bHMVWJYBDK5B9i4qWY/OxyWYg/ilRE/tKqp/jiWyug==", null, false, null, null, null, false, "farukvanschip@example.com" },
                    { "26", 0, null, "c20d9966-04f6-4d0a-b940-45bd74a6c52b", "zakariadraaisma@example.com", false, "Zakaria", "Draaisma", false, null, "Zakaria Draaisma", null, null, "AQAAAAEAACcQAAAAEDSsPG5tQURHdziSejxRErLliPgGU2uNs2tAPpOgkXfQgN0xtgtMha4rWLCb4rqsMg==", null, false, null, null, null, false, "zakariadraaisma@example.com" },
                    { "27", 0, null, "29929c51-cc16-4f40-82eb-3bbf682347e7", "oguzheessels@example.com", false, "Oguz", "Heessels", false, null, "Oguz Heessels", null, null, "AQAAAAEAACcQAAAAEMXzgiQg+R6seYw6ouZEjqdj0f4W5Lx2OE3EaJ6dsWe9SatnIC++Ye0paorRnRwzAA==", null, false, null, null, null, false, "oguzheessels@example.com" },
                    { "28", 0, null, "8121206b-19c0-484d-b2c2-b53285bad16b", "mariaburggraaff@example.com", false, "Maria", "Burggraaff", false, null, "Maria Burggraaff", null, null, "AQAAAAEAACcQAAAAEEnBG++goHo6STfIdBA6ESBTScWSCpIDJZFPhTA9RhMgxS5rz6FFVB88GsGf92MbFg==", null, false, null, null, null, false, "mariaburggraaff@example.com" },
                    { "29", 0, null, "8d5d040a-5f98-4b39-9546-59673d3f24cb", "katelijnvandekoppel@example.com", false, "Katelijn", "Van de Koppel", false, null, "Katelijn Van de Koppel", null, null, "AQAAAAEAACcQAAAAEDY1qSA2Px3/Bqz3OniazqYJvP3afuQL2ii/87LC0+QvoKLTKFhNPz6qQ/+nZ0NCjg==", null, false, null, null, null, false, "katelijnvandekoppel@example.com" },
                    { "3", 0, null, "3fb2d1eb-b06e-4a02-ae86-5032fd9e334e", "theotan@example.com", false, "Theo", "Tan", false, null, "Theo Tan", null, null, "AQAAAAEAACcQAAAAENareyxKJ8SoYG+RagrOOZW97skzns5w0oNwTLLZOy/lq5gZSc9Z2+ENn59OfgFo5w==", null, false, null, null, null, false, "theotan@example.com" },
                    { "30", 0, null, "f45f21ad-0d21-454e-a261-e4a3e0218d06", "desirescheeren@example.com", false, "Désiré", "Scheeren", false, null, "Désiré Scheeren", null, null, "AQAAAAEAACcQAAAAEAVznLVtvoSryHiyv8XvAJt3hYoCBz1apH6+viAm7itm9gi2EIQjGy+TV72rAqRaKA==", null, false, null, null, null, false, "desirescheeren@example.com" },
                    { "31", 0, null, "a4898afa-1250-4367-885a-e70deeff197a", "daxgabriel@example.com", false, "Dax", "Gabriel", false, null, "Dax Gabriel", null, null, "AQAAAAEAACcQAAAAEBjuT3TmYJf5KM6r+tyT0ENBfEa44BgSAZT7R29NB8uRWGA1imn1G6QKW9N3C5jr/g==", null, false, null, null, null, false, "daxgabriel@example.com" },
                    { "32", 0, null, "3887b870-7923-450d-b651-e70fb2e9d80b", "tommiestel@example.com", false, "Tommie", "Stel", false, null, "Tommie Stel", null, null, "AQAAAAEAACcQAAAAEAJVRnjR6SpGfv4oBE07yijEb/8SgDf1iKqyItDX5a/BR3VSOL8leXO8x8B41+oplA==", null, false, null, null, null, false, "tommiestel@example.com" },
                    { "33", 0, null, "416b5ea2-4463-4d32-b490-9fb7b5fc419e", "raphaelkoppe@example.com", false, "Raphaël", "Koppe", false, null, "Raphaël Koppe", null, null, "AQAAAAEAACcQAAAAEAXV4Ve6cs6nXS07Ld1dVtoBjYZ3Ai69bNrzZlQnyAIzoetjbHwYBSi0By4VxSPBlQ==", null, false, null, null, null, false, "raphaelkoppe@example.com" },
                    { "34", 0, null, "2de1ab60-c03e-4a2a-8d7a-8bba8ecc381a", "demyjongen@example.com", false, "Demy", "Jongen", false, null, "Demy Jongen", null, null, "AQAAAAEAACcQAAAAEPVVQc7Rbst5w5Xq3KVJXY6W8DJ7pY2gbbc1LeNZmUESl+sOFZz/5CTdmz9STo62VA==", null, false, null, null, null, false, "demyjongen@example.com" },
                    { "35", 0, null, "a61743ce-3a20-4223-bcce-119f0667c41a", "leahharreman@example.com", false, "Leah", "Harreman", false, null, "Leah Harreman", null, null, "AQAAAAEAACcQAAAAEFjn7CWIhkOe5FTPDvHpA7yceEQ9KG0Ju9kah/SC/oBrU4DXc9QEDkutU+F1KjF9Hw==", null, false, null, null, null, false, "leahharreman@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "CohortId1", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StudyRouteId", "TimedOut", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "36", 0, null, "aa7b82fd-5c5b-4292-b495-edc60b1725e2", "idrisskorpershoek@example.com", false, "Idriss", "Korpershoek", false, null, "Idriss Korpershoek", null, null, "AQAAAAEAACcQAAAAEAWMHRwHgDc7cwrGuCd6idlHqltvf5mLGGTGk8r3EEZ+wSScw27naKLzkl2U2Oxyzg==", null, false, null, null, null, false, "idrisskorpershoek@example.com" },
                    { "37", 0, null, "705a5423-ad55-4f5a-88b3-f4a3033e1436", "rashiedbleumink@example.com", false, "Rashied", "Bleumink", false, null, "Rashied Bleumink", null, null, "AQAAAAEAACcQAAAAED+cE4T7vRW1BOp1EXYAjz5fjmN2xd9eW6SLSEgC4Hcvr1LoKmmdlDE/SZjuvNxF9A==", null, false, null, null, null, false, "rashiedbleumink@example.com" },
                    { "38", 0, null, "10649cc7-6ae5-496d-a47e-cbcef62bedea", "siay@example.com", false, "Si", "Ay", false, null, "Si Ay", null, null, "AQAAAAEAACcQAAAAECydV1JJ5OcnIKpBbqH3WlVaGJCiA171ctfJEBluflaiTqZiateSSZeDoSMWYiGNnQ==", null, false, null, null, null, false, "siay@example.com" },
                    { "39", 0, null, "f30ee01f-7cc9-4bd4-89f9-bab146640d82", "manolyalebens@example.com", false, "Manolya", "Lebens", false, null, "Manolya Lebens", null, null, "AQAAAAEAACcQAAAAEE7tNRut3EJvrj7xEysLhupFDKIQO5ePflFIG/9uACd8sCtK3czlcGkFJM939qGUhg==", null, false, null, null, null, false, "manolyalebens@example.com" },
                    { "4", 0, null, "40600586-ec40-4bce-9d34-bd5ef20b869b", "cloekras@example.com", false, "Cloé", "Kras", false, null, "Cloé Kras", null, null, "AQAAAAEAACcQAAAAEPtZjVkMxdcTt5tlCMy/McHoldnGqSKk39sIbWao56Z9UwReszoIqEdv+keenYWlAw==", null, false, null, null, null, false, "cloekras@example.com" },
                    { "40", 0, null, "9d018a0c-9b7c-4fae-a353-eef64698214b", "mateuszmachielsen@example.com", false, "Mateusz", "Machielsen", false, null, "Mateusz Machielsen", null, null, "AQAAAAEAACcQAAAAEDPMT96cyyoiBgdGTz35CDRPs/czL+jHBMJzRbxomHKsr0FDelRUJdWsthqH7UEdIA==", null, false, null, null, null, false, "mateuszmachielsen@example.com" },
                    { "41", 0, null, "2f8cc0db-6d95-4060-9b87-cdbf941204db", "douaavandepavert@example.com", false, "Douaa", "Van de Pavert", false, null, "Douaa Van de Pavert", null, null, "AQAAAAEAACcQAAAAEAgu49CIVkpP8UzhJeFq/fv/MtVkE/DMlVBDj7zNQ+HB7iWoBufjujzyT6eD7NNvxg==", null, false, null, null, null, false, "douaavandepavert@example.com" },
                    { "42", 0, null, "6455860e-4a44-403f-ba2c-0cc6c36f42ba", "kishanhoogkamp@example.com", false, "Kishan", "Hoogkamp", false, null, "Kishan Hoogkamp", null, null, "AQAAAAEAACcQAAAAEE6dU43XG1oy6pAOmMcUG2J1c6Qf52pT7RMEsqZY6j0B7jWVt9E1Y7v7UWlyLs2RXg==", null, false, null, null, null, false, "kishanhoogkamp@example.com" },
                    { "43", 0, null, "a50a45bf-bf5e-4e61-a7e2-2094e53fdb7d", "harmjanversendaal@example.com", false, "Harmjan", "Versendaal", false, null, "Harmjan Versendaal", null, null, "AQAAAAEAACcQAAAAEE0SBxSAX6jOC+zThojwol6hSzrKnZuNa2DBzGo2wgm0gZEDcszH5EGKfW4cHmHARQ==", null, false, null, null, null, false, "harmjanversendaal@example.com" },
                    { "5", 0, null, "0c8e2bc4-3a0b-4971-9988-d3b582608d92", "maurivannuland@example.com", false, "Mauri", "Van Nuland", false, null, "Mauri Van Nuland", null, null, "AQAAAAEAACcQAAAAEE11cENu6PmDpZ1AAWnUfq5jnxrbtdv8P/4msDQ9kDbkkR3rF5G+SFHPESXM7bk0+w==", null, false, null, null, null, false, "maurivannuland@example.com" },
                    { "6", 0, null, "b3375715-f2b3-43ec-a555-2b8d79ad75bd", "jeromeheerink@example.com", false, "Jerome", "Heerink", false, null, "Jerome Heerink", null, null, "AQAAAAEAACcQAAAAECQGbYSrrdFtuHGk/CoktpSbJQvlq6AX7qd+oeZXPkN2m6JnzwsV7Cxa6EbgX73DKA==", null, false, null, null, null, false, "jeromeheerink@example.com" },
                    { "7", 0, null, "efed9382-ad95-4799-b612-6552eb55e240", "semihvanburken@example.com", false, "Semih", "Van Burken", false, null, "Semih Van Burken", null, null, "AQAAAAEAACcQAAAAELCWuZwG1ys1Iv+SB/6mHNHmuxjODXrKnI27Rbvtl3dDdhr5FmkHds1zc2MxPhX4QQ==", null, false, null, null, null, false, "semihvanburken@example.com" },
                    { "8", 0, null, "bfb1aa71-e336-4249-8845-5e6cda3e11d7", "jacomijntjemoraal@example.com", false, "Jacomijntje", "Moraal", false, null, "Jacomijntje Moraal", null, null, "AQAAAAEAACcQAAAAELxzs4OyXuMH7D+p8YRN9zEMOyBpOolQhJ8Hz6NCBE/V18n//c8TOhK31lL1yhcU3Q==", null, false, null, null, null, false, "jacomijntjemoraal@example.com" },
                    { "9", 0, null, "44c1ae38-7c7c-4ed6-8307-e751e18d0e8f", "sjuulalma@example.com", false, "Sjuul", "Alma", false, null, "Sjuul Alma", null, null, "AQAAAAEAACcQAAAAEB1gn76XvU8j/DXIMyge04zk68PMoyPbW3rooD8uXEoM3X+xGlPHWB/R0GAQmX52cg==", null, false, null, null, null, false, "sjuulalma@example.com" }
                });

            migrationBuilder.InsertData(
                table: "CohortSemesterItems",
                columns: new[] { "CohortsId", "SemesterItemsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 4, 3 },
                    { 4, 4 }
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
                table: "StudyRouteItems",
                columns: new[] { "Id", "Semester", "SemesterItemId", "StudyRouteId", "Year" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 2023 },
                    { 2, 1, 2, 1, 2023 },
                    { 3, 1, 3, 1, 2023 },
                    { 4, 1, 4, 1, 2023 }
                });

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
                    { 2, "30" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RolesId", "UsersId" },
                values: new object[,]
                {
                    { 2, "31" },
                    { 2, "32" },
                    { 2, "33" },
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
                name: "IX_UserRoles_UsersId",
                table: "UserRoles",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CohortId1",
                table: "Users",
                column: "CohortId1");

            migrationBuilder.CreateIndex(
                name: "IX_Users_StudyRouteId",
                table: "Users",
                column: "StudyRouteId");

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
                name: "Roles");

            migrationBuilder.DropTable(
                name: "SemesterItems");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Cohorts");

            migrationBuilder.DropTable(
                name: "StudyRoutes");
        }
    }
}
