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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "UserId" },
                values: new object[,]
                {
                    { "1", "678864f8-c057-4195-a919-f28efabdaa16", "Administrator", "ADMINISTRATOR", null },
                    { "2", "7fda4a4c-3973-411b-86df-67ae0d1edbbb", "Student", "STUDENT", null },
                    { "3", "149fbda6-8b60-4362-8471-d7951fce6ae6", "Studiebegeleider", "STUDIEBEGELEIDER", null },
                    { "4", "0fa44cf3-1820-4694-9abe-a8035949d78d", "Moduleverantwoordelijke", "MODULEVERANTWOORDELIJKE", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CohortId1", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TimedOut", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, null, "83992dc6-c5e7-4523-8c6c-3ac16f044d43", "admin@example.com", false, "Arnold", "Min", false, null, "Arnold Dirk Min", "admin@example.com", "admin", "AQAAAAEAACcQAAAAECpe6Hny7GsRUiyjwioCdZg6wQ6J1H6JNREgr5Ewtqu8UVnyNgCiac8NEIy2QbQGEA==", null, false, null, null, false, "admin" },
                    { "10", 0, null, "9489b286-28f9-41f4-a254-f55bcc44b4ce", "nikhuijskens@example.com", false, "Nik", "Huijskens", false, null, "Nik Huijskens", "nikhuijskens@example.com", "nikhuijskens", "AQAAAAEAACcQAAAAEBUVsXwfr6M/qa1hHAxRJnoxXf6/6JVmDZHLecP9B3iz4qxxeJ/h0jxHNtxxJKrpOw==", null, false, null, null, false, "nikhuijskens" },
                    { "11", 0, null, "8174ab65-db68-46ca-a284-70163a973f13", "duranpetiet@example.com", false, "Duran", "Petiet", false, null, "Duran Petiet", "duranpetiet@example.com", "duranpetiet", "AQAAAAEAACcQAAAAED6tja5jwXRNHN2ozA9901drk3KSwJ3PtoqpXJLzLB2Cbe8WaRG7DQ3EUwCsinGS7Q==", null, false, null, null, false, "duranpetiet" },
                    { "12", 0, null, "d3a014d8-5e87-4c28-ad15-2ef0235e9215", "veroniekbravenboer@example.com", false, "Veroniek", "Bravenboer", false, null, "Veroniek Bravenboer", "veroniekbravenboer@example.com", "veroniekbravenboer", "AQAAAAEAACcQAAAAEGio1mIhcRcDbfx2JmOYL+wPI59NqxiuNTvngFTeInvgRjrkppL5rsQvP8u4Tok8rQ==", null, false, null, null, false, "veroniekbravenboer" },
                    { "13", 0, null, "db28316b-c522-4613-8a60-eb8752f4c771", "kaynejagtenberg@example.com", false, "Kayne", "Jagtenberg", false, null, "Kayne Jagtenberg", "kaynejagtenberg@example.com", "kaynejagtenberg", "AQAAAAEAACcQAAAAEDgBjcAEO6qs17S+2iZp/Cdu6PV7h0dlnbi+y4Uo4gASiHR1V78oOoX1WQDcL24HMA==", null, false, null, null, false, "kaynejagtenberg" },
                    { "14", 0, null, "56b8eedf-86d2-468b-9493-0694e08db20f", "siebrigjeabdi@example.com", false, "Siebrigje", "Abdi", false, null, "Siebrigje Abdi", "siebrigjeabdi@example.com", "siebrigjeabdi", "AQAAAAEAACcQAAAAEAYSgHS2p3cD4t3BRETgzVKwnXP73yRSrqeNkHgqJiAhTIRer6TN+3Fk60F/3pfz7Q==", null, false, null, null, false, "siebrigjeabdi" },
                    { "15", 0, null, "cf10e596-d6b4-48d3-96ee-6ef6d21e1bf6", "sterrelambert@example.com", false, "Sterre", "Lambert", false, null, "Sterre Lambert", "sterrelambert@example.com", "sterrelambert", "AQAAAAEAACcQAAAAELQLwakIrDW+pZ3kmxjBfCYhf2s3C6E4rrLTpN2qB6fxMVRDbqt+aTA/OEx1uMqnwg==", null, false, null, null, false, "sterrelambert" },
                    { "16", 0, null, "09d8f49b-6f8f-4254-bf7d-5df3c5ba3022", "milicavandergouw@example.com", false, "Milica", "Van der Gouw", false, null, "Milica Van der Gouw", "milicavandergouw@example.com", "milicavandergouw", "AQAAAAEAACcQAAAAEOW95myr9w1Sd/xkfroqcT9OiFIOgeaYURz8bWuv8HjGHvtHyxV2swnf9GVt9Oso3g==", null, false, null, null, false, "milicavandergouw" },
                    { "17", 0, null, "696c0565-25da-434b-bf4c-a8d4b2346648", "yvonbrussaard@example.com", false, "Yvon", "Brussaard", false, null, "Yvon Brussaard", "yvonbrussaard@example.com", "yvonbrussaard", "AQAAAAEAACcQAAAAEEtlQOuNKpzLPnVpedAa2q8Ob5VwrxsLn0sB1KoAbUhhiovsdTEHUCNNqfTNTp2oIQ==", null, false, null, null, false, "yvonbrussaard" },
                    { "18", 0, null, "f0558a0e-0d90-4537-8d27-39acfe2fd585", "bodhidatema@example.com", false, "Bodhi", "Datema", false, null, "Bodhi Datema", "bodhidatema@example.com", "bodhidatema", "AQAAAAEAACcQAAAAEIpbXvyBpOYEVmBUguDFv/VdLBHzrOjp4xxxciRzufmoLpz3YQ1rWQ2Ygw+6z6YX8A==", null, false, null, null, false, "bodhidatema" },
                    { "19", 0, null, "6653ef77-0895-43a1-bd59-a02369c45db5", "noachschutrups@example.com", false, "Noach", "Schutrups", false, null, "Noach Schutrups", "noachschutrups@example.com", "noachschutrups", "AQAAAAEAACcQAAAAEMWvMHMaLVOxa3wo/oE0mlqIZDhQO41EIRT+M+vzJjE8Cy8PoOjGQKfRlikGlrMnPA==", null, false, null, null, false, "noachschutrups" },
                    { "2", 0, null, "c2d63f00-0faa-496f-99d3-98652dea271c", "eugenevanroden@example.com", false, "Eugene", "Van Roden", false, null, "Eugene Van Roden", "eugenevanroden@example.com", "eugenevanroden", "AQAAAAEAACcQAAAAELTwvRrOnZltegvGPEbVXXsGIrQLpMyfeZEezs4h0q5HtPshZTg8LSEXXSDFKQNT0A==", null, false, null, null, false, "eugenevanroden" },
                    { "20", 0, null, "f7986fb7-1de8-4fa7-b9e4-d3bfa6c5adfd", "ouassimbekking@example.com", false, "Ouassim", "Bekking", false, null, "Ouassim Bekking", "ouassimbekking@example.com", "ouassimbekking", "AQAAAAEAACcQAAAAEO8WSE7KREaNxZR7flLm0pFIDQPOqCyaJA8XzPdeKm/UfhPGA2/F6RXBSl4ylkoZ4A==", null, false, null, null, false, "ouassimbekking" },
                    { "21", 0, null, "97030630-5574-4465-843a-dda7e6be2ddf", "noervanderkruit@example.com", false, "Noer", "Van der Kruit", false, null, "Noer Van der Kruit", "noervanderkruit@example.com", "noervanderkruit", "AQAAAAEAACcQAAAAEO4gp79zt+E9Mnv15WG27yxHXSTYiq5wgyWIW7eW/6XjdCnuLCjJGeGDne2q5xKaJA==", null, false, null, null, false, "noervanderkruit" },
                    { "22", 0, null, "62786c8a-5cfc-4218-9ec9-0afe739172b5", "kaanvanmaarseveen@example.com", false, "Kaan", "Van Maarseveen", false, null, "Kaan Van Maarseveen", "kaanvanmaarseveen@example.com", "kaanvanmaarseveen", "AQAAAAEAACcQAAAAEGqOncE0gHjxYpkiXO42xAvM8RFEhKEDzShj5lDebabuzcpP8NdDJC9Z8+gajbcY5A==", null, false, null, null, false, "kaanvanmaarseveen" },
                    { "23", 0, null, "92c0115f-e540-45e9-8d53-5432e87d4ca1", "owenkaal@example.com", false, "Owen", "Kaal", false, null, "Owen Kaal", "owenkaal@example.com", "owenkaal", "AQAAAAEAACcQAAAAEDwHWWlY1okU+DA2VijUkwb/SF+Pse9uK6kOFDFNvNkKkxwlqVDyoVOAhZb/bzedJA==", null, false, null, null, false, "owenkaal" },
                    { "24", 0, null, "de67e382-36a2-49b4-ae3a-2af739c11927", "paulinebah@example.com", false, "Pauline", "Bah", false, null, "Pauline Bah", "paulinebah@example.com", "paulinebah", "AQAAAAEAACcQAAAAEFwVVM44uySbMhcljJ7L0zkXKyADMNjruxJWJckqeGr2YUQBaYO1Kachc6zlt7xBew==", null, false, null, null, false, "paulinebah" },
                    { "25", 0, null, "e33eccf0-673b-4994-9dbf-c6ae5c954207", "caterinatas@example.com", false, "Caterina", "Tas", false, null, "Caterina Tas", "caterinatas@example.com", "caterinatas", "AQAAAAEAACcQAAAAEGgUssWXZUFHu8exku2/K89oGzAOD+e6++VFd93zMTsQp2KrNKlvmKR9UaFhamrIbA==", null, false, null, null, false, "caterinatas" },
                    { "26", 0, null, "ea67c3f9-ccdf-4be0-b815-9db3a063d036", "edtouw@example.com", false, "Ed", "Touw", false, null, "Ed Touw", "edtouw@example.com", "edtouw", "AQAAAAEAACcQAAAAEPFrvC33AaJT0+mftg70kdWYwPNSj9f9nK/GCpaREWdOSe2T6rAi8kEMNmKJfvVZZA==", null, false, null, null, false, "edtouw" },
                    { "27", 0, null, "9a9ee167-d305-4f92-b247-533cda16353a", "hugofidom@example.com", false, "Hugo", "Fidom", false, null, "Hugo Fidom", "hugofidom@example.com", "hugofidom", "AQAAAAEAACcQAAAAEL8LqRs5vdlvzAuJxdpxrFKvm5KSceInhHjzxyNxKy2i+sSaHFw+RpkKqbaSd6+vtw==", null, false, null, null, false, "hugofidom" },
                    { "28", 0, null, "eda013ed-9094-4953-bcb9-839c115c90d1", "nannebesseling@example.com", false, "Nanne", "Besseling", false, null, "Nanne Besseling", "nannebesseling@example.com", "nannebesseling", "AQAAAAEAACcQAAAAENY1bbWRdPZCBGfv35FuhPY/0f0Ftxj/yhLGNB572S1jXXYg+l9UkIMW8k6PPWhHHA==", null, false, null, null, false, "nannebesseling" },
                    { "29", 0, null, "b3e76898-bcd8-449d-9011-a86ebd96d1c4", "teunisjesalden@example.com", false, "Teunisje", "Salden", false, null, "Teunisje Salden", "teunisjesalden@example.com", "teunisjesalden", "AQAAAAEAACcQAAAAEMfsnUDqNw957HPTlauDvlcopsW9gUGDV5yVwk+Paxp929Y0f7ljKEyZYVKjRb2d1Q==", null, false, null, null, false, "teunisjesalden" },
                    { "3", 0, null, "1f4cd6c9-851a-4690-b2bd-7444a8a8858e", "theotan@example.com", false, "Theo", "Tan", false, null, "Theo Tan", "theotan@example.com", "theotan", "AQAAAAEAACcQAAAAEA9jgMNL3Ez8p8deNWs/oNXBKHu4TXm/iz8cxf+Z7yXL5BG9vaZu2Yb0sTmW/LvlMw==", null, false, null, null, false, "theotan" },
                    { "30", 0, null, "7da15432-e479-4ae8-b756-8ffe90e39516", "rochedoornink@example.com", false, "Roché", "Doornink", false, null, "Roché Doornink", "rochedoornink@example.com", "rochedoornink", "AQAAAAEAACcQAAAAEFeIhSIlHZla1a5X7pm9GgOsCOslrKE84Wns5Y1euXVE8hfAvhafJoOZUEGPNKd2QQ==", null, false, null, null, false, "rochedoornink" },
                    { "31", 0, null, "219874fd-30d0-49f9-88d7-060684503216", "yuenboertien@example.com", false, "Yuen", "Boertien", false, null, "Yuen Boertien", "yuenboertien@example.com", "yuenboertien", "AQAAAAEAACcQAAAAEINiCU+xk8K1ihQC6XHOfo47QaBwQosryYWL5WZ7P9P+OOv4JqrkGC6y/Gfo/whuyg==", null, false, null, null, false, "yuenboertien" },
                    { "32", 0, null, "491fffee-5f57-44a0-b3f8-2c52973afc99", "heinrichmook@example.com", false, "Heinrich", "Mook", false, null, "Heinrich Mook", "heinrichmook@example.com", "heinrichmook", "AQAAAAEAACcQAAAAEPxGyG27fJ131mWDjenjwi9rCCeWnNdVsDeIWaZR+JVsXVsjtCpgkwlhgGbiKSdy7A==", null, false, null, null, false, "heinrichmook" },
                    { "33", 0, null, "f835bc29-2140-4547-93fe-8435fd2961cf", "keriantonisse@example.com", false, "Keri", "Antonisse", false, null, "Keri Antonisse", "keriantonisse@example.com", "keriantonisse", "AQAAAAEAACcQAAAAENmYlBYXIk4r27DsSnYUC8txdaTztkiyXg2BqMRgHLFly7ZRuoSk/SfEMBJXyiPU3A==", null, false, null, null, false, "keriantonisse" },
                    { "34", 0, null, "a5beecf3-5fda-48d9-9a9e-25e8cfcf3f1b", "beerrebergen@example.com", false, "Beer", "Rebergen", false, null, "Beer Rebergen", "beerrebergen@example.com", "beerrebergen", "AQAAAAEAACcQAAAAEIuWNT0xq6SXP7TWt564af+AW6YZCO5mkDzY2Ko/OsZtEvr8r5nx8FwVeIH9s/Sd4A==", null, false, null, null, false, "beerrebergen" },
                    { "35", 0, null, "3af57774-2be9-40b0-8128-99a9930f1541", "kainvandergun@example.com", false, "Kaïn", "Van der Gun", false, null, "Kaïn Van der Gun", "kainvandergun@example.com", "kainvandergun", "AQAAAAEAACcQAAAAEFbocOliO4HJUyJY1N56HstnVvejCnFmngG8Oc3LyHwRcZ4eSSJHr31JTKHXpgWVew==", null, false, null, null, false, "kainvandergun" },
                    { "36", 0, null, "9cc94ff4-ac8c-4d7b-9a55-e5143b89a8cb", "marloeswesterdijk@example.com", false, "Marloes", "Westerdijk", false, null, "Marloes Westerdijk", "marloeswesterdijk@example.com", "marloeswesterdijk", "AQAAAAEAACcQAAAAEGLhw1qsQmrT/HoSBzGNdNwYU70j0ngjroy4JfJj3lk0Hq61tJ6atdVI9gJVqpDjKA==", null, false, null, null, false, "marloeswesterdijk" },
                    { "37", 0, null, "c269e046-29ea-45df-9e0b-fe1481d0a8e7", "aurelieesajas@example.com", false, "Aurélie", "Esajas", false, null, "Aurélie Esajas", "aurelieesajas@example.com", "aurelieesajas", "AQAAAAEAACcQAAAAEJ3VI1xmmqkWTbpHY3L05Lis/fDxw191b9KtrclOZVkN+GX2n3XBUJNKXiwdBamNHA==", null, false, null, null, false, "aurelieesajas" },
                    { "38", 0, null, "85c0b5ac-c8b6-46ca-9d82-05d6198b19d4", "gerlindenooijens@example.com", false, "Gerlinde", "Nooijens", false, null, "Gerlinde Nooijens", "gerlindenooijens@example.com", "gerlindenooijens", "AQAAAAEAACcQAAAAEO3npRJreY5NUAqGfBpLT37B+TrHmcbHT6/FLrAMp/rwPrr7kKAqOyNcjngBIf18Jg==", null, false, null, null, false, "gerlindenooijens" },
                    { "39", 0, null, "00c57082-74a3-43eb-85b3-804cf511878f", "summerbrinkhuis@example.com", false, "Summer", "Brinkhuis", false, null, "Summer Brinkhuis", "summerbrinkhuis@example.com", "summerbrinkhuis", "AQAAAAEAACcQAAAAEDQPbRPW8+xJ2+Zqmo6iFljqlDmmY4zzhioOp+jKjb+tOo6psH78sReaKK8JFvwCXw==", null, false, null, null, false, "summerbrinkhuis" },
                    { "4", 0, null, "927a38af-7f5f-4ef7-aba7-b8beb35e4b3a", "floruscicek@example.com", false, "Florus", "Çiçek", false, null, "Florus Çiçek", "floruscicek@example.com", "floruscicek", "AQAAAAEAACcQAAAAEPU+/d00uRsxnTUx61pLtcnUrN87nkapJ+m3L06zYyt1/VyvDEs3nOJij7mSk/vzgA==", null, false, null, null, false, "floruscicek" },
                    { "40", 0, null, "5ba2bac5-7158-491e-a4ec-6a1ae6bd2b67", "quirinavandusschoten@example.com", false, "Quirina", "Van Dusschoten", false, null, "Quirina Van Dusschoten", "quirinavandusschoten@example.com", "quirinavandusschoten", "AQAAAAEAACcQAAAAEGAYMePiZocWlC/A3VdO4ziZlN7Grk+URtR0VJ7G78dc5MBfJoUpOjgvN7HZR9hjxg==", null, false, null, null, false, "quirinavandusschoten" },
                    { "41", 0, null, "18442d8a-f40c-4187-956d-3c44909cdde4", "emmelienhandels@example.com", false, "Emmelien", "Handels", false, null, "Emmelien Handels", "emmelienhandels@example.com", "emmelienhandels", "AQAAAAEAACcQAAAAEGAmKBXMnODkvXjjjfeaTWfA79MygtWXZNEBWZz9bv0rrB7/HsNzwLAS5V9sA9/lAg==", null, false, null, null, false, "emmelienhandels" },
                    { "42", 0, null, "d3357bc4-7007-4eee-83a9-b519fbd08aac", "wensleycurvers@example.com", false, "Wensley", "Curvers", false, null, "Wensley Curvers", "wensleycurvers@example.com", "wensleycurvers", "AQAAAAEAACcQAAAAEIt9y7wYTbYaZGiq5/2hRRa14a2Y4HDRVWNEjxOfNt3NHgIQe0GQuUqCO8DEkyDxsw==", null, false, null, null, false, "wensleycurvers" },
                    { "43", 0, null, "9e65e35e-7e7f-45cc-a19c-645811f304bb", "dawidvanaart@example.com", false, "Dawid", "Van Aart", false, null, "Dawid Van Aart", "dawidvanaart@example.com", "dawidvanaart", "AQAAAAEAACcQAAAAEOUaf62GZennJb0dSrxr31SHEjbHA5p//jpLid442zfDL+wQKfLCdp7BAMtOhQB1+w==", null, false, null, null, false, "dawidvanaart" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CohortId1", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TimedOut", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5", 0, null, "36bd2dec-7cbc-4fa9-9323-7566d44af25d", "marlenewolf@example.com", false, "Marlène", "Wolf", false, null, "Marlène Wolf", "marlenewolf@example.com", "marlenewolf", "AQAAAAEAACcQAAAAEHLldOMLl74bhGYTD9TeHwN+bteoaYkPQIj5Xf6IyssCVBce40zzLRZj/0LaXijK0w==", null, false, null, null, false, "marlenewolf" },
                    { "6", 0, null, "6c8e8e52-f4d8-4de5-adc3-2ef0d6b8bad5", "bilalsteentjes@example.com", false, "Bilal", "Steentjes", false, null, "Bilal Steentjes", "bilalsteentjes@example.com", "bilalsteentjes", "AQAAAAEAACcQAAAAEMoTQo8bNIQ2E4g+fdJmrOYSv9aOOD+xNnaJzpZbqtjSFfHJHsbZreU+V3MNKecovQ==", null, false, null, null, false, "bilalsteentjes" },
                    { "7", 0, null, "0ee6e37c-da75-4279-b052-f162d80c259e", "marlijngiebels@example.com", false, "Marlijn", "Giebels", false, null, "Marlijn Giebels", "marlijngiebels@example.com", "marlijngiebels", "AQAAAAEAACcQAAAAEAyZjdZcbEnKhcUgUH+PI0y6CTdsplysFhwKZxHJUAY2LE/0Cs0tlnnxf84HTKzWSg==", null, false, null, null, false, "marlijngiebels" },
                    { "8", 0, null, "a59ac976-334c-47e3-b54c-e7ee50bbcd9f", "sabrivandereijk@example.com", false, "Sabri", "Van der Eijk", false, null, "Sabri Van der Eijk", "sabrivandereijk@example.com", "sabrivandereijk", "AQAAAAEAACcQAAAAENzD3Ah5CEM7b0mYM0UXVVDZLqfA5WmAROHNTCqvlmort4LVQaKwL9RxCRwsFtoCLg==", null, false, null, null, false, "sabrivandereijk" },
                    { "9", 0, null, "0a937fd5-e552-41d5-8582-366483f389ac", "caseyandriesse@example.com", false, "Casey", "Andriesse", false, null, "Casey Andriesse", "caseyandriesse@example.com", "caseyandriesse", "AQAAAAEAACcQAAAAEHCskOtp8wwzJObTnab/B/1nix1NvVaBVykSsdgNjaprpKdeXbEaucSw/c4nJC67Xg==", null, false, null, null, false, "caseyandriesse" }
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
                    { 4, "Description for Semester Item 4", "Semester Item 4", 2, "[2]" }
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
                table: "StudyRoutes",
                columns: new[] { "Id", "Approved_eb", "Approved_sb", "Name", "Note", "Send_eb", "Send_sb", "UserId" },
                values: new object[] { 1, true, true, "Computer Science", "This is a note", true, true, "1" });

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
