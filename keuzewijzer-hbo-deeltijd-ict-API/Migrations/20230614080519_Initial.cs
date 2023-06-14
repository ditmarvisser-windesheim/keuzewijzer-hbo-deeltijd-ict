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
                    { "1", "731db72a-f32b-43ee-b910-94b4b62935c8", "Administrator", "ADMINISTRATOR" },
                    { "2", "9f4d8356-6817-4ec3-ba91-79f4752be21d", "Student", "STUDENT" },
                    { "3", "a3958721-266b-4749-8c75-7cdd2ed59af1", "Studiebegeleider", "STUDIEBEGELEIDER" },
                    { "4", "451d966d-bd30-4648-b3bd-ed7d753009fe", "Moduleverantwoordelijke", "MODULEVERANTWOORDELIJKE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CohortId1", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TimedOut", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, null, "2a24be12-a5dd-469d-b057-0256f3ba643b", "admin@example.com", false, "Arnold", "Min", false, null, "Arnold Dirk Min", "admin@example.com", "admin", "AQAAAAEAACcQAAAAEI2GrCBWwOlBSxIqhYhSAKmt0gdVVYeLfR7WHPvRR9UqjyGJ7NDF2sBE0W0gknKeOg==", null, false, null, null, false, "admin" },
                    { "10", 0, null, "66ba1736-676f-4cd7-b8e6-1fa51c961eb5", "nikhuijskens@example.com", false, "Nik", "Huijskens", false, null, "Nik Huijskens", "nikhuijskens@example.com", "nikhuijskens", "AQAAAAEAACcQAAAAEDs8QcukrRTUYrX6I0hra6c7IQ55IEsyz90VayeCFDV7G6ZmPc1RC4DFGMqbjSkz/w==", null, false, null, null, false, "nikhuijskens" },
                    { "11", 0, null, "a110cb18-e094-4547-b176-9ab658dcb0d2", "duranpetiet@example.com", false, "Duran", "Petiet", false, null, "Duran Petiet", "duranpetiet@example.com", "duranpetiet", "AQAAAAEAACcQAAAAEB3wamY+AgIwe61JTo6D9jlLUjoeh5Uny4n0h1WeDhzyehhIJ7p5T23OerxfFG7JQw==", null, false, null, null, false, "duranpetiet" },
                    { "12", 0, null, "217a3492-bacd-4553-bc0d-57531f41cffd", "veroniekbravenboer@example.com", false, "Veroniek", "Bravenboer", false, null, "Veroniek Bravenboer", "veroniekbravenboer@example.com", "veroniekbravenboer", "AQAAAAEAACcQAAAAEGz4GYg3mpcqcYlwd8F+n5oEoDuEO7Vv18hMHlcpfzDuip74RBLz2B+uVCKz02yGIQ==", null, false, null, null, false, "veroniekbravenboer" },
                    { "13", 0, null, "37c75cf1-ccb0-440d-80fe-b829262c7321", "kaynejagtenberg@example.com", false, "Kayne", "Jagtenberg", false, null, "Kayne Jagtenberg", "kaynejagtenberg@example.com", "kaynejagtenberg", "AQAAAAEAACcQAAAAEBnZOtFZryiTiBY1H6A499YBdVR/SBKnOR9EEh2lJ1U+ttIXrl5tRcnq09+usjxjzQ==", null, false, null, null, false, "kaynejagtenberg" },
                    { "14", 0, null, "69ed45b6-5026-4a6d-beb2-e4ce849e4081", "siebrigjeabdi@example.com", false, "Siebrigje", "Abdi", false, null, "Siebrigje Abdi", "siebrigjeabdi@example.com", "siebrigjeabdi", "AQAAAAEAACcQAAAAEMvyOyIts7Nj5GKCeempNv5xFolVext5OBOUGatyxO8Kdu+6u/LoLvNAxvxuGFidyw==", null, false, null, null, false, "siebrigjeabdi" },
                    { "15", 0, null, "3953ea5b-902f-47c5-85bd-d89636a0a071", "sterrelambert@example.com", false, "Sterre", "Lambert", false, null, "Sterre Lambert", "sterrelambert@example.com", "sterrelambert", "AQAAAAEAACcQAAAAEPlAZ1Es7nOhKoKteQX2J7cjPHZ1RDq3fgJUaAtNbqeZQZYu1Fw7WOXj2ygCGTfKhg==", null, false, null, null, false, "sterrelambert" },
                    { "16", 0, null, "645a6331-36cf-4d41-a29a-a5df74a88955", "milicavandergouw@example.com", false, "Milica", "Van der Gouw", false, null, "Milica Van der Gouw", "milicavandergouw@example.com", "milicavandergouw", "AQAAAAEAACcQAAAAEByP3zLEp32lnJgTvZ+zmt2DuW8CrGK8cNdR+ayQcR7hkhXPMsAAN0Ev2d/8KLtqvA==", null, false, null, null, false, "milicavandergouw" },
                    { "17", 0, null, "8c4924ce-27e8-4ca9-9710-5194e9eac8f0", "yvonbrussaard@example.com", false, "Yvon", "Brussaard", false, null, "Yvon Brussaard", "yvonbrussaard@example.com", "yvonbrussaard", "AQAAAAEAACcQAAAAEFVN1eu9v6AaKt2lN21uqi9b7RgLnrw5+6S+fTbTQD+GVVXdhbL//bp6MtlywPi6rQ==", null, false, null, null, false, "yvonbrussaard" },
                    { "18", 0, null, "7b59ccd4-56eb-4ca8-9ca6-13d28fcd518c", "bodhidatema@example.com", false, "Bodhi", "Datema", false, null, "Bodhi Datema", "bodhidatema@example.com", "bodhidatema", "AQAAAAEAACcQAAAAEGeRA60HUL2/1pHyn+YrjNBLTCVKuYHU+wdZXtnemPxT9CSQvQjkYNH5HunXHHfH5w==", null, false, null, null, false, "bodhidatema" },
                    { "19", 0, null, "af24c113-5dd3-420b-b024-3e3a93c6c037", "noachschutrups@example.com", false, "Noach", "Schutrups", false, null, "Noach Schutrups", "noachschutrups@example.com", "noachschutrups", "AQAAAAEAACcQAAAAEE3tV4rkw0KspWTuKA7dZLELReuw8wSR8jbZGdPFXFd+GmT0L7QzGCmorjFcm3LuOQ==", null, false, null, null, false, "noachschutrups" },
                    { "2", 0, null, "565f888d-abaa-4e9e-be49-94b5530e81a4", "eugenevanroden@example.com", false, "Eugene", "Van Roden", false, null, "Eugene Van Roden", "eugenevanroden@example.com", "eugenevanroden", "AQAAAAEAACcQAAAAEHaK8Gcn6A1E15h5FnbKgXUac4syYlQxOCXUKaPqvndx7HaiReVCTBmCY0HkhdqaWA==", null, false, null, null, false, "eugenevanroden" },
                    { "20", 0, null, "3d67ad17-fb64-4a37-944a-23c25b1fb99e", "ouassimbekking@example.com", false, "Ouassim", "Bekking", false, null, "Ouassim Bekking", "ouassimbekking@example.com", "ouassimbekking", "AQAAAAEAACcQAAAAEBfCA2jN6yFZYmxgFroj3XQbaOj0E06/20cX2f68zywTzY+WuoOj0B0DdkIKlb8eFg==", null, false, null, null, false, "ouassimbekking" },
                    { "21", 0, null, "747b6f52-80e1-4fc0-ad0e-cd98c3a977d6", "noervanderkruit@example.com", false, "Noer", "Van der Kruit", false, null, "Noer Van der Kruit", "noervanderkruit@example.com", "noervanderkruit", "AQAAAAEAACcQAAAAELIop8YZylbNC9i9HJl8JZsm/qnoQBZlXRmsXr/RGRA2cQFaEALLKaYclcmfhfn1Hw==", null, false, null, null, false, "noervanderkruit" },
                    { "22", 0, null, "555d3725-74ca-4b0d-9548-50d4f0063ab6", "kaanvanmaarseveen@example.com", false, "Kaan", "Van Maarseveen", false, null, "Kaan Van Maarseveen", "kaanvanmaarseveen@example.com", "kaanvanmaarseveen", "AQAAAAEAACcQAAAAEBaGaB+Jpr4wtbMr91O92cKo2QYBvFnAFllsF71GJfg/v3FIWCkGtz1DdXGTTHkFRA==", null, false, null, null, false, "kaanvanmaarseveen" },
                    { "23", 0, null, "11bb3ff2-8b7e-4434-9943-c47e8192534f", "owenkaal@example.com", false, "Owen", "Kaal", false, null, "Owen Kaal", "owenkaal@example.com", "owenkaal", "AQAAAAEAACcQAAAAENfx4TKNrQKJU60Yl/X4v9YU7gYTdgII91YKdN+fIyfewRgqcvv+wg+ruUeNcsg2Sw==", null, false, null, null, false, "owenkaal" },
                    { "24", 0, null, "27015288-1ebb-46a9-8a0c-e4b867127800", "paulinebah@example.com", false, "Pauline", "Bah", false, null, "Pauline Bah", "paulinebah@example.com", "paulinebah", "AQAAAAEAACcQAAAAECcw2CehW6Vz1RDpXKM8TxVT5bXYBiqPJZAt7p1Rp16+H1N5u7Xmw/wykpP7frKXaQ==", null, false, null, null, false, "paulinebah" },
                    { "25", 0, null, "a0428417-3eb1-4f2d-aa60-3e92383d4f0d", "caterinatas@example.com", false, "Caterina", "Tas", false, null, "Caterina Tas", "caterinatas@example.com", "caterinatas", "AQAAAAEAACcQAAAAEIa7Gb+a/0brpf1eW81i1zYp6OikmS6XcXxDrzIfqQIpAhVkiSC3N4sDeMh8c9o11A==", null, false, null, null, false, "caterinatas" },
                    { "26", 0, null, "77592cb9-0024-4122-8647-e30f69a70e51", "edtouw@example.com", false, "Ed", "Touw", false, null, "Ed Touw", "edtouw@example.com", "edtouw", "AQAAAAEAACcQAAAAEPcZ24oPnS6GRVCpKP7MEq3kX27ft4ZcA/UgyMbX4WuqTo3UToV2bNmb2D+b0ksIDg==", null, false, null, null, false, "edtouw" },
                    { "27", 0, null, "f521dfa1-7910-4d65-9d38-c2ff69cf36d0", "hugofidom@example.com", false, "Hugo", "Fidom", false, null, "Hugo Fidom", "hugofidom@example.com", "hugofidom", "AQAAAAEAACcQAAAAECg84n9kHGOpfzkRKkgq9oiTL7EGNLNOPgYmfRG3rdBZ51woS7lqOydKSWIcuBnK8w==", null, false, null, null, false, "hugofidom" },
                    { "28", 0, null, "a41f3009-21db-41b7-b7e5-6a6dcc2009f5", "nannebesseling@example.com", false, "Nanne", "Besseling", false, null, "Nanne Besseling", "nannebesseling@example.com", "nannebesseling", "AQAAAAEAACcQAAAAEL98nbmpw+fZaiYn9mB3azvhmSC+Y/2jsgT/LALv8yXZfBUWWFonDh4FVG8KcEogKg==", null, false, null, null, false, "nannebesseling" },
                    { "29", 0, null, "9ddb73d9-fcd8-42f3-8b0b-6f68343c7671", "teunisjesalden@example.com", false, "Teunisje", "Salden", false, null, "Teunisje Salden", "teunisjesalden@example.com", "teunisjesalden", "AQAAAAEAACcQAAAAEGw24FBmLFv8ARX6/tVPFijZN3kgGt70lFrjBO+eqep4qxXsHI92LFI9ZUYId9UeJg==", null, false, null, null, false, "teunisjesalden" },
                    { "3", 0, null, "faf55721-4af6-4500-a4aa-69eb989d1b22", "theotan@example.com", false, "Theo", "Tan", false, null, "Theo Tan", "theotan@example.com", "theotan", "AQAAAAEAACcQAAAAEHQTv8Z0STJK+8n0+rod/6UWwTLmfgfA3YmIc9ik9Da1OzABwco8dRS6GCrhlYqweg==", null, false, null, null, false, "theotan" },
                    { "30", 0, null, "72ec2dcd-c4dd-4ed1-a26e-4b187b5982c8", "rochedoornink@example.com", false, "Roché", "Doornink", false, null, "Roché Doornink", "rochedoornink@example.com", "rochedoornink", "AQAAAAEAACcQAAAAEK0Zt1SuHIIsbE2c0jr82Bce7RfNHTe1vwDxfYnyq+RwdBtvFp4ff8wI9yKfrVn0jg==", null, false, null, null, false, "rochedoornink" },
                    { "31", 0, null, "e5925f9b-2f41-4462-8ea5-5d515cdc8230", "yuenboertien@example.com", false, "Yuen", "Boertien", false, null, "Yuen Boertien", "yuenboertien@example.com", "yuenboertien", "AQAAAAEAACcQAAAAEOuPXcOaDC4sH76vZs7n3NaKaMFODBPQgtI7b3c9owMuNV4YLn/8eUbxiD959bHF8w==", null, false, null, null, false, "yuenboertien" },
                    { "32", 0, null, "c989f03f-0bbd-40f4-941a-b948dafeec29", "heinrichmook@example.com", false, "Heinrich", "Mook", false, null, "Heinrich Mook", "heinrichmook@example.com", "heinrichmook", "AQAAAAEAACcQAAAAEJXtdjRwAhhskxZHi7w07GeplRbOvGwrM8MIt+wqoHpx70D3vXo2Z0vlAMKQXmQivg==", null, false, null, null, false, "heinrichmook" },
                    { "33", 0, null, "74ba9354-13c2-4399-b3e7-011c2b51dc91", "keriantonisse@example.com", false, "Keri", "Antonisse", false, null, "Keri Antonisse", "keriantonisse@example.com", "keriantonisse", "AQAAAAEAACcQAAAAEIMGiOYSxtURyDpQwffkDsQ76hQxZWqP1k6e2nUSNVLr7HFLvjxCqlC9qGqoumvCHw==", null, false, null, null, false, "keriantonisse" },
                    { "34", 0, null, "d6ac41fc-6e70-4a2f-8075-64f964c4e87e", "beerrebergen@example.com", false, "Beer", "Rebergen", false, null, "Beer Rebergen", "beerrebergen@example.com", "beerrebergen", "AQAAAAEAACcQAAAAEPDC0GbPPLjEYrm7MOqT0aqP1BvKTcMQcjI2q+2w92TaSTFh68uFLUWSsRAXn+Ms2A==", null, false, null, null, false, "beerrebergen" },
                    { "35", 0, null, "30c6bb53-8557-45ac-adf1-09ab0234caa6", "kainvandergun@example.com", false, "Kaïn", "Van der Gun", false, null, "Kaïn Van der Gun", "kainvandergun@example.com", "kainvandergun", "AQAAAAEAACcQAAAAEILEtCon83TRhORhnZE4v85TBeh10y1CjKZOLYb72KUvfFbZMRxlbu/Ww80ZvCpjzA==", null, false, null, null, false, "kainvandergun" },
                    { "36", 0, null, "27b4db3b-8089-4ffa-adcc-471433b9c6ac", "marloeswesterdijk@example.com", false, "Marloes", "Westerdijk", false, null, "Marloes Westerdijk", "marloeswesterdijk@example.com", "marloeswesterdijk", "AQAAAAEAACcQAAAAEKl1uAiPNv5Ww/MtknCYwjSFbgNP4GVj2n3QZloJo1PEVkLZHnohYpTqWoiieHqUNg==", null, false, null, null, false, "marloeswesterdijk" },
                    { "37", 0, null, "ed09f3d0-28dc-4820-9523-4003e538784a", "aurelieesajas@example.com", false, "Aurélie", "Esajas", false, null, "Aurélie Esajas", "aurelieesajas@example.com", "aurelieesajas", "AQAAAAEAACcQAAAAEOdmOJqlervMM1ON+mTS0/yMPFTOSfgafcxjQcnHnvl6GvCgv5gCo0F4VCFRG8WGqA==", null, false, null, null, false, "aurelieesajas" },
                    { "38", 0, null, "95bbeb44-9c1c-47a1-ab54-45e2d536ecf6", "gerlindenooijens@example.com", false, "Gerlinde", "Nooijens", false, null, "Gerlinde Nooijens", "gerlindenooijens@example.com", "gerlindenooijens", "AQAAAAEAACcQAAAAEBi8BZsdJiPqmHc9Nzfo9hzOSU2a10ENp2L658KFd33c9kTUlDNfrBkyj4tI/2ad0g==", null, false, null, null, false, "gerlindenooijens" },
                    { "39", 0, null, "c8b7db0e-cab1-4475-8ce4-b34393b6171e", "summerbrinkhuis@example.com", false, "Summer", "Brinkhuis", false, null, "Summer Brinkhuis", "summerbrinkhuis@example.com", "summerbrinkhuis", "AQAAAAEAACcQAAAAEPa75p1sIbDgTzHaercc8urH9Iaagjj0obapyKfsDaNHg03GuCXgQ54idB/zbPjlcA==", null, false, null, null, false, "summerbrinkhuis" },
                    { "4", 0, null, "8da35fa0-3293-4e43-8f85-eb83d5cd52c0", "floruscicek@example.com", false, "Florus", "Çiçek", false, null, "Florus Çiçek", "floruscicek@example.com", "floruscicek", "AQAAAAEAACcQAAAAEBFRslwgcGFsOVFd3wHKhPXb9SyIT+4Bs2Bav5H6lvKHZzAFEkfz+WryYwRs3z1/Kg==", null, false, null, null, false, "floruscicek" },
                    { "40", 0, null, "9a1a4dbb-1630-427e-a31b-3579210c2201", "quirinavandusschoten@example.com", false, "Quirina", "Van Dusschoten", false, null, "Quirina Van Dusschoten", "quirinavandusschoten@example.com", "quirinavandusschoten", "AQAAAAEAACcQAAAAEAfa8YicEh1ydN4zZlHsP93ZHoQ15qVJCPTNs/o6K3BDhNX13/Bd3vyW9eEARGeBJA==", null, false, null, null, false, "quirinavandusschoten" },
                    { "41", 0, null, "45166951-d43b-4056-9dda-0b0b44463e29", "emmelienhandels@example.com", false, "Emmelien", "Handels", false, null, "Emmelien Handels", "emmelienhandels@example.com", "emmelienhandels", "AQAAAAEAACcQAAAAELaUPej7mC2HB2tecii/pOpNHI9kORKYGF1rXQ7EeaNyFrJsTKoRuteiyEHRqrU9mA==", null, false, null, null, false, "emmelienhandels" },
                    { "42", 0, null, "066b6556-7dbf-4af1-8ca4-e6b96c3e9172", "wensleycurvers@example.com", false, "Wensley", "Curvers", false, null, "Wensley Curvers", "wensleycurvers@example.com", "wensleycurvers", "AQAAAAEAACcQAAAAEKDcMYP4812KEdYgmZ3i4WpJUgqKBJiLAOIvOfCkfEtRLu/7pzWV8Zno5MtdHkWe3g==", null, false, null, null, false, "wensleycurvers" },
                    { "43", 0, null, "767a9810-d4ae-47f0-a7c3-aba39dfd13fa", "dawidvanaart@example.com", false, "Dawid", "Van Aart", false, null, "Dawid Van Aart", "dawidvanaart@example.com", "dawidvanaart", "AQAAAAEAACcQAAAAEBoAgVDwfRCQdG7d9MqEL0doWqlIbYy8JpvkdDVunKMz5UspnzrdV0eQq290ODPIpQ==", null, false, null, null, false, "dawidvanaart" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CohortId1", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TimedOut", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5", 0, null, "cc92bed3-4cf8-49bf-a0c8-210ec2387768", "marlenewolf@example.com", false, "Marlène", "Wolf", false, null, "Marlène Wolf", "marlenewolf@example.com", "marlenewolf", "AQAAAAEAACcQAAAAEHWytHTsym859XmWCgZMrCnkmX1Y3Nr2HImzq2F2RUM/8Jrcn/QZm6nX+1HycN6CPA==", null, false, null, null, false, "marlenewolf" },
                    { "6", 0, null, "1f99ff25-a7e3-46d9-b587-40d577907501", "bilalsteentjes@example.com", false, "Bilal", "Steentjes", false, null, "Bilal Steentjes", "bilalsteentjes@example.com", "bilalsteentjes", "AQAAAAEAACcQAAAAEDk98sPV3bPVln8yQ+Vy3ceVbB9a1lQWyTB4zrQJzjYD+8kDx0oi8wS06mDUyUbetg==", null, false, null, null, false, "bilalsteentjes" },
                    { "7", 0, null, "ab9f3c28-75e1-43ad-9bf3-ef61247b2be5", "marlijngiebels@example.com", false, "Marlijn", "Giebels", false, null, "Marlijn Giebels", "marlijngiebels@example.com", "marlijngiebels", "AQAAAAEAACcQAAAAECxoi5sTRBkiR0GAwgIlGUN0iMdtQt13BfLCg72eV2gAMWTYXgOg/4heuCReUKTjlQ==", null, false, null, null, false, "marlijngiebels" },
                    { "8", 0, null, "699dbb50-8ce5-49d8-9fd6-c285a5f215c3", "sabrivandereijk@example.com", false, "Sabri", "Van der Eijk", false, null, "Sabri Van der Eijk", "sabrivandereijk@example.com", "sabrivandereijk", "AQAAAAEAACcQAAAAEHHpbZS2sWIAmDMuNZaMpYMwAWvV/QinlLUa9oL6Sy1lELv6+N7DvGTeo7h9U77hTg==", null, false, null, null, false, "sabrivandereijk" },
                    { "9", 0, null, "2cfa220c-5704-4c6b-aac7-25e6f6a238ad", "caseyandriesse@example.com", false, "Casey", "Andriesse", false, null, "Casey Andriesse", "caseyandriesse@example.com", "caseyandriesse", "AQAAAAEAACcQAAAAEPBE8qkj8La44YFN0V0567QdZ1SxhK1hm9Xg0tpeetmwSzVqDQWwC2glteOzAa0Frw==", null, false, null, null, false, "caseyandriesse" }
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
                    { 8, "Description for Semester Item 8", "Semester Item 8", 2, "[2]" },
                    { 999, "Reparatiesemester", "Reparatiesemester", 1, "[1,2]" }
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
                columns: new[] { "Id", "Approved_eb", "Approved_sb", "Note", "Send_eb", "Send_sb", "UserId" },
                values: new object[] { 1, true, true, "This is a note", true, true, "1" });

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
