using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace keuzewijzer_hbo_deeltijd_ict_API.Migrations
{
    public partial class Initial : Migration
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
                    { 8, "Description for Semester Item 8", "Semester Item 8", 2, "[2]" },
                    { 999, "Reparatiesemester", "Reparatiesemester", 1, "[1,2]" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "CohortId1", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TimedOut", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, null, "ccd5b25e-a230-4831-9729-15d333db3090", "admin@example.com", false, "Arnold", "Min", false, null, "Arnold Dirk Min", null, null, "AQAAAAEAACcQAAAAEIGvM+de233XPuOQIuectMSga5jOk3MDKB/TMDCBUydVEWEdIjrKxaeVaVWIj0Sf2A==", null, false, null, null, false, "admin@example.com" },
                    { "10", 0, null, "4e6e5b07-fa2e-4171-8550-bb5265b9dbe4", "sharonapouw@example.com", false, "Sharona", "Pouw", false, null, "Sharona Pouw", null, null, "AQAAAAEAACcQAAAAEGXSz63SRUWgFYRx6BY2ZrJGCxnGA4q1hRFdWSglWXFRYMJfMauH0xtOmZe/xipiTA==", null, false, null, null, false, "sharonapouw@example.com" },
                    { "11", 0, null, "686776d0-8186-4e71-896e-9ba7fe1cc3fd", "ashwienabbenhuis@example.com", false, "Ashwien", "Abbenhuis", false, null, "Ashwien Abbenhuis", null, null, "AQAAAAEAACcQAAAAEFWrPd9N31BVA+McUB5prNcTjIw65E/P/hUty+o4ew7kVa/tWlsf1GunpJr72huiNQ==", null, false, null, null, false, "ashwienabbenhuis@example.com" },
                    { "12", 0, null, "0d985615-1ea1-4bc2-a07a-c3abb3cf508b", "raulverdaasdonk@example.com", false, "Raul", "Verdaasdonk", false, null, "Raul Verdaasdonk", null, null, "AQAAAAEAACcQAAAAEM/09CxCAL8uCfC8P1i+nlukJhpUjIgkfrLz4f5wfauOcrLMKDt5eOF/b82yhzab3w==", null, false, null, null, false, "raulverdaasdonk@example.com" },
                    { "13", 0, null, "b47fea9c-e1d9-4776-8588-bcf169f462da", "majellawessels@example.com", false, "Majella", "Wessels", false, null, "Majella Wessels", null, null, "AQAAAAEAACcQAAAAEF+RkX8f4cX3jUvRUP650ejXmM0koWduEYsOt5omf3Zt99Pzum5sQAvMmUVAM9KHHA==", null, false, null, null, false, "majellawessels@example.com" },
                    { "14", 0, null, "68007cd6-8871-4f3b-8beb-f0484103cff2", "kwintlogtenberg@example.com", false, "Kwint", "Logtenberg", false, null, "Kwint Logtenberg", null, null, "AQAAAAEAACcQAAAAEDahxe8ErlX0ZLdT0yjWTKxknihiLSe2QxjE32lk7mIJYNSsyfmh6VXPmrGvbtWKdA==", null, false, null, null, false, "kwintlogtenberg@example.com" },
                    { "15", 0, null, "d4ed38e2-fe25-4cbc-a791-de737f8afdb2", "mikhaillebbink@example.com", false, "Mikhail", "Lebbink", false, null, "Mikhail Lebbink", null, null, "AQAAAAEAACcQAAAAEAffMx/s7OZHRVQoXBuSrKzm7NzLSykzOOl/DiCm7AVA+vAOBMLS0oH4YzogphZYQA==", null, false, null, null, false, "mikhaillebbink@example.com" },
                    { "16", 0, null, "3b4bac95-324f-41ef-ba88-cb6e430af920", "claylier@example.com", false, "Clay", "Lier", false, null, "Clay Lier", null, null, "AQAAAAEAACcQAAAAEFHnj6XKXprm0KCgS+5gDSjB7/TJA5/jG8+zncqeNL9fjs5g1pHI7s3KJxd/kURm3A==", null, false, null, null, false, "claylier@example.com" },
                    { "17", 0, null, "48c9300f-286b-4fc3-8f77-3b7030b9ec20", "rubinavanderhout@example.com", false, "Rubina", "Van der Hout", false, null, "Rubina Van der Hout", null, null, "AQAAAAEAACcQAAAAEGaEq+gEVIlEPxSje5hclML86PLb7pBF8jGDcZC/iZMn+MHbh1rwJOLUn4sbcNCxeA==", null, false, null, null, false, "rubinavanderhout@example.com" },
                    { "18", 0, null, "6e656ade-fcee-4bd9-8083-c73a7e76c8f5", "abderrazakblaauwbroek@example.com", false, "Abderrazak", "Blaauwbroek", false, null, "Abderrazak Blaauwbroek", null, null, "AQAAAAEAACcQAAAAEA5b5tEUrlquWQlcx1PDKuu2Yxj1SA52cPZpbcdKbGDzci0qLiCUp/+ucl29oKL8pw==", null, false, null, null, false, "abderrazakblaauwbroek@example.com" },
                    { "19", 0, null, "fdb0f05a-e38d-4dab-a097-7e6e1758b6ad", "yannikconsten@example.com", false, "Yannik", "Consten", false, null, "Yannik Consten", null, null, "AQAAAAEAACcQAAAAEAZnC6r3SGfkKbqKWiSyNchIKkMrs59Yo90S3YF1v3HAO5+tcgrMBsE6UPboBIORVg==", null, false, null, null, false, "yannikconsten@example.com" },
                    { "2", 0, null, "968d9d1d-d323-4503-a45b-9d279be3533c", "eugenevanroden@example.com", false, "Eugene", "Van Roden", false, null, "Eugene Van Roden", null, null, "AQAAAAEAACcQAAAAEM+mwdNLiz9IdGy2D2An89Kqwpl/dXjSdvsd/CRBugfvhY6ST6jxaoXOz4UuqztGzQ==", null, false, null, null, false, "eugenevanroden@example.com" },
                    { "20", 0, null, "460bc0a9-cda3-4d35-ae12-defe14bbd041", "niniboekhoudt@example.com", false, "Nini", "Boekhoudt", false, null, "Nini Boekhoudt", null, null, "AQAAAAEAACcQAAAAEOFtHrH7ZccWw9DZApl3BAVZpbgTCi3BXcMoDlo8CMC2zqq6LGMpFOh5AVLVeabSzA==", null, false, null, null, false, "niniboekhoudt@example.com" },
                    { "21", 0, null, "21f13b47-0541-4b40-9659-3d148fb9fa6b", "mounssifborkent@example.com", false, "Mounssif", "Borkent", false, null, "Mounssif Borkent", null, null, "AQAAAAEAACcQAAAAEAEZ9h0ZWUprD+33IfgnxVCmp7+MqQzc6udSWabWC6SmVrVSowLMjn8TqFuLIeIk/g==", null, false, null, null, false, "mounssifborkent@example.com" },
                    { "22", 0, null, "0e3d8287-daef-416e-900f-fd5f3ebdee15", "metjeknoef@example.com", false, "Metje", "Knoef", false, null, "Metje Knoef", null, null, "AQAAAAEAACcQAAAAEBKDC/BtEW4ftzpx9ulJqki8jccDIPIm58cq/g1MW1H0QZBfhGBZPDPjjCzDSzGW7g==", null, false, null, null, false, "metjeknoef@example.com" },
                    { "23", 0, null, "269700d4-b0e3-4912-8f05-c610ba8e0641", "lolkjehagoort@example.com", false, "Lolkje", "Hagoort", false, null, "Lolkje Hagoort", null, null, "AQAAAAEAACcQAAAAEJ8wz9YUfwl8qB3/Ce7ojjo+fYZVz1TcIprFO/REAqQ6amKhnvO6Yecyt/QoWxXxjg==", null, false, null, null, false, "lolkjehagoort@example.com" },
                    { "24", 0, null, "5fb6e859-3092-4650-b891-087ac93eaa06", "sabriadenissen@example.com", false, "Sabria", "Denissen", false, null, "Sabria Denissen", null, null, "AQAAAAEAACcQAAAAEC2MS30b3wpZz0mLpa/8Isxc6yMlQQ3fvm17NWcHVWl6I7tBPkvgCpD3oyjdCZkJAA==", null, false, null, null, false, "sabriadenissen@example.com" },
                    { "25", 0, null, "37592073-4964-40d8-956e-b68f48c4f0d0", "farukvanschip@example.com", false, "Faruk", "Van Schip", false, null, "Faruk Van Schip", null, null, "AQAAAAEAACcQAAAAEJbPNWVkrggoI2iiCs3fGAqIj2+SX5v8hVHeIWg+2fVSQGiinX2hYONXzhAFB4XCgQ==", null, false, null, null, false, "farukvanschip@example.com" },
                    { "26", 0, null, "3cc9b725-21d6-4a9d-922d-29a2a0b89bfb", "zakariadraaisma@example.com", false, "Zakaria", "Draaisma", false, null, "Zakaria Draaisma", null, null, "AQAAAAEAACcQAAAAEBRlrzi/61qr9+NaMknaAJDb9U7Opig8QMdNk3la9vjVPxzWzJIKmPxH5fZZ+Xhelw==", null, false, null, null, false, "zakariadraaisma@example.com" },
                    { "27", 0, null, "c289888f-3519-4057-9fb0-4154494709ba", "oguzheessels@example.com", false, "Oguz", "Heessels", false, null, "Oguz Heessels", null, null, "AQAAAAEAACcQAAAAEE+/gY8ZTfHCiEQvZCZkcj6/vrqoO7eMKH3wx/GSt0FbyEkCbNGxYmMwUqQYECrLhw==", null, false, null, null, false, "oguzheessels@example.com" },
                    { "28", 0, null, "d0c3d9e8-fc3a-4e83-bf5f-6e12bd93736a", "mariaburggraaff@example.com", false, "Maria", "Burggraaff", false, null, "Maria Burggraaff", null, null, "AQAAAAEAACcQAAAAEF+jZe+GqXHa1NPFC3vJykYnMcrobBct+rrOP/bYZGv3j2T0qkmGO+M3LcU/kiu+nQ==", null, false, null, null, false, "mariaburggraaff@example.com" },
                    { "29", 0, null, "a0758c51-7740-4ebe-8359-1373a28bc496", "katelijnvandekoppel@example.com", false, "Katelijn", "Van de Koppel", false, null, "Katelijn Van de Koppel", null, null, "AQAAAAEAACcQAAAAEFbCs5suT4aVlRiu03l5OC6YheOlSakElCj9G41edLhS6bWPAk2xTd/3jjliprgxXw==", null, false, null, null, false, "katelijnvandekoppel@example.com" },
                    { "3", 0, null, "9a8f8739-2768-4d90-9e77-cd54df7cebf7", "theotan@example.com", false, "Theo", "Tan", false, null, "Theo Tan", null, null, "AQAAAAEAACcQAAAAENVLJP5FBCZGtpqAebnnOfEq6ylerUm9R29TzJGR7n4onLedTXpu8Owcz15wNa/L/A==", null, false, null, null, false, "theotan@example.com" },
                    { "30", 0, null, "6e3f5e47-0bb9-40b3-8557-abd2c6f73144", "desirescheeren@example.com", false, "Désiré", "Scheeren", false, null, "Désiré Scheeren", null, null, "AQAAAAEAACcQAAAAEPQPlBwmdmQrAqbuSCq0+MW2sjvgZCbl4P+jr2Ey1NGlOtd98pXv1l8UkEjfbiL6Hw==", null, false, null, null, false, "desirescheeren@example.com" },
                    { "31", 0, null, "bb8446eb-55b4-48aa-8a38-3d0c51479c96", "daxgabriel@example.com", false, "Dax", "Gabriel", false, null, "Dax Gabriel", null, null, "AQAAAAEAACcQAAAAECTAhNnNFqaI2ywXiJ6O9/zNIbHmw0HbGMbfE0QxCj4qLhtvGc2M1+GXY4NtUkAC6Q==", null, false, null, null, false, "daxgabriel@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "CohortId1", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TimedOut", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "32", 0, null, "3e17756d-a7de-4050-bbf9-ded2367e8a53", "tommiestel@example.com", false, "Tommie", "Stel", false, null, "Tommie Stel", null, null, "AQAAAAEAACcQAAAAEL68gbSDRv5dp8cN3cQyPidJvsf8L5iuvoD67NAMcF2PjU8o3fpDzvhGrjkgQSZ7XQ==", null, false, null, null, false, "tommiestel@example.com" },
                    { "33", 0, null, "0297dd36-3523-4c10-b605-949aad4ae44e", "raphaelkoppe@example.com", false, "Raphaël", "Koppe", false, null, "Raphaël Koppe", null, null, "AQAAAAEAACcQAAAAEPkXCVzv+WCC4xkr/ZlvtRgM0YLo29FPkMvitg9Dn4v1ZSxQEICNjaFexESxCuzbng==", null, false, null, null, false, "raphaelkoppe@example.com" },
                    { "34", 0, null, "7cc3c189-f07b-4864-972b-a7ce1456136b", "demyjongen@example.com", false, "Demy", "Jongen", false, null, "Demy Jongen", null, null, "AQAAAAEAACcQAAAAECFNlIbHM9BIkmSbas9/puNeKD5ECwkKvqmW3lU10XmVFuMkXmenhBf7CqC+lF5wvA==", null, false, null, null, false, "demyjongen@example.com" },
                    { "35", 0, null, "af4821d5-0291-4761-999c-94ea8dc41064", "leahharreman@example.com", false, "Leah", "Harreman", false, null, "Leah Harreman", null, null, "AQAAAAEAACcQAAAAEIWXXMgmxUkRv91GqgFJtKxWePx9pZ/OgkN1Rp5UAVH/TVPECNa1Ls4FtpyMpIXgRw==", null, false, null, null, false, "leahharreman@example.com" },
                    { "36", 0, null, "01c47fc8-055e-4158-85b0-c4f647df91d1", "idrisskorpershoek@example.com", false, "Idriss", "Korpershoek", false, null, "Idriss Korpershoek", null, null, "AQAAAAEAACcQAAAAEPAe8J0f2JFHlQk4e9NQZ5CaOBGfCUcuCrWZSam3VCY4ddXVhJGqUyFm6l+PobX+hQ==", null, false, null, null, false, "idrisskorpershoek@example.com" },
                    { "37", 0, null, "415cfc36-e887-44fb-9663-3e2761fdb90a", "rashiedbleumink@example.com", false, "Rashied", "Bleumink", false, null, "Rashied Bleumink", null, null, "AQAAAAEAACcQAAAAEGv0Nle8ZGWgYyd3z04j99H7d8LkMHRcJ3X9Gj7DA2a9P0fsU+evTMYJ4JJbQn/3gA==", null, false, null, null, false, "rashiedbleumink@example.com" },
                    { "38", 0, null, "e522da41-fd14-455e-9bfd-abad8ec0ead2", "siay@example.com", false, "Si", "Ay", false, null, "Si Ay", null, null, "AQAAAAEAACcQAAAAEE6RuZqscMmq/+qyW9WbJZ8qYjAFQb3E0L+UMuKrQyRh9axTPmv6AapSbqEtQ7jGQA==", null, false, null, null, false, "siay@example.com" },
                    { "39", 0, null, "4b7abe6a-9313-4d59-876a-4d88110813b3", "manolyalebens@example.com", false, "Manolya", "Lebens", false, null, "Manolya Lebens", null, null, "AQAAAAEAACcQAAAAEBFWER/AFTfc7na+Ief+VExmkKD9mQ8a/gbPOTij8mCb+/4tg2RV0t8ALOu7EwQ6WQ==", null, false, null, null, false, "manolyalebens@example.com" },
                    { "4", 0, null, "097b31db-47ca-4942-adb0-822506144702", "cloekras@example.com", false, "Cloé", "Kras", false, null, "Cloé Kras", null, null, "AQAAAAEAACcQAAAAEPtmLv9rwtTpHWylVCxMv2g5rH8zuUZpIlUYJg3NJuoQZGjssbmVyZBI0U22UaTDXQ==", null, false, null, null, false, "cloekras@example.com" },
                    { "40", 0, null, "4c0e8259-074d-4dfc-a2c1-c2aed0b81156", "mateuszmachielsen@example.com", false, "Mateusz", "Machielsen", false, null, "Mateusz Machielsen", null, null, "AQAAAAEAACcQAAAAEAB5bIuLKraIiY3gFn/0XnsQDQeGK80xzoKPJ0XesR4y50pH30nEWf++t+uak3mm1g==", null, false, null, null, false, "mateuszmachielsen@example.com" },
                    { "41", 0, null, "a5833e7a-3f0d-4c7f-b61a-5bb3215b0efd", "douaavandepavert@example.com", false, "Douaa", "Van de Pavert", false, null, "Douaa Van de Pavert", null, null, "AQAAAAEAACcQAAAAEHI754XMCa/RO1ZjGrUf2XJm1fQ2fmIFAzHLAwT41fgim2CSMKsOvtMZz0LKC+WwHA==", null, false, null, null, false, "douaavandepavert@example.com" },
                    { "42", 0, null, "1421db28-e462-4116-b1cd-965e4f2001e1", "kishanhoogkamp@example.com", false, "Kishan", "Hoogkamp", false, null, "Kishan Hoogkamp", null, null, "AQAAAAEAACcQAAAAEEYpX5JRSgdKRbhuARDocFsq1PUqIqwNt3NFRlCD+8ApQK6Ap2qvxnmlbK672zJGVA==", null, false, null, null, false, "kishanhoogkamp@example.com" },
                    { "43", 0, null, "55f62875-a3da-4dd2-99fe-7c3974da26d9", "harmjanversendaal@example.com", false, "Harmjan", "Versendaal", false, null, "Harmjan Versendaal", null, null, "AQAAAAEAACcQAAAAENnD4Glpd/Qd13YjiM87ysj6O3BJzkasbMxB/DJRzO6BmaHr8KKXo/FvEShrOHHsqQ==", null, false, null, null, false, "harmjanversendaal@example.com" },
                    { "5", 0, null, "3ba86fea-f648-4f9a-b34e-ade4ebd2e281", "maurivannuland@example.com", false, "Mauri", "Van Nuland", false, null, "Mauri Van Nuland", null, null, "AQAAAAEAACcQAAAAEN62Uny2XaSCKeYHyI7Y/46z59DjlRPJwGJamK3RuvdAuw8AMkkbCLt8/gqh6HL0UA==", null, false, null, null, false, "maurivannuland@example.com" },
                    { "6", 0, null, "40041dd3-4498-44a7-b9e8-b553d4e26812", "jeromeheerink@example.com", false, "Jerome", "Heerink", false, null, "Jerome Heerink", null, null, "AQAAAAEAACcQAAAAEApNW2EGY9JgD7zMHxIaP9eyrgZecDUstWtpefHwOoHhfK/II2UE1YfKVAZTAq/rEg==", null, false, null, null, false, "jeromeheerink@example.com" },
                    { "7", 0, null, "bacd4a4a-4ff5-40c7-abb7-7781ee0bd981", "semihvanburken@example.com", false, "Semih", "Van Burken", false, null, "Semih Van Burken", null, null, "AQAAAAEAACcQAAAAEN/mmXg4f5FgRqYouKZwDo01Jcyr9UH3bvms3DX08zP1u6M0pzTWE1Ov5ICyRAUweQ==", null, false, null, null, false, "semihvanburken@example.com" },
                    { "8", 0, null, "6feb6258-e250-4e9a-bea0-e28050448a0a", "jacomijntjemoraal@example.com", false, "Jacomijntje", "Moraal", false, null, "Jacomijntje Moraal", null, null, "AQAAAAEAACcQAAAAEFDwqycci/oVncNChmASWV8NgdoRZKdYKmR1SQE8lXLIMnFTwNAvu9oNqovXa7LfoA==", null, false, null, null, false, "jacomijntjemoraal@example.com" },
                    { "9", 0, null, "2c4dd41a-f6a1-4fa9-a0f9-3c394b0e5d53", "sjuulalma@example.com", false, "Sjuul", "Alma", false, null, "Sjuul Alma", null, null, "AQAAAAEAACcQAAAAEHDJKv1a1nRMoCcVyVLmLnnWH89mCju59Pm/tIFBxMyI69LzcAWxUBHKTOTHoGPURw==", null, false, null, null, false, "sjuulalma@example.com" }
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
                    { 4, 8 },
                    { 4, 999 }
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
                    { 2, "32" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RolesId", "UsersId" },
                values: new object[,]
                {
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
