using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace keuzewijzer_hbo_deeltijd_ict_API.Migrations
{
    public partial class firstagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CohortId1 = table.Column<int>(type: "int", nullable: true),
                    TimedOut = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MentorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                        name: "FK_AspNetUsers_AspNetUsers_MentorId",
                        column: x => x.MentorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
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
                    Send_sb = table.Column<bool>(type: "bit", nullable: false),
                    Approved_sb = table.Column<bool>(type: "bit", nullable: true),
                    Send_eb = table.Column<bool>(type: "bit", nullable: true),
                    Approved_eb = table.Column<bool>(type: "bit", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "UserId" },
                values: new object[,]
                {
                    { "1", "e48c9f7f-0d77-407f-8a0d-4e5638a664c0", "Administrator", "ADMINISTRATOR", null },
                    { "2", "00b02d67-b14f-4ad5-858d-2d3a23ab1b64", "Student", "STUDENT", null },
                    { "3", "476b1539-4e00-420f-b6b0-496988629f84", "Studiebegeleider", "STUDIEBEGELEIDER", null },
                    { "4", "8605eada-4a82-404c-8aa0-c1d32faa5b8a", "Moduleverantwoordelijke", "MODULEVERANTWOORDELIJKE", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CohortId1", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "MentorId", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TimedOut", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, null, "dfd981a0-3fd6-45de-b89a-cd85f06d0433", "admin@example.com", false, "Arnold", "Min", false, null, null, "Arnold Dirk Min", "admin@example.com", "admin", "AQAAAAEAACcQAAAAEL+ROUBtkLiDSNeIGB1HeOjf7DtsZjCVFTFPnEyhaomeGWsqmwZ7j3SSryrpA/YrRw==", null, false, "fd847846-cb01-44a5-8f22-efd148eac5ed", null, false, "admin" },
                    { "2", 0, null, "606af473-00b3-41e0-8405-8ba779b2be71", "eugenevanroden@example.com", false, "Eugene", "Van Roden", false, null, null, "Eugene Van Roden", "eugenevanroden@example.com", "eugenevanroden", "AQAAAAEAACcQAAAAEOa8Crq6bmhvxJMHrhs1mOgjDXcfY14yp9ROLok6PMIX1Qa1pPhNxsXS7lqQ165Abg==", null, false, "56f67e4a-5a4c-4875-8834-9ac03f770fb0", null, false, "eugenevanroden" },
                    { "3", 0, null, "e0059fb1-ede0-4638-b4b6-7608d9714acf", "theotan@example.com", false, "Theo", "Tan", false, null, null, "Theo Tan", "theotan@example.com", "theotan", "AQAAAAEAACcQAAAAEE8usydppAG5sO3WfjKsGSFNwinjc4g3Z2Fus3BQTwsJslyD8YiIL13x932envGZUg==", null, false, "d82785ae-5e13-47bf-a16c-d3b70241f208", null, false, "theotan" }
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
                    { "3", "2" },
                    { "4", "2" },
                    { "3", "3" },
                    { "4", "3" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CohortId1", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "MentorId", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TimedOut", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "10", 0, null, "31ac3516-4249-4405-9c8b-c17cb18247a1", "nikhuijskens@example.com", false, "Nik", "Huijskens", false, null, "2", "Nik Huijskens", "nikhuijskens@example.com", "nikhuijskens", "AQAAAAEAACcQAAAAENWt9vG2iF+YIZis0GPC5Hy47IE5irhgKPdD3ODTROO8WKvo8Z0MS95U2S9Uv5b2rg==", null, false, "7721863b-30f8-4eff-9f84-7ad58bbc42e0", null, false, "nikhuijskens" },
                    { "11", 0, null, "3902a862-9add-4d15-8506-557db06d0360", "duranpetiet@example.com", false, "Duran", "Petiet", false, null, "2", "Duran Petiet", "duranpetiet@example.com", "duranpetiet", "AQAAAAEAACcQAAAAEDKUSCnv8Avt0eu9eXQkbjfiafh+MOPW7WAVMN84ZbgpPvdk3sLWj6iq1kf66dSEWA==", null, false, "24a0f590-6bcd-45bc-8714-dab42734f4c3", null, false, "duranpetiet" },
                    { "12", 0, null, "88ace583-84b0-491e-8f91-32e3b7b37561", "veroniekbravenboer@example.com", false, "Veroniek", "Bravenboer", false, null, "2", "Veroniek Bravenboer", "veroniekbravenboer@example.com", "veroniekbravenboer", "AQAAAAEAACcQAAAAEMm/z0yQwwoEHMBVvncSO/MvBdHU5u9c1fFLFXknv+uYY2A8wDo3yMqQfAnwR9mMog==", null, false, "d355b472-875d-4cf1-8ad9-4e93aea767fd", null, false, "veroniekbravenboer" },
                    { "13", 0, null, "5b6d0842-af22-4cd1-8b04-19e12a418165", "kaynejagtenberg@example.com", false, "Kayne", "Jagtenberg", false, null, "2", "Kayne Jagtenberg", "kaynejagtenberg@example.com", "kaynejagtenberg", "AQAAAAEAACcQAAAAEOv2158myP0e9o4jq1Dtg6qzbqG4l+klekxS0mvn+elCW/iXFiFlhLNMvRg8YASA0Q==", null, false, "708c13d0-76ff-4002-a216-9cd47d37710b", null, false, "kaynejagtenberg" },
                    { "14", 0, null, "8fbded1b-5bf4-4f38-b6ee-bb8a0db5634e", "siebrigjeabdi@example.com", false, "Siebrigje", "Abdi", false, null, "2", "Siebrigje Abdi", "siebrigjeabdi@example.com", "siebrigjeabdi", "AQAAAAEAACcQAAAAEGRx3SzylBbYKjwR3meTRlPmq7/p7tLxrLvBrmZcb2Hv1YZetoK2+G3XkZ4GX3UwDQ==", null, false, "613ef085-18ab-4d4f-924e-219f825f2733", null, false, "siebrigjeabdi" },
                    { "15", 0, null, "ca95c65e-1c8b-416c-abdf-ef051f925a64", "sterrelambert@example.com", false, "Sterre", "Lambert", false, null, "2", "Sterre Lambert", "sterrelambert@example.com", "sterrelambert", "AQAAAAEAACcQAAAAEJIwp4bStZPZnjxhB0LHCMdyKM5axZKF84mJfopWebN9sZqKgTuEsyvh/yhuwNtDRA==", null, false, "5bc3a158-4611-44f1-88b7-52b86cd8b85a", null, false, "sterrelambert" },
                    { "16", 0, null, "b674112b-1a3f-4b12-890b-4c1a1e9a41ad", "milicavandergouw@example.com", false, "Milica", "Van der Gouw", false, null, "2", "Milica Van der Gouw", "milicavandergouw@example.com", "milicavandergouw", "AQAAAAEAACcQAAAAEMTfeNwMkPoo/c62kHax6w/h8mkMQWxY4EzZujeN6oOWv4yYXYqm5MRuFy7LVUoqJg==", null, false, "d736241c-f0cb-459f-b5c0-51aac4438774", null, false, "milicavandergouw" },
                    { "17", 0, null, "06490f37-b512-4108-876a-8cadffdda29d", "yvonbrussaard@example.com", false, "Yvon", "Brussaard", false, null, "2", "Yvon Brussaard", "yvonbrussaard@example.com", "yvonbrussaard", "AQAAAAEAACcQAAAAEGrAMC3XMxGO5v9RaQ8fWP+URgKq1BpO3UPumFEbI0r/9+wKIzP0wMXmNI54GTPhKQ==", null, false, "9fbfecd9-4837-45ee-9b43-984bcb043f2c", null, false, "yvonbrussaard" },
                    { "18", 0, null, "ecf30746-1ffa-4f5f-a36a-76b9fcc5e963", "bodhidatema@example.com", false, "Bodhi", "Datema", false, null, "2", "Bodhi Datema", "bodhidatema@example.com", "bodhidatema", "AQAAAAEAACcQAAAAEBkMwMu4y00QuyvgOK2fkOuHpuQt7DgpRkm3JGYjvNOgQMnUJi9FHCQ4+LO7Ig5qYg==", null, false, "1f632ebb-7b89-4b05-86aa-3623617739d9", null, false, "bodhidatema" },
                    { "19", 0, null, "8c57d659-c88c-4a1c-b9c1-965eee10e79e", "noachschutrups@example.com", false, "Noach", "Schutrups", false, null, "2", "Noach Schutrups", "noachschutrups@example.com", "noachschutrups", "AQAAAAEAACcQAAAAED7WA6NlqZvNcj47vyMpsRrJRZfqhHJuZakT7xBx6qEqilQLTYlOn30KZX8wZGoLMA==", null, false, "b2413fa6-9846-4b5a-9051-c6279a9ae07d", null, false, "noachschutrups" },
                    { "20", 0, null, "5b09e73e-a3c8-4adb-a860-929c0d6e9ad4", "ouassimbekking@example.com", false, "Ouassim", "Bekking", false, null, "2", "Ouassim Bekking", "ouassimbekking@example.com", "ouassimbekking", "AQAAAAEAACcQAAAAEHghsYkoGMmXtuxQSyC3pKUIv2aByeKSbhs/ePOOvnE+Ngy65hrbXDMGeTs06+vTug==", null, false, "b50e8dab-7364-4f57-8849-58a4d777c714", null, false, "ouassimbekking" },
                    { "21", 0, null, "a76eadf0-11f5-4e00-bb4c-77e903a69c3d", "noervanderkruit@example.com", false, "Noer", "Van der Kruit", false, null, "2", "Noer Van der Kruit", "noervanderkruit@example.com", "noervanderkruit", "AQAAAAEAACcQAAAAEGxXA04c6V97gN2xuDPcD+e+cuJimz/ihFypYTwEstNstZfi9as431Z1RPDTDhEpeQ==", null, false, "978e8fd8-de5d-4160-a509-56aeb40f4ba3", null, false, "noervanderkruit" },
                    { "22", 0, null, "951be453-6acf-4cc4-b08c-285feca23b5c", "kaanvanmaarseveen@example.com", false, "Kaan", "Van Maarseveen", false, null, "2", "Kaan Van Maarseveen", "kaanvanmaarseveen@example.com", "kaanvanmaarseveen", "AQAAAAEAACcQAAAAEECm96u34lOxCy1k5fa/4QZrPyw5s/9l01GSzZ9vG7+C/En/qbk3yl6Dwo1zyyOHaw==", null, false, "962ced40-8df1-4f16-be38-6306be58e0e0", null, false, "kaanvanmaarseveen" },
                    { "23", 0, null, "05a4c835-5393-4758-922b-5f174dca9b29", "owenkaal@example.com", false, "Owen", "Kaal", false, null, "2", "Owen Kaal", "owenkaal@example.com", "owenkaal", "AQAAAAEAACcQAAAAEDGLuEjMEDOPM3CrYeU6JwtKv/DBi9isGVZh3lw0NzWRPv9aYvKO4GDtMM+ss/5W0A==", null, false, "186a7d28-8756-4cec-8c96-117a296c86ad", null, false, "owenkaal" },
                    { "24", 0, null, "42dde107-260c-468a-af8c-2a26be27b130", "paulinebah@example.com", false, "Pauline", "Bah", false, null, "3", "Pauline Bah", "paulinebah@example.com", "paulinebah", "AQAAAAEAACcQAAAAEIeZetD50oi/bKNrfdXVl9h/m7JQNe30lIutVVtm715pO44i7jQsRMxmgbh3htdRgA==", null, false, "1bd6414e-c1ca-41f9-8f02-db682f7c5c8a", null, false, "paulinebah" },
                    { "25", 0, null, "f464d61a-01ab-410b-920d-4df09c22f0b5", "caterinatas@example.com", false, "Caterina", "Tas", false, null, "3", "Caterina Tas", "caterinatas@example.com", "caterinatas", "AQAAAAEAACcQAAAAEPsWVaVN51qEK5fn8BUz+pa3MgfhBfziKVz6sjpsfIhO7L67cVdY7q4lo3eyLsDz6g==", null, false, "e1dacbfe-bdbc-45e0-a923-c523b206cdb4", null, false, "caterinatas" },
                    { "26", 0, null, "550bc9ec-e6bb-4d94-9de4-b0826cec5f05", "edtouw@example.com", false, "Ed", "Touw", false, null, "3", "Ed Touw", "edtouw@example.com", "edtouw", "AQAAAAEAACcQAAAAEC5AcDfBR1fJp4r8fgV8bRNtmJBHKC1mrnzQCG/Dx9XaWDgKUyMAin1byqL6kduPcw==", null, false, "4c556135-4d85-484f-9670-617a0bffa091", null, false, "edtouw" },
                    { "27", 0, null, "12169443-d60f-4a86-9f64-52b4ae83627a", "hugofidom@example.com", false, "Hugo", "Fidom", false, null, "3", "Hugo Fidom", "hugofidom@example.com", "hugofidom", "AQAAAAEAACcQAAAAEC20T5Q+OiqYI8rcJY+eqkfDyghR/td4bIAwCjQaVY/40MM6kcWGr6N+hrPgyZMBeQ==", null, false, "946593e6-05ab-4436-8d3a-2b8d67511d8e", null, false, "hugofidom" },
                    { "28", 0, null, "7a95b950-c0c5-4126-a55c-676225324bdb", "nannebesseling@example.com", false, "Nanne", "Besseling", false, null, "3", "Nanne Besseling", "nannebesseling@example.com", "nannebesseling", "AQAAAAEAACcQAAAAEAGv/ILjbkyrfwRrjaN3J7jEusTeQt2hq2ZtLOpybwG721ZotgiuVvHIfG5/iGwF5w==", null, false, "ec35b7b7-5b52-4760-bb05-e032a40d9ba1", null, false, "nannebesseling" },
                    { "29", 0, null, "68f24ba0-d58d-4c85-b9da-34f1002950c4", "teunisjesalden@example.com", false, "Teunisje", "Salden", false, null, "3", "Teunisje Salden", "teunisjesalden@example.com", "teunisjesalden", "AQAAAAEAACcQAAAAED6T7X2kwsUBZ/g7gaSbm0jeGQmxsRQvQYnU783D6cct4iNHBm8aQPQmfsYcqbVniA==", null, false, "3ef33f23-d4a3-46e2-a88e-5431cc7d37d2", null, false, "teunisjesalden" },
                    { "30", 0, null, "a57bb2e8-e47c-40ee-9489-e7c7d67ed2da", "rochedoornink@example.com", false, "Roché", "Doornink", false, null, "3", "Roché Doornink", "rochedoornink@example.com", "rochedoornink", "AQAAAAEAACcQAAAAEKlpswb3Go7F7tV2sK6etjqrjvs5SuUr2NyXC8u5QY1I3492itziDEmSOnhpbB7uLw==", null, false, "28b2a89e-c59e-44f0-bacb-81cb05f445bf", null, false, "rochedoornink" },
                    { "31", 0, null, "3025aec5-4d7a-414e-83b0-3d8d2ec63a2a", "yuenboertien@example.com", false, "Yuen", "Boertien", false, null, "3", "Yuen Boertien", "yuenboertien@example.com", "yuenboertien", "AQAAAAEAACcQAAAAEDUbEEDdgCAjFuvFVGw4O6YH/oRP6c8XXtRmEpt3pAzbMh4j2v0GYEJFgQOcZB94BA==", null, false, "3cec6217-4946-4e5f-abed-60c584cd10ab", null, false, "yuenboertien" },
                    { "32", 0, null, "ffb1ddb2-7db0-4b6e-ae1a-66ca94c22bdd", "heinrichmook@example.com", false, "Heinrich", "Mook", false, null, "3", "Heinrich Mook", "heinrichmook@example.com", "heinrichmook", "AQAAAAEAACcQAAAAEK2triXmKjTIueXmCechEGF5mXrWwZp5jyAlII5WpRYEs7mScPa/sE74hUVvn1e0VQ==", null, false, "64199c28-3f0d-488e-a4cf-4fe4eb0a6315", null, false, "heinrichmook" },
                    { "33", 0, null, "06f5acdd-86f3-43d9-af3a-2432d2cf672b", "keriantonisse@example.com", false, "Keri", "Antonisse", false, null, "3", "Keri Antonisse", "keriantonisse@example.com", "keriantonisse", "AQAAAAEAACcQAAAAEHJjysNOjTzf7AnJmdn89LalLfmNobyL+Uh+xouCqfcRg3hamGb8B5466jPxWTfhaA==", null, false, "ca551573-bcd1-4886-a813-6d9e3322d0e6", null, false, "keriantonisse" },
                    { "34", 0, null, "d3588fc8-cd73-40e4-affa-85678afdab80", "beerrebergen@example.com", false, "Beer", "Rebergen", false, null, "3", "Beer Rebergen", "beerrebergen@example.com", "beerrebergen", "AQAAAAEAACcQAAAAEISDxH26/7m5aofACTr4iQwj2f1BF0bTpdgNcVVkPScUMyucmJwrdf1PmGrnQbefIw==", null, false, "8350796c-646c-4082-b05a-ae851cb1a023", null, false, "beerrebergen" },
                    { "35", 0, null, "4facae5a-46a2-444c-ba4d-ebfc843e2a98", "kainvandergun@example.com", false, "Kaïn", "Van der Gun", false, null, "3", "Kaïn Van der Gun", "kainvandergun@example.com", "kainvandergun", "AQAAAAEAACcQAAAAEA0NEEKZ+aKJZfBs255+xcgpYC0wRFDn9LrgpsF5q0bEYZpn0W5Ag0Yt2WlKA8lNjA==", null, false, "123366ad-ca7a-4d25-9998-f0752f02cc18", null, false, "kainvandergun" },
                    { "36", 0, null, "aab5eee8-eeb2-46f9-a873-36c6e7ba8630", "marloeswesterdijk@example.com", false, "Marloes", "Westerdijk", false, null, "3", "Marloes Westerdijk", "marloeswesterdijk@example.com", "marloeswesterdijk", "AQAAAAEAACcQAAAAEJEd5ZVxG0zYWxHN7mFgGkoqfbwDfWvj9ij2XwISqBoTENaQzxCnH8lAJWNflt+blw==", null, false, "9fd1f682-4012-4ca8-87b5-13a11516d1d8", null, false, "marloeswesterdijk" },
                    { "37", 0, null, "aeed10e5-3f45-44eb-ab30-ae2e3b7c84f0", "aurelieesajas@example.com", false, "Aurélie", "Esajas", false, null, "3", "Aurélie Esajas", "aurelieesajas@example.com", "aurelieesajas", "AQAAAAEAACcQAAAAED6/A0wkuUZtKmC8RZ60/Mv7zGJeHSusTMO6+D8qK5+SfgQBme4wMrAZcY6ikhxj1w==", null, false, "b74f7c36-4c7f-4126-9272-c1a32385c6fb", null, false, "aurelieesajas" },
                    { "38", 0, null, "b7b2463b-f87c-452d-9e9f-3ef245e831f8", "gerlindenooijens@example.com", false, "Gerlinde", "Nooijens", false, null, "3", "Gerlinde Nooijens", "gerlindenooijens@example.com", "gerlindenooijens", "AQAAAAEAACcQAAAAED5uQQNS7fKnXkyGuUx00y1zSkl48mZ1tLtUuXKrTFuUU9Nunp8/Px1rwWlqxZ1+Fg==", null, false, "f2724833-9e99-42c5-ba19-914ff9a862ff", null, false, "gerlindenooijens" },
                    { "39", 0, null, "a5840a49-c45d-4e2b-b056-005fee7aa313", "summerbrinkhuis@example.com", false, "Summer", "Brinkhuis", false, null, "3", "Summer Brinkhuis", "summerbrinkhuis@example.com", "summerbrinkhuis", "AQAAAAEAACcQAAAAEOQtz+aVJ5fgel/qn3e3JyUD7j6ixEuV1ao9a9MIrsI++4Y5Euo2GmHI3zk+QspARw==", null, false, "0e98d88f-7dcb-4a2a-b139-1abd4d9c1eb3", null, false, "summerbrinkhuis" },
                    { "4", 0, null, "cc85fafc-279d-4847-bfbe-9fbb81840f69", "floruscicek@example.com", false, "Florus", "Çiçek", false, null, "2", "Florus Çiçek", "floruscicek@example.com", "floruscicek", "AQAAAAEAACcQAAAAENkxAHW/ydg1TK8SRiTUt2MZRdf1kGfCEWmJC7TZjse9eUtcVXMIVg0GZQfbVsd+oA==", null, false, "cfcfef64-68eb-4083-b8de-dedc1c7c2117", null, false, "floruscicek" },
                    { "40", 0, null, "29785fd1-6701-41d6-893e-e5abcacec683", "quirinavandusschoten@example.com", false, "Quirina", "Van Dusschoten", false, null, "3", "Quirina Van Dusschoten", "quirinavandusschoten@example.com", "quirinavandusschoten", "AQAAAAEAACcQAAAAEJ6RiMLasTQlrmFFWifqXStaa8lS2DNoyrJRnj1ArwA/BntHzhLj5UMt3/b5XonBFw==", null, false, "0a15c053-ba92-4073-ab7b-efa21e25369c", null, false, "quirinavandusschoten" },
                    { "41", 0, null, "2f68c509-0301-4b3b-a22e-f8a3041b2096", "emmelienhandels@example.com", false, "Emmelien", "Handels", false, null, "3", "Emmelien Handels", "emmelienhandels@example.com", "emmelienhandels", "AQAAAAEAACcQAAAAELh9oOgeug70q4IPKnJxZgoXc2R3KC0Ok75oIW+fnZsMozYJ0T5djMWKv+XgRjhGJQ==", null, false, "4e0b9179-c1a3-4c66-92cc-6ee158847da3", null, false, "emmelienhandels" },
                    { "42", 0, null, "c52a7ba2-a23b-4595-b644-030c45492815", "wensleycurvers@example.com", false, "Wensley", "Curvers", false, null, "3", "Wensley Curvers", "wensleycurvers@example.com", "wensleycurvers", "AQAAAAEAACcQAAAAEJDeEymZ8jTnORFdSKds9fuazPTf4Rm4T+SBvOSuZ6OIoKa5YaVyTXJR5D9jM0vmmw==", null, false, "ace60c04-083c-4b1e-b1f6-e5d5b877d66a", null, false, "wensleycurvers" },
                    { "43", 0, null, "19bc5e8f-d5e6-4547-8ae8-7047daada006", "dawidvanaart@example.com", false, "Dawid", "Van Aart", false, null, "3", "Dawid Van Aart", "dawidvanaart@example.com", "dawidvanaart", "AQAAAAEAACcQAAAAEIuwbNLiYM1JmWW1Idpb95Rzcq+K6GqRAAZMlrbEHhRSrybrF3qX3MzhziMOPMZVUg==", null, false, "21e79225-655c-4aa0-945a-652aa67215ea", null, false, "dawidvanaart" },
                    { "5", 0, null, "a0d0d40d-dfd0-4879-8155-e2c7e4a08b36", "marlenewolf@example.com", false, "Marlène", "Wolf", false, null, "2", "Marlène Wolf", "marlenewolf@example.com", "marlenewolf", "AQAAAAEAACcQAAAAEA2KLFEpmL+BLcagmeO3Y5d8fDivBCHcivwTvSVRtLdb3bgCrTg55/UOeO/6rMrg7g==", null, false, "ad4021a7-92af-49a7-ab1f-7e5412f792eb", null, false, "marlenewolf" },
                    { "6", 0, null, "d2f007bb-ce34-4d12-b431-54a15c69abdc", "bilalsteentjes@example.com", false, "Bilal", "Steentjes", false, null, "2", "Bilal Steentjes", "bilalsteentjes@example.com", "bilalsteentjes", "AQAAAAEAACcQAAAAEDx5vXXKUeRoqVY648wJxLV4EbPVkKHFPBRY3JG8DSXpGiXeMVdwiFeHDzppVBPKSQ==", null, false, "d516b450-b1bc-4c9f-8935-7257a44e9ee3", null, false, "bilalsteentjes" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CohortId1", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "MentorId", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TimedOut", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7", 0, null, "54c09dd5-ad84-4ebf-8f7a-ab8196900bea", "marlijngiebels@example.com", false, "Marlijn", "Giebels", false, null, "2", "Marlijn Giebels", "marlijngiebels@example.com", "marlijngiebels", "AQAAAAEAACcQAAAAEAvXZ95hAnNYma45Qhaskvbk/RvhmJha7bKCdV/ZZrcU8nVJvzpUjah/3bMwtvQ5lg==", null, false, "0c4a5f91-f33f-43be-aa19-c6a49d2f905a", null, false, "marlijngiebels" },
                    { "8", 0, null, "7601b56b-a96b-4023-ad5d-dc080f3e94e5", "sabrivandereijk@example.com", false, "Sabri", "Van der Eijk", false, null, "2", "Sabri Van der Eijk", "sabrivandereijk@example.com", "sabrivandereijk", "AQAAAAEAACcQAAAAEJ5dLcxUc7XRjqL1L1uBiY308FZ0UB/uZsD4vdUW9w3ZhlAqIHpJBgI8LIgpqlGEQQ==", null, false, "f8f29961-706c-44cd-8806-d3ca791ecac5", null, false, "sabrivandereijk" },
                    { "9", 0, null, "f4a0cf19-001b-48ea-9b45-560c3570eec8", "caseyandriesse@example.com", false, "Casey", "Andriesse", false, null, "2", "Casey Andriesse", "caseyandriesse@example.com", "caseyandriesse", "AQAAAAEAACcQAAAAEJTr7rE4uluHc844A1Nxkhyyt2UacU+/kJXky46NBtmxwtNjQXvo3G1ODzau6SWqZw==", null, false, "4e0715e6-f632-4693-8d18-fcf48535a51e", null, false, "caseyandriesse" }
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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
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
                    { "2", "6" },
                    { "2", "7" },
                    { "2", "8" },
                    { "2", "9" }
                });

            migrationBuilder.InsertData(
                table: "StudyRoutes",
                columns: new[] { "Id", "Approved_eb", "Approved_sb", "Note", "Send_eb", "Send_sb", "UserId" },
                values: new object[,]
                {
                    { 4, null, null, null, null, true, "4" },
                    { 5, null, null, null, null, true, "5" }
                });

            migrationBuilder.InsertData(
                table: "StudyRoutes",
                columns: new[] { "Id", "Approved_eb", "Approved_sb", "Note", "Send_eb", "Send_sb", "UserId" },
                values: new object[,]
                {
                    { 6, null, null, null, null, false, "6" },
                    { 7, null, null, null, null, false, "7" },
                    { 8, null, null, null, null, false, "8" },
                    { 9, null, null, null, null, true, "9" },
                    { 10, null, null, null, null, false, "10" },
                    { 11, null, null, null, null, true, "11" },
                    { 12, false, true, null, true, true, "12" },
                    { 13, null, null, null, null, false, "13" },
                    { 14, null, false, null, false, true, "14" },
                    { 15, null, null, null, null, false, "15" },
                    { 16, null, null, null, null, false, "16" },
                    { 17, null, false, null, false, true, "17" },
                    { 18, null, null, null, null, false, "18" },
                    { 19, null, null, null, null, false, "19" },
                    { 20, null, null, null, null, false, "20" },
                    { 21, null, false, null, false, true, "21" },
                    { 22, null, null, null, null, true, "22" },
                    { 23, null, null, null, null, false, "23" },
                    { 24, false, true, null, true, true, "24" },
                    { 25, null, null, null, null, false, "25" },
                    { 26, null, null, null, null, false, "26" },
                    { 27, null, null, null, null, false, "27" },
                    { 28, null, null, null, null, false, "28" },
                    { 29, null, null, null, null, false, "29" },
                    { 30, null, null, null, null, false, "30" },
                    { 31, null, null, null, null, false, "31" },
                    { 32, null, null, null, null, false, "32" },
                    { 33, null, false, null, false, true, "33" },
                    { 34, null, null, null, null, false, "34" },
                    { 35, null, null, null, null, true, "35" },
                    { 36, null, null, null, null, false, "36" },
                    { 37, null, null, null, null, true, "37" },
                    { 38, null, null, null, null, false, "38" },
                    { 39, null, null, null, null, false, "39" },
                    { 40, false, true, null, true, true, "40" },
                    { 41, null, null, null, null, true, "41" },
                    { 42, null, false, null, false, true, "42" },
                    { 43, null, null, null, null, true, "43" }
                });

            migrationBuilder.InsertData(
                table: "StudyRouteItems",
                columns: new[] { "Id", "Semester", "SemesterItemId", "StudyRouteId", "Year" },
                values: new object[,]
                {
                    { 1, 1, 2, 4, 1 },
                    { 2, 2, 5, 4, 1 },
                    { 3, 1, 1, 4, 2 },
                    { 4, 2, 4, 4, 2 },
                    { 5, 1, 1, 5, 1 },
                    { 6, 2, 5, 5, 1 },
                    { 7, 1, 6, 6, 1 },
                    { 8, 2, 8, 6, 1 },
                    { 9, 1, 4, 6, 2 },
                    { 10, 2, 2, 6, 2 },
                    { 11, 1, 8, 7, 1 },
                    { 12, 2, 1, 7, 1 },
                    { 13, 1, 5, 8, 1 },
                    { 14, 2, 6, 8, 1 },
                    { 15, 1, 4, 9, 1 },
                    { 16, 2, 5, 9, 1 },
                    { 17, 1, 6, 9, 2 },
                    { 18, 2, 8, 9, 2 },
                    { 19, 1, 3, 10, 1 },
                    { 20, 2, 7, 10, 1 },
                    { 21, 1, 5, 10, 2 },
                    { 22, 2, 6, 10, 2 },
                    { 23, 1, 8, 10, 3 },
                    { 24, 2, 4, 10, 3 },
                    { 25, 1, 3, 11, 1 },
                    { 26, 2, 8, 11, 1 },
                    { 27, 1, 5, 11, 2 },
                    { 28, 1, 7, 12, 1 },
                    { 29, 2, 1, 12, 1 },
                    { 30, 1, 3, 12, 2 },
                    { 31, 2, 2, 12, 2 },
                    { 32, 1, 5, 12, 3 },
                    { 33, 1, 2, 13, 1 },
                    { 34, 2, 7, 13, 1 },
                    { 35, 1, 5, 13, 2 },
                    { 36, 2, 8, 13, 2 },
                    { 37, 1, 3, 13, 3 },
                    { 38, 2, 6, 13, 3 },
                    { 39, 1, 6, 14, 1 },
                    { 40, 2, 3, 14, 1 },
                    { 41, 1, 6, 15, 1 },
                    { 42, 2, 8, 15, 1 }
                });

            migrationBuilder.InsertData(
                table: "StudyRouteItems",
                columns: new[] { "Id", "Semester", "SemesterItemId", "StudyRouteId", "Year" },
                values: new object[,]
                {
                    { 43, 1, 1, 15, 2 },
                    { 44, 2, 4, 15, 2 },
                    { 45, 1, 2, 15, 3 },
                    { 46, 2, 3, 15, 3 },
                    { 47, 1, 7, 15, 4 },
                    { 48, 1, 6, 16, 1 },
                    { 49, 2, 5, 16, 1 },
                    { 50, 1, 7, 16, 2 },
                    { 51, 2, 3, 16, 2 },
                    { 52, 1, 1, 17, 1 },
                    { 53, 2, 8, 17, 1 },
                    { 54, 1, 5, 18, 1 },
                    { 55, 2, 8, 18, 1 },
                    { 56, 1, 2, 18, 2 },
                    { 57, 1, 5, 19, 1 },
                    { 58, 2, 3, 19, 1 },
                    { 59, 1, 7, 19, 2 },
                    { 60, 2, 2, 19, 2 },
                    { 61, 1, 4, 19, 3 },
                    { 62, 2, 6, 19, 3 },
                    { 63, 1, 8, 20, 1 },
                    { 64, 2, 5, 20, 1 },
                    { 65, 1, 2, 20, 2 },
                    { 66, 2, 3, 20, 2 },
                    { 67, 1, 6, 20, 3 },
                    { 68, 2, 4, 20, 3 },
                    { 69, 1, 4, 21, 1 },
                    { 70, 2, 6, 21, 1 },
                    { 71, 1, 1, 21, 2 },
                    { 72, 1, 6, 22, 1 },
                    { 73, 2, 4, 22, 1 },
                    { 74, 1, 7, 22, 2 },
                    { 75, 2, 3, 22, 2 },
                    { 76, 1, 5, 22, 3 },
                    { 77, 1, 3, 23, 1 },
                    { 78, 2, 4, 23, 1 },
                    { 79, 1, 1, 23, 2 },
                    { 80, 1, 8, 24, 1 },
                    { 81, 2, 2, 24, 1 },
                    { 82, 1, 6, 25, 1 },
                    { 83, 2, 5, 25, 1 },
                    { 84, 1, 7, 26, 1 }
                });

            migrationBuilder.InsertData(
                table: "StudyRouteItems",
                columns: new[] { "Id", "Semester", "SemesterItemId", "StudyRouteId", "Year" },
                values: new object[,]
                {
                    { 85, 2, 8, 26, 1 },
                    { 86, 1, 4, 26, 2 },
                    { 87, 2, 1, 26, 2 },
                    { 88, 1, 5, 26, 3 },
                    { 89, 1, 1, 27, 1 },
                    { 90, 2, 8, 27, 1 },
                    { 91, 1, 7, 28, 1 },
                    { 92, 2, 6, 28, 1 },
                    { 93, 1, 5, 28, 2 },
                    { 94, 1, 1, 29, 1 },
                    { 95, 2, 2, 29, 1 },
                    { 96, 1, 3, 29, 2 },
                    { 97, 2, 8, 29, 2 },
                    { 98, 1, 6, 29, 3 },
                    { 99, 2, 7, 29, 3 },
                    { 100, 1, 6, 30, 1 },
                    { 101, 2, 3, 30, 1 },
                    { 102, 1, 4, 30, 2 },
                    { 103, 2, 1, 30, 2 },
                    { 104, 1, 2, 30, 3 },
                    { 105, 2, 7, 30, 3 },
                    { 106, 1, 5, 30, 4 },
                    { 107, 1, 6, 31, 1 },
                    { 108, 2, 1, 31, 1 },
                    { 109, 1, 4, 31, 2 },
                    { 110, 2, 2, 31, 2 },
                    { 111, 1, 8, 32, 1 },
                    { 112, 2, 4, 32, 1 },
                    { 113, 1, 1, 32, 2 },
                    { 114, 2, 2, 32, 2 },
                    { 115, 1, 5, 32, 3 },
                    { 116, 2, 3, 32, 3 },
                    { 117, 1, 7, 32, 4 },
                    { 118, 1, 3, 33, 1 },
                    { 119, 2, 6, 33, 1 },
                    { 120, 1, 4, 33, 2 },
                    { 121, 2, 5, 33, 2 },
                    { 122, 1, 5, 34, 1 },
                    { 123, 2, 7, 34, 1 },
                    { 124, 1, 1, 34, 2 },
                    { 125, 2, 4, 34, 2 },
                    { 126, 1, 6, 34, 3 }
                });

            migrationBuilder.InsertData(
                table: "StudyRouteItems",
                columns: new[] { "Id", "Semester", "SemesterItemId", "StudyRouteId", "Year" },
                values: new object[,]
                {
                    { 127, 2, 2, 34, 3 },
                    { 128, 1, 8, 34, 4 },
                    { 129, 1, 6, 35, 1 },
                    { 130, 2, 4, 35, 1 },
                    { 131, 1, 5, 35, 2 },
                    { 132, 1, 4, 36, 1 },
                    { 133, 2, 1, 36, 1 },
                    { 134, 1, 8, 37, 1 },
                    { 135, 2, 5, 37, 1 },
                    { 136, 1, 1, 37, 2 },
                    { 137, 2, 3, 37, 2 },
                    { 138, 1, 2, 37, 3 },
                    { 139, 2, 7, 37, 3 },
                    { 140, 1, 4, 37, 4 },
                    { 141, 1, 1, 38, 1 },
                    { 142, 2, 4, 38, 1 },
                    { 143, 1, 5, 38, 2 },
                    { 144, 1, 6, 39, 1 },
                    { 145, 2, 5, 39, 1 },
                    { 146, 1, 2, 39, 2 },
                    { 147, 2, 3, 39, 2 },
                    { 148, 1, 8, 39, 3 },
                    { 149, 2, 7, 39, 3 },
                    { 150, 1, 1, 39, 4 },
                    { 151, 1, 7, 40, 1 },
                    { 152, 2, 3, 40, 1 },
                    { 153, 1, 2, 40, 2 },
                    { 154, 1, 4, 41, 1 },
                    { 155, 2, 3, 41, 1 },
                    { 156, 1, 1, 41, 2 },
                    { 157, 2, 6, 41, 2 },
                    { 158, 1, 2, 41, 3 },
                    { 159, 2, 7, 41, 3 },
                    { 160, 1, 8, 42, 1 },
                    { 161, 2, 1, 42, 1 },
                    { 162, 1, 2, 42, 2 },
                    { 163, 2, 5, 42, 2 },
                    { 164, 1, 3, 42, 3 },
                    { 165, 1, 2, 43, 1 },
                    { 166, 2, 6, 43, 1 },
                    { 167, 1, 7, 43, 2 },
                    { 168, 2, 3, 43, 2 }
                });

            migrationBuilder.InsertData(
                table: "StudyRouteItems",
                columns: new[] { "Id", "Semester", "SemesterItemId", "StudyRouteId", "Year" },
                values: new object[] { 169, 1, 1, 43, 3 });

            migrationBuilder.InsertData(
                table: "StudyRouteItems",
                columns: new[] { "Id", "Semester", "SemesterItemId", "StudyRouteId", "Year" },
                values: new object[] { 170, 2, 5, 43, 3 });

            migrationBuilder.InsertData(
                table: "StudyRouteItems",
                columns: new[] { "Id", "Semester", "SemesterItemId", "StudyRouteId", "Year" },
                values: new object[] { 171, 1, 4, 43, 4 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_UserId",
                table: "AspNetRoles",
                column: "UserId");

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
                name: "IX_AspNetUsers_MentorId",
                table: "AspNetUsers",
                column: "MentorId");

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
