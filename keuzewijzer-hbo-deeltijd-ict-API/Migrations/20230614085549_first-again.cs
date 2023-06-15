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
                    { "1", "8594c432-9443-455c-aa23-59aabaff88d1", "Administrator", "ADMINISTRATOR", null },
                    { "2", "168efd2a-75b0-4ac7-b057-5121717821ef", "Student", "STUDENT", null },
                    { "3", "b0a1e7ec-2378-4eed-86ef-d516b86f1804", "Studiebegeleider", "STUDIEBEGELEIDER", null },
                    { "4", "0f265fe4-627a-4df4-8d60-ae54265bc5f6", "Moduleverantwoordelijke", "MODULEVERANTWOORDELIJKE", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CohortId1", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TimedOut", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, null, "97b80d07-a16d-4709-b6fd-0c7376838e27", "admin@example.com", false, "Arnold", "Min", false, null, "Arnold Dirk Min", "admin@example.com", "admin", "AQAAAAEAACcQAAAAEHPlBfbw+mM/UmAW6I7Ph+IWtBouDwlmX+vIQK5wCPR4B9NhxV7tumq/rrtVh14Vrg==", null, false, "9b97229a-1eb9-43d9-87e4-00af434b818a", null, false, "admin" },
                    { "10", 0, null, "39681104-4710-4dce-bbda-64aa422c871d", "nikhuijskens@example.com", false, "Nik", "Huijskens", false, null, "Nik Huijskens", "nikhuijskens@example.com", "nikhuijskens", "AQAAAAEAACcQAAAAEGUdYYAM8R/dOVu3/x2wIo04LzZu+C3gvi0owmhw+5zTeHILJ3iY/lJ9gb5CQKJI1w==", null, false, "656408fa-daa7-4379-9ab5-f2096420af99", null, false, "nikhuijskens" },
                    { "11", 0, null, "97e234d4-5add-4e37-bac0-f7ae93ab6e27", "duranpetiet@example.com", false, "Duran", "Petiet", false, null, "Duran Petiet", "duranpetiet@example.com", "duranpetiet", "AQAAAAEAACcQAAAAECgu2NP8aGi6L9Dn0RaHMHWZJcjTxZuQnIWje4ucTeP8bNuA1tiNVvRKMqs/PUE25A==", null, false, "a7c8fd29-b6b5-432b-add5-dee230099b2d", null, false, "duranpetiet" },
                    { "12", 0, null, "057b2e81-d5c4-41c3-9e58-759e6e937a1c", "veroniekbravenboer@example.com", false, "Veroniek", "Bravenboer", false, null, "Veroniek Bravenboer", "veroniekbravenboer@example.com", "veroniekbravenboer", "AQAAAAEAACcQAAAAEIE730MQYWEItFyfDfFFNjDvVSGAkK54mNrvanOXUwnjHGx1XqzUPAhR3t4fcleQZw==", null, false, "57b1c53c-4a18-4981-8fff-b041de0b2bc5", null, false, "veroniekbravenboer" },
                    { "13", 0, null, "74651ce5-9c3e-49a8-91ac-aaded0fdecba", "kaynejagtenberg@example.com", false, "Kayne", "Jagtenberg", false, null, "Kayne Jagtenberg", "kaynejagtenberg@example.com", "kaynejagtenberg", "AQAAAAEAACcQAAAAEPX7R5aYxrsV1jpOc52fLRODrVvxjjrX7IHNME9zkU1BuRgGTGFfjm8ZsB/bbsyZwg==", null, false, "baedb2f6-4643-47ef-b165-d6f35d5f0d33", null, false, "kaynejagtenberg" },
                    { "14", 0, null, "09d0cf03-65ed-4abd-b9be-1370041b3778", "siebrigjeabdi@example.com", false, "Siebrigje", "Abdi", false, null, "Siebrigje Abdi", "siebrigjeabdi@example.com", "siebrigjeabdi", "AQAAAAEAACcQAAAAEL5tvJ9Qr7umVjrGvTlaHY+xPXpm7Jrd27qS7tZRqE3jfdYJnPlB3TZM8VHamx2ZNg==", null, false, "79409a68-bd39-4bea-922a-25973e92dad8", null, false, "siebrigjeabdi" },
                    { "15", 0, null, "13d9f965-99d6-4d3b-bfac-30a7a3497e81", "sterrelambert@example.com", false, "Sterre", "Lambert", false, null, "Sterre Lambert", "sterrelambert@example.com", "sterrelambert", "AQAAAAEAACcQAAAAENOcyVJwCddRPVMUNQATjvThqMYEOMybH4mXBoRNeNo8bcFE0Tx6D6uEk8ZnLJt+nw==", null, false, "2ecf7d05-3706-4d00-8cf7-d34d06947f8e", null, false, "sterrelambert" },
                    { "16", 0, null, "b6898138-60e9-417f-999a-981e17e515fe", "milicavandergouw@example.com", false, "Milica", "Van der Gouw", false, null, "Milica Van der Gouw", "milicavandergouw@example.com", "milicavandergouw", "AQAAAAEAACcQAAAAEIyhDWRc4SQ9l31SCFnpm8SWfPfVc585punw7Ul44+K8h0B3pTsCUxqwwx3oVElKnw==", null, false, "e1eba1ec-5c0c-45b9-8085-38caf59eb39c", null, false, "milicavandergouw" },
                    { "17", 0, null, "05b3caeb-def7-4eef-baa9-d88759134f1c", "yvonbrussaard@example.com", false, "Yvon", "Brussaard", false, null, "Yvon Brussaard", "yvonbrussaard@example.com", "yvonbrussaard", "AQAAAAEAACcQAAAAEIcPofqWrm3KbC7dPoKu15Ur3ea7+P0zhViAuIuxV6HB2tIW6+x3YKUqqxusg6OakQ==", null, false, "5d4301ae-f302-4dfb-839e-52062d577514", null, false, "yvonbrussaard" },
                    { "18", 0, null, "fcaeaad7-5e98-4f9e-8c03-4bf2f34aad78", "bodhidatema@example.com", false, "Bodhi", "Datema", false, null, "Bodhi Datema", "bodhidatema@example.com", "bodhidatema", "AQAAAAEAACcQAAAAEBaITH77cE0cToPhxhpW5eGmnneVBonOKV0G13XsnJftAznDtSE9v7AMcRutShwCiA==", null, false, "867cd4c5-75e5-4c3e-944f-7514f7aa8a73", null, false, "bodhidatema" },
                    { "19", 0, null, "a61b606f-34af-4124-b452-199733cfe891", "noachschutrups@example.com", false, "Noach", "Schutrups", false, null, "Noach Schutrups", "noachschutrups@example.com", "noachschutrups", "AQAAAAEAACcQAAAAEGKpRn3pWbfUlJYjnfcE8IQK0HAD6hYS2sZC8ZWqMWQHk8h+ZxwAvwgxABQ0xo3GNw==", null, false, "ce26a923-0670-46ca-99e0-3fcdbf201ca5", null, false, "noachschutrups" },
                    { "2", 0, null, "c08e82ce-a137-453c-b6fb-17989f06550d", "eugenevanroden@example.com", false, "Eugene", "Van Roden", false, null, "Eugene Van Roden", "eugenevanroden@example.com", "eugenevanroden", "AQAAAAEAACcQAAAAENTRp7+yOCI+oD7QcGq/536nRV3jqiP6/C1hbuZRaSWSEv0BSJfTAOOyiBazRiY9Hw==", null, false, "d542bbc2-0638-4d58-9af3-5c4e2297065c", null, false, "eugenevanroden" },
                    { "20", 0, null, "7ed39d3f-cafc-4c6e-8b58-1f66f9ae358a", "ouassimbekking@example.com", false, "Ouassim", "Bekking", false, null, "Ouassim Bekking", "ouassimbekking@example.com", "ouassimbekking", "AQAAAAEAACcQAAAAEHS7gbSp7BCPFxHf/pvopJKB4xC6Z51y+HsZkJK0TnJwQjfakok4m6IM4d3u+DxWrA==", null, false, "27539f4b-72db-4c16-b010-18e4575881bb", null, false, "ouassimbekking" },
                    { "21", 0, null, "728fa57c-cac7-4e15-a6f7-b8a7c2e0d087", "noervanderkruit@example.com", false, "Noer", "Van der Kruit", false, null, "Noer Van der Kruit", "noervanderkruit@example.com", "noervanderkruit", "AQAAAAEAACcQAAAAEC06VJjQnTtrBfqIPmZF0oDMv8YDi3CHELHjfE2iODog0xz6ebSzVyMmCQ9zvqae7Q==", null, false, "cbacbaad-7548-40e4-96ab-a29c6f2dcdae", null, false, "noervanderkruit" },
                    { "22", 0, null, "4a822044-c9e4-44ba-bc34-2952d1608c7b", "kaanvanmaarseveen@example.com", false, "Kaan", "Van Maarseveen", false, null, "Kaan Van Maarseveen", "kaanvanmaarseveen@example.com", "kaanvanmaarseveen", "AQAAAAEAACcQAAAAEP5Yz6xDhjtDQcKU9EC6hml1kD94febKjDLcFMvDNfXo+a7xndEIPC0g6gVFlwNUwQ==", null, false, "627b188c-7742-4ccb-b965-57003afe16bf", null, false, "kaanvanmaarseveen" },
                    { "23", 0, null, "3ee5afd7-9d21-404a-ac60-6e0b16fb2599", "owenkaal@example.com", false, "Owen", "Kaal", false, null, "Owen Kaal", "owenkaal@example.com", "owenkaal", "AQAAAAEAACcQAAAAEPas9qMHPpjgUsDgK4OYrZW5Wznr8nlkBSGv4RQH7NE/5tkQ5VwxbJbS1yT0VMPQog==", null, false, "fe135693-385a-4257-97f2-c8bdbb9ae42e", null, false, "owenkaal" },
                    { "24", 0, null, "95969151-08c3-4c9f-8387-24409cc75718", "paulinebah@example.com", false, "Pauline", "Bah", false, null, "Pauline Bah", "paulinebah@example.com", "paulinebah", "AQAAAAEAACcQAAAAEBN68TcMLPMndn/rcpHiiW2fYkcCB+MdtSQRI+N7jSf/k0ns19M/G5z/iLCPh4jdZw==", null, false, "200e1fdd-3e46-481b-a6fc-1278d626c857", null, false, "paulinebah" },
                    { "25", 0, null, "aadaac46-1d18-4812-8af5-d01e76869c9e", "caterinatas@example.com", false, "Caterina", "Tas", false, null, "Caterina Tas", "caterinatas@example.com", "caterinatas", "AQAAAAEAACcQAAAAEPE16nh1+ohlm3jBlfzNNiMgTWLClGy2YDXWi4sjzOGG2j/bRxrYG4TzPG5AILMOCw==", null, false, "7c95df06-2be1-48d8-92c9-789640cad0d9", null, false, "caterinatas" },
                    { "26", 0, null, "3a439a1c-2cb7-4437-87d2-279d855e9ca5", "edtouw@example.com", false, "Ed", "Touw", false, null, "Ed Touw", "edtouw@example.com", "edtouw", "AQAAAAEAACcQAAAAEB/mFsmJWKge2c1wyYGGftqjYeUxBApw9Slj5SZ9JzugYcmkzv75Dev7F6QmcODwYw==", null, false, "11f807e9-91a2-4aa5-851b-3f8fdaec6c86", null, false, "edtouw" },
                    { "27", 0, null, "8cf0ed21-0e57-4d2c-9744-f7a8b9e4e715", "hugofidom@example.com", false, "Hugo", "Fidom", false, null, "Hugo Fidom", "hugofidom@example.com", "hugofidom", "AQAAAAEAACcQAAAAEBkU8jqWMKhClYq5j+6FixUO7BNJ/Av31j+Y+OxGT6oI/6zumbFIUISD5fE0gX0USA==", null, false, "06c89535-c4fb-4bd7-ab72-fc22d9e41dd0", null, false, "hugofidom" },
                    { "28", 0, null, "c3a53afe-79a6-4d45-8c96-ca493b1108bf", "nannebesseling@example.com", false, "Nanne", "Besseling", false, null, "Nanne Besseling", "nannebesseling@example.com", "nannebesseling", "AQAAAAEAACcQAAAAEHyxUZ41mp+zn5rQdWQRHVqtRQeZEoQwQEvSkl2BC1HV3J9CwoEi9M/V4vrQ6EE1TQ==", null, false, "d2dc1419-2eba-4e49-a67d-2b5232b2bc6d", null, false, "nannebesseling" },
                    { "29", 0, null, "54903e5e-1f40-42af-a4bc-9047fb8b6b94", "teunisjesalden@example.com", false, "Teunisje", "Salden", false, null, "Teunisje Salden", "teunisjesalden@example.com", "teunisjesalden", "AQAAAAEAACcQAAAAEKXf9kKy1XjPks8uNe5UFKfXkSpigq0/sekGXmZ/OIwFKKgswmAO8dqdCh77elIGyQ==", null, false, "eda54fa4-4505-442e-95fe-79a80a74499d", null, false, "teunisjesalden" },
                    { "3", 0, null, "d173ecf4-dbf4-4f9b-956d-a4e7b0200183", "theotan@example.com", false, "Theo", "Tan", false, null, "Theo Tan", "theotan@example.com", "theotan", "AQAAAAEAACcQAAAAEDOELd8Bzag/JUXlWDxrayPOMPmtHfj0XNVMmsBVelbKDDHFjdar9PXPWtKi79T/qQ==", null, false, "cdc079b1-d327-4693-a439-0bf6a2c95741", null, false, "theotan" },
                    { "30", 0, null, "02de5540-d58a-428c-9d43-7024cd81342b", "rochedoornink@example.com", false, "Roché", "Doornink", false, null, "Roché Doornink", "rochedoornink@example.com", "rochedoornink", "AQAAAAEAACcQAAAAEP3a2mlXdZn61m6FnZRekeWvASLENl9PydwogB1JkCBsGktMr0UcFB6o2yMJBmOIVA==", null, false, "93e62a84-1853-4688-9973-d6f625a03e09", null, false, "rochedoornink" },
                    { "31", 0, null, "c53f94c2-6273-462f-949d-03b446603453", "yuenboertien@example.com", false, "Yuen", "Boertien", false, null, "Yuen Boertien", "yuenboertien@example.com", "yuenboertien", "AQAAAAEAACcQAAAAEGsd2OhTsExLohFQ0vJcD6hxPL+xzKxWziaER6uoC+Tmw173PlSF9NjJ9KKXLHddcA==", null, false, "59715bb0-68ae-4b02-b202-3ed595779bf2", null, false, "yuenboertien" },
                    { "32", 0, null, "fe48f7c6-e615-4de9-b32b-346560e2c4f4", "heinrichmook@example.com", false, "Heinrich", "Mook", false, null, "Heinrich Mook", "heinrichmook@example.com", "heinrichmook", "AQAAAAEAACcQAAAAEOJArh5dubF/KObTD7IHe27wgBAZhMKt87dVBc60Waxk4OMI5+Ke7CogDZq0666hbQ==", null, false, "3b5c28cb-d243-4722-853b-ffe610d237ca", null, false, "heinrichmook" },
                    { "33", 0, null, "8ea42ab7-854b-4f27-a27e-281912eb8726", "keriantonisse@example.com", false, "Keri", "Antonisse", false, null, "Keri Antonisse", "keriantonisse@example.com", "keriantonisse", "AQAAAAEAACcQAAAAEHUkq115WiqhQUkj2jK4B5jIhtM2S+pdv9ZgoYFOf1rf9g116w90CrEI+XGX1xhviw==", null, false, "2ad4eeae-15dd-4c36-91c8-75c6407ec17f", null, false, "keriantonisse" },
                    { "34", 0, null, "7247ad18-aefb-4a87-b287-87091fa94659", "beerrebergen@example.com", false, "Beer", "Rebergen", false, null, "Beer Rebergen", "beerrebergen@example.com", "beerrebergen", "AQAAAAEAACcQAAAAEAc3bJ7ZJEYlQcxHh+tBs3hdspEowmxjfUql4NzZZuVbDn9E7B/ggi2lCrmcR2L//w==", null, false, "e6970d57-a772-4081-ba22-d3f38ee8e4af", null, false, "beerrebergen" },
                    { "35", 0, null, "d902891b-2f4f-4150-8685-a6d4e4a5ace1", "kainvandergun@example.com", false, "Kaïn", "Van der Gun", false, null, "Kaïn Van der Gun", "kainvandergun@example.com", "kainvandergun", "AQAAAAEAACcQAAAAELnxar9rklY8T+Y7eXuI43mBWerC591AD46ZAK8R5pTryoFdAgdVfhFYU6RJNsUaxw==", null, false, "7f232687-4754-4c0c-8c7a-240627992642", null, false, "kainvandergun" },
                    { "36", 0, null, "bdc95d93-a14d-4527-93b4-031de94df594", "marloeswesterdijk@example.com", false, "Marloes", "Westerdijk", false, null, "Marloes Westerdijk", "marloeswesterdijk@example.com", "marloeswesterdijk", "AQAAAAEAACcQAAAAENl7U2dkrCTmBSYWtJveZfksOV+OuPxqwCgyS2V8oHLfzIkc1leG9sSBipTfDaagSQ==", null, false, "2e8f9d98-8a81-45a0-a610-d136c3abde25", null, false, "marloeswesterdijk" },
                    { "37", 0, null, "032dca53-b7c4-4ff3-b00c-676965998407", "aurelieesajas@example.com", false, "Aurélie", "Esajas", false, null, "Aurélie Esajas", "aurelieesajas@example.com", "aurelieesajas", "AQAAAAEAACcQAAAAEOyhhRfXiq4acKgOT8TlEB612ggrAnY5X/HPWBSKy1C+5KCORl32o8X99zzWVo+s2Q==", null, false, "94e5eb82-abd2-4916-87cd-cd869d5adf64", null, false, "aurelieesajas" },
                    { "38", 0, null, "d6263288-0aa6-4979-acf5-13cb2a2f4663", "gerlindenooijens@example.com", false, "Gerlinde", "Nooijens", false, null, "Gerlinde Nooijens", "gerlindenooijens@example.com", "gerlindenooijens", "AQAAAAEAACcQAAAAENVsNrsz8nLoUL47YoDBZwl55/mnEKmawq42f+nv0V4QiIdPAi9ItEgLTLAykExCqg==", null, false, "b23859ea-5e74-4dfd-befb-fd2df0f0a482", null, false, "gerlindenooijens" },
                    { "39", 0, null, "b4358ddc-efd3-4fab-a05a-4959ed7d96ff", "summerbrinkhuis@example.com", false, "Summer", "Brinkhuis", false, null, "Summer Brinkhuis", "summerbrinkhuis@example.com", "summerbrinkhuis", "AQAAAAEAACcQAAAAEH8m3SL/eknlo6w189zHcoaSS8YRrLhcVZaITzSYwhRF3b8+znLc0nbt/ZZuv3f12g==", null, false, "61e5bc96-8b15-496a-9d51-7f3a7eb2827d", null, false, "summerbrinkhuis" },
                    { "4", 0, null, "f2d6f8be-6943-47c2-9155-cc1aadc8efa2", "floruscicek@example.com", false, "Florus", "Çiçek", false, null, "Florus Çiçek", "floruscicek@example.com", "floruscicek", "AQAAAAEAACcQAAAAENDGYjnpWlxz+DSBgIynmvlg0ltrECypdeUkjKlY6ngieRPEtehGF6EPQ6G1UNPQWQ==", null, false, "7c5c640a-f588-482b-8e26-cf304b28f6a2", null, false, "floruscicek" },
                    { "40", 0, null, "ce4529fa-133f-4095-b815-37228ac92ab9", "quirinavandusschoten@example.com", false, "Quirina", "Van Dusschoten", false, null, "Quirina Van Dusschoten", "quirinavandusschoten@example.com", "quirinavandusschoten", "AQAAAAEAACcQAAAAEKUzNA/bSg5WcLW1/a7mXQcrDZDHy1UwZVbsa7K2VdMTDMwSYSWnLDGncezG57WqmQ==", null, false, "688e2151-d5e6-4eaa-ad45-c361959f1a90", null, false, "quirinavandusschoten" },
                    { "41", 0, null, "f7b243d4-fb21-4072-aa33-2ce375ab37bd", "emmelienhandels@example.com", false, "Emmelien", "Handels", false, null, "Emmelien Handels", "emmelienhandels@example.com", "emmelienhandels", "AQAAAAEAACcQAAAAELDepxczXvE0sC6K7Jgax0AuRcYj5KY6wpVBeibR23d50ij9wmOvpBxPPwlGcNOq1A==", null, false, "b8d6566c-3723-4eff-a549-9d9c60c4e738", null, false, "emmelienhandels" },
                    { "42", 0, null, "7289678c-6515-4fc8-b09f-21b92fe7f4e1", "wensleycurvers@example.com", false, "Wensley", "Curvers", false, null, "Wensley Curvers", "wensleycurvers@example.com", "wensleycurvers", "AQAAAAEAACcQAAAAEAtqzyRXrnsvXloY2URsLDtt6IfuR5FzQtdzkHd9vifvoUptEHmTL6PJlrjXgueqdg==", null, false, "e8feb0fd-f9b8-48d0-9a5e-402d497debe6", null, false, "wensleycurvers" },
                    { "43", 0, null, "d6284039-ea1c-4839-9259-885aced23c90", "dawidvanaart@example.com", false, "Dawid", "Van Aart", false, null, "Dawid Van Aart", "dawidvanaart@example.com", "dawidvanaart", "AQAAAAEAACcQAAAAEMJs+fBfewlBuqMqgAdtcvwDim6JPM/RtkN6Ih10FDg1JMyxtortqBSsK9B8WQAJBg==", null, false, "bf77c816-ffb6-4ef1-b4d9-1fa349f7d973", null, false, "dawidvanaart" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CohortId1", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TimedOut", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5", 0, null, "ea744403-d67e-4f80-a48c-9289dbc95c7c", "marlenewolf@example.com", false, "Marlène", "Wolf", false, null, "Marlène Wolf", "marlenewolf@example.com", "marlenewolf", "AQAAAAEAACcQAAAAEGf0xtH+VudLrCOeqt6++mwBL/eXF/l1GCBKQ+38avle8hM3g+aZz/bmXLGrEw/MHA==", null, false, "013f89a1-e33f-490b-a9bd-0b66740961d7", null, false, "marlenewolf" },
                    { "6", 0, null, "def282fa-7d82-493a-ba6a-01bbafea719a", "bilalsteentjes@example.com", false, "Bilal", "Steentjes", false, null, "Bilal Steentjes", "bilalsteentjes@example.com", "bilalsteentjes", "AQAAAAEAACcQAAAAEBpI+Isjb4i6TnwlUJIg5U//HWbcrk1a/YVghctpzJN/uCCKcuP9AKYqIig6qFXlgw==", null, false, "f7013f10-0858-48dc-9e8d-5ad21b83e13c", null, false, "bilalsteentjes" },
                    { "7", 0, null, "a474edd2-9995-429e-affd-260f99920860", "marlijngiebels@example.com", false, "Marlijn", "Giebels", false, null, "Marlijn Giebels", "marlijngiebels@example.com", "marlijngiebels", "AQAAAAEAACcQAAAAEFGwDfSqM7ZW8C2av1LLdpqlzEggcbuytqtfRCiG1xpDoNG/PqQjsNJYqFHCjySvYQ==", null, false, "95a2a95a-768a-4492-ac3f-dece8499d845", null, false, "marlijngiebels" },
                    { "8", 0, null, "3bc34217-6797-4e17-8b97-c0d217fe6835", "sabrivandereijk@example.com", false, "Sabri", "Van der Eijk", false, null, "Sabri Van der Eijk", "sabrivandereijk@example.com", "sabrivandereijk", "AQAAAAEAACcQAAAAECARmuaUPS48+QyYiNOcROFOAtPXxASvQebxUefbM9VMvX5YikGamFm1GksK0JmJCQ==", null, false, "b007e0e2-8eae-4d7f-8fea-487e1c0ac172", null, false, "sabrivandereijk" },
                    { "9", 0, null, "ceb17797-93e5-47be-8fed-d94acd6a28df", "caseyandriesse@example.com", false, "Casey", "Andriesse", false, null, "Casey Andriesse", "caseyandriesse@example.com", "caseyandriesse", "AQAAAAEAACcQAAAAEC7gbnTlFEAQpEqEc467lu3YVRV/1QP3yUyrbYrYirrcQEAZ5cT2dosHrmJTT7fxcg==", null, false, "571263e1-3858-4fc3-8750-3c454bf7e25d", null, false, "caseyandriesse" }
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
