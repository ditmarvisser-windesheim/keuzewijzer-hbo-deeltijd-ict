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
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Cohorts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
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
                    UserId = table.Column<int>(type: "int", nullable: true)
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
                    UsersId = table.Column<int>(type: "int", nullable: false)
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
                    UsersId = table.Column<int>(type: "int", nullable: false)
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
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TimedOut", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "d80d7bed-0397-44f8-b96b-8c43f0b2802a", "admin@example.com", false, "Arnold", "Min", false, null, "Arnold Dirk Min", null, null, "AQAAAAEAACcQAAAAEPg2mFrR/oATEXDQS6SCH8r2KiioLnYgRfSe033gewsfNfS9V220+A44MX/EbWFyow==", null, false, null, null, false, "admin@example.com" },
                    { 2, 0, "c2f3b2be-5496-4a79-83d5-3a7d7c7d4cc5", "eugenevanroden@example.com", false, "Eugene", "Van Roden", false, null, "Eugene Van Roden", null, null, "AQAAAAEAACcQAAAAEKshQUYk9YGvj/hnEhuOSDmMSWDvXy+YySUmtCxqRvhNPhFj11mYn+jP42t3ez8N2g==", null, false, null, null, false, "eugenevanroden@example.com" },
                    { 3, 0, "80d9abac-1a4f-4f35-bbed-764c0710b0b1", "theotan@example.com", false, "Theo", "Tan", false, null, "Theo Tan", null, null, "AQAAAAEAACcQAAAAEMFzvkLwTozmgqbpFxWz1JAgURjpAOWygtU5+SkAi7N1OsmY6WY1S/VVG1OJpnn6nw==", null, false, null, null, false, "theotan@example.com" },
                    { 4, 0, "e396899f-4571-4943-accc-5f27f4aa2bb0", "cloekras@example.com", false, "Cloé", "Kras", false, null, "Cloé Kras", null, null, "AQAAAAEAACcQAAAAEGgtlEnoi1tyiCgRE8Et9GSK+kAFv3qTCutBbctN/fsRDZIKe77HfjnvAUzi3e7/Gw==", null, false, null, null, false, "cloekras@example.com" },
                    { 5, 0, "8782c05e-8985-4f63-9af6-21947951d90c", "maurivannuland@example.com", false, "Mauri", "Van Nuland", false, null, "Mauri Van Nuland", null, null, "AQAAAAEAACcQAAAAEKqr6pV8WoJ4TfcdlNUUwW33vldxu1t3/JsgXvW5tRW468YHex68r4qetJ5PHi7Ubg==", null, false, null, null, false, "maurivannuland@example.com" },
                    { 6, 0, "192ee017-3b13-4ff7-a3bc-ada65538b0e4", "jeromeheerink@example.com", false, "Jerome", "Heerink", false, null, "Jerome Heerink", null, null, "AQAAAAEAACcQAAAAEKECcBpbSlZsVf9UHUx8ngcwKPMLxu+WxYjrqHC2dBaw/wKsKttGKNrcAVtMQsPREg==", null, false, null, null, false, "jeromeheerink@example.com" },
                    { 7, 0, "6c56fac3-35bb-4156-ae90-9f10c9a99ee1", "semihvanburken@example.com", false, "Semih", "Van Burken", false, null, "Semih Van Burken", null, null, "AQAAAAEAACcQAAAAENrYwL9ZIlf5ZlMmSajxxHkQQ7mV/54XvmjIlD7ADdNJLIAtU8E8dwg13VjLUn9hFg==", null, false, null, null, false, "semihvanburken@example.com" },
                    { 8, 0, "6a7a019d-07bb-4279-afd3-c0e28ab376ce", "jacomijntjemoraal@example.com", false, "Jacomijntje", "Moraal", false, null, "Jacomijntje Moraal", null, null, "AQAAAAEAACcQAAAAEMb2/ji9ila6EMFr4bfzbo3Ik3abGOgtMImasagoPyr1pVMsG5C/XZy09jWsaaHP5g==", null, false, null, null, false, "jacomijntjemoraal@example.com" },
                    { 9, 0, "0d38ddb6-9f09-45c3-b705-4745acbb1205", "sjuulalma@example.com", false, "Sjuul", "Alma", false, null, "Sjuul Alma", null, null, "AQAAAAEAACcQAAAAEOdZ4+bSaE+XEnTaj++LFYNPJH21s5wByGnmYZ/ECueUqd5xXZ4hZTwIVEsT21IXBQ==", null, false, null, null, false, "sjuulalma@example.com" },
                    { 10, 0, "042d23f6-e244-4b00-9cca-6ee5f86f1b27", "sharonapouw@example.com", false, "Sharona", "Pouw", false, null, "Sharona Pouw", null, null, "AQAAAAEAACcQAAAAEAlbYaL9rsdUSA4MBALh54vUXcVVm2YbnLDoYVXNBtbeM0kue9SS/ouo1GvqRIGS3g==", null, false, null, null, false, "sharonapouw@example.com" },
                    { 11, 0, "4aa87ce8-cd23-4509-8c8f-8fe4ba225266", "ashwienabbenhuis@example.com", false, "Ashwien", "Abbenhuis", false, null, "Ashwien Abbenhuis", null, null, "AQAAAAEAACcQAAAAED+VIevxbpH6ogx6HK3iOBDAvITIePgmHBGKla7EujGRLJCzmM1FW7gRPEcXxdvWmw==", null, false, null, null, false, "ashwienabbenhuis@example.com" },
                    { 12, 0, "10f397d3-eb06-450f-872a-b4ef4d71d2bb", "raulverdaasdonk@example.com", false, "Raul", "Verdaasdonk", false, null, "Raul Verdaasdonk", null, null, "AQAAAAEAACcQAAAAEJ0d67Vs1PNtjzwX+hJP3N/MpbYgoHxmebIo3fwUQ2djoc7vNOjoIaN4/ksDgGV7IA==", null, false, null, null, false, "raulverdaasdonk@example.com" },
                    { 13, 0, "b9e8422a-542b-4ddc-8001-b2d879986a6c", "majellawessels@example.com", false, "Majella", "Wessels", false, null, "Majella Wessels", null, null, "AQAAAAEAACcQAAAAEEfr1rnkqcvJF+43bvHdqU8DIXRNW99koKjHYxlcDIKAqnvj1dWrKFndDpd7cGodlw==", null, false, null, null, false, "majellawessels@example.com" },
                    { 14, 0, "626927b3-7c03-47d2-865a-1a4cf9774a1a", "kwintlogtenberg@example.com", false, "Kwint", "Logtenberg", false, null, "Kwint Logtenberg", null, null, "AQAAAAEAACcQAAAAELrfGBxNP2xOGreBgNBhbr9hJUK1Fi+aqqVYXjLG5+wqkdrdLjl0KwjIVQ0xSIT04w==", null, false, null, null, false, "kwintlogtenberg@example.com" },
                    { 15, 0, "fd2a1e43-0077-4046-af02-b01f3f55adf4", "mikhaillebbink@example.com", false, "Mikhail", "Lebbink", false, null, "Mikhail Lebbink", null, null, "AQAAAAEAACcQAAAAEJmDxVekfPcGafuQGOclXhWrQtyRT8bvzUWlYVK6C1IzhZxdAZeTi4GUh+p8sEKgSw==", null, false, null, null, false, "mikhaillebbink@example.com" },
                    { 16, 0, "c4ae505c-3acc-4c46-bb7c-ff40d8b4e6c2", "claylier@example.com", false, "Clay", "Lier", false, null, "Clay Lier", null, null, "AQAAAAEAACcQAAAAEKZAQK8kWIdqMQ6pLIG25fiIvMA/moM7G1sJl1cAu7CSrM16KabFmlQTNzF+c+XBYQ==", null, false, null, null, false, "claylier@example.com" },
                    { 17, 0, "276f2eb2-ee58-4a48-ac6b-5b76e32cea64", "rubinavanderhout@example.com", false, "Rubina", "Van der Hout", false, null, "Rubina Van der Hout", null, null, "AQAAAAEAACcQAAAAEGrSquMWEk852XDn8NeWmebwdv8klOUwnIqi3AQFPAl+c5ZdhGKbcxA0PaVOlLv18w==", null, false, null, null, false, "rubinavanderhout@example.com" },
                    { 18, 0, "da0f9e04-a7d2-4c08-9086-0a5861b0b99d", "abderrazakblaauwbroek@example.com", false, "Abderrazak", "Blaauwbroek", false, null, "Abderrazak Blaauwbroek", null, null, "AQAAAAEAACcQAAAAEJ4oq23H28j+4eb7QCvuFpVs22FqVHGlVaNOW6BNHj+5SwSA4x90/EJV3wyJYsrkng==", null, false, null, null, false, "abderrazakblaauwbroek@example.com" },
                    { 19, 0, "357c3644-6ae9-4909-8039-642371fccbe9", "yannikconsten@example.com", false, "Yannik", "Consten", false, null, "Yannik Consten", null, null, "AQAAAAEAACcQAAAAED0FEF+MRnPMvAZpMWh8/ZNmSFgw8TJ/72rjjoBPBinOLQY6oYrqBuFtwCBjYJmmOw==", null, false, null, null, false, "yannikconsten@example.com" },
                    { 20, 0, "20f900b5-ecf2-4bb9-b40d-46ea2a408716", "niniboekhoudt@example.com", false, "Nini", "Boekhoudt", false, null, "Nini Boekhoudt", null, null, "AQAAAAEAACcQAAAAEGYv2VjatR4l4g4csPYckyf4vFcxobe/M0URxK3YRudPey+Ao5umgGTtLVC2NTRieA==", null, false, null, null, false, "niniboekhoudt@example.com" },
                    { 21, 0, "ab4ee01a-9403-4a86-9f05-2cb2b26d3df3", "mounssifborkent@example.com", false, "Mounssif", "Borkent", false, null, "Mounssif Borkent", null, null, "AQAAAAEAACcQAAAAEIOw7rq/GLndUsJxrjVZRKyUzEtd8xeKvI2CJo/k6HpFFOtZqjIP+Dh+1Mx8iBuiHg==", null, false, null, null, false, "mounssifborkent@example.com" },
                    { 22, 0, "b3a9e976-5f1b-4428-b49b-2e56b7f3c8cf", "metjeknoef@example.com", false, "Metje", "Knoef", false, null, "Metje Knoef", null, null, "AQAAAAEAACcQAAAAEPgLH4ueVC+rOaInebgVtLQnyLp7o8gv+0dYzxplgzN0jJXBJqbIZewh08vVNl5QbA==", null, false, null, null, false, "metjeknoef@example.com" },
                    { 23, 0, "492fe412-8108-4c39-a8c5-276af57da8b3", "lolkjehagoort@example.com", false, "Lolkje", "Hagoort", false, null, "Lolkje Hagoort", null, null, "AQAAAAEAACcQAAAAEIDg0KN170SflZx1biA6DmQuv+BAneh6/9HI6ylpKKs5d9k6+3cm6XCvLaJ4QDN37w==", null, false, null, null, false, "lolkjehagoort@example.com" },
                    { 24, 0, "73aa800a-6204-4e32-b36a-68dc3dc0d13c", "sabriadenissen@example.com", false, "Sabria", "Denissen", false, null, "Sabria Denissen", null, null, "AQAAAAEAACcQAAAAEL5JFYoifh8Un8KQPypz4bdM337EAXTa4rPrHMqGs2kS59PuUmLb0RBAoJbhCbc3Hg==", null, false, null, null, false, "sabriadenissen@example.com" },
                    { 25, 0, "2253faaf-255c-4034-880d-dc227962bef6", "farukvanschip@example.com", false, "Faruk", "Van Schip", false, null, "Faruk Van Schip", null, null, "AQAAAAEAACcQAAAAEFYAwV/rAkAOVigmcYbhXuiuoPpRczAOrVZ7qScuwYLTphAqiX4NVwZRnw2oaFLGtw==", null, false, null, null, false, "farukvanschip@example.com" },
                    { 26, 0, "193c5e44-9915-4ff4-8d71-aa79e132b3ba", "zakariadraaisma@example.com", false, "Zakaria", "Draaisma", false, null, "Zakaria Draaisma", null, null, "AQAAAAEAACcQAAAAEJ6I5VKCMxCGrn0KQmUfyRqSSreWevTYCGxt2D0Fb6XsOZUayj2FwzUhkxLmWisr6w==", null, false, null, null, false, "zakariadraaisma@example.com" },
                    { 27, 0, "55bea2c6-ec49-4dd2-9774-c755ad1c90c9", "oguzheessels@example.com", false, "Oguz", "Heessels", false, null, "Oguz Heessels", null, null, "AQAAAAEAACcQAAAAEEZvDROZWy6nWiCAJ97+272vX0d8n3VZ4ehPBgH/eiftqBHDDHXu58HERUH0jVjnLQ==", null, false, null, null, false, "oguzheessels@example.com" },
                    { 28, 0, "e7d3e2f6-90f4-46df-85a5-583a08c45675", "mariaburggraaff@example.com", false, "Maria", "Burggraaff", false, null, "Maria Burggraaff", null, null, "AQAAAAEAACcQAAAAEGvWS2ckzm7KnfYWhC8DBvppPpqi/YgpcVLb+nJqXMAbPuk5LiQbfjvCATDsDDNbDQ==", null, false, null, null, false, "mariaburggraaff@example.com" },
                    { 29, 0, "5e420de3-de0d-43dd-b3c6-942d302f3ac3", "katelijnvandekoppel@example.com", false, "Katelijn", "Van de Koppel", false, null, "Katelijn Van de Koppel", null, null, "AQAAAAEAACcQAAAAEJjU4x8SigYMdI93E8OaPLVRO8808T6+GhK9FBAVaszs4HcMc4a2QFZfCJgp2Ac6SA==", null, false, null, null, false, "katelijnvandekoppel@example.com" },
                    { 30, 0, "989e1eab-99af-41f6-9213-18d2dc3f5c5a", "desirescheeren@example.com", false, "Désiré", "Scheeren", false, null, "Désiré Scheeren", null, null, "AQAAAAEAACcQAAAAEI5Sbn2roRO7M0JUQCIPCkUmaH2WnLftxtbAFs2nFQ8T0obY6hZU6C6PMoCfNv+j2g==", null, false, null, null, false, "desirescheeren@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TimedOut", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 31, 0, "fb5e5bb8-8c1e-4c23-bec9-3ce258ee04a6", "daxgabriel@example.com", false, "Dax", "Gabriel", false, null, "Dax Gabriel", null, null, "AQAAAAEAACcQAAAAEL4ZctmYjkokfHUknkdAm0/2wknDY2/tBpofVhNI4jxZRIH/YkbWsGq8b4b71LdfHw==", null, false, null, null, false, "daxgabriel@example.com" },
                    { 32, 0, "a2a36922-134c-4037-b7ff-a22d43b10bda", "tommiestel@example.com", false, "Tommie", "Stel", false, null, "Tommie Stel", null, null, "AQAAAAEAACcQAAAAEILKbVjBgVmiqij2+xgDK3yWsqY4FanQ0eytS0Z1Eq8FFUFnuFvXG7frhVUf4AHMNA==", null, false, null, null, false, "tommiestel@example.com" },
                    { 33, 0, "58d055b3-6c81-4cf4-8d0b-8960205a350e", "raphaelkoppe@example.com", false, "Raphaël", "Koppe", false, null, "Raphaël Koppe", null, null, "AQAAAAEAACcQAAAAEP3ivOlmCLKgh1ZW8eY2Qqlrcb7gqg3t0Je1FBniO/YnoCRxMK+yVAtB3EFDrhTljg==", null, false, null, null, false, "raphaelkoppe@example.com" },
                    { 34, 0, "ea02bba9-7e04-45bd-ad99-a2d01be1c846", "demyjongen@example.com", false, "Demy", "Jongen", false, null, "Demy Jongen", null, null, "AQAAAAEAACcQAAAAEJo266a/6m8Pc5w8ffAGmiQR8oWjHicXfXLtlWky2+qTaKR1YTdyY0V3ZUiM9944ug==", null, false, null, null, false, "demyjongen@example.com" },
                    { 35, 0, "7d0a5c34-399c-4510-a632-4acef02ce778", "leahharreman@example.com", false, "Leah", "Harreman", false, null, "Leah Harreman", null, null, "AQAAAAEAACcQAAAAEBOJoCYt9M41e+Ja8zqwgUC/XUAITdoZda+nf+pi5Bh/Lul39OnHFuJS1T/SfaI1pg==", null, false, null, null, false, "leahharreman@example.com" },
                    { 36, 0, "e53114d3-4ed2-493c-92cb-30f17881bf1b", "idrisskorpershoek@example.com", false, "Idriss", "Korpershoek", false, null, "Idriss Korpershoek", null, null, "AQAAAAEAACcQAAAAEPG1SzTZ094y/3FnN5fGXQSapXaV6/l7yp+F0j4g+xIRbG3c61j072BMBe/LxjJVYw==", null, false, null, null, false, "idrisskorpershoek@example.com" },
                    { 37, 0, "2e3ddce6-05f3-43f2-80c6-a6b613bd8ea3", "rashiedbleumink@example.com", false, "Rashied", "Bleumink", false, null, "Rashied Bleumink", null, null, "AQAAAAEAACcQAAAAEI1xP2UDS4/NZc1Wllb97drqZL8avZ3yKVS1b9cyA8KRgF3NhavYol78ljMlw+nmiw==", null, false, null, null, false, "rashiedbleumink@example.com" },
                    { 38, 0, "9a444547-2837-4f6d-afbb-791cb8002d65", "siay@example.com", false, "Si", "Ay", false, null, "Si Ay", null, null, "AQAAAAEAACcQAAAAECTRNpqtWZ4KpOgWIhStt+ZGNTvqoBNRTFGyVgCTtj63GOg/M589ibfP8T0WHTI4Cw==", null, false, null, null, false, "siay@example.com" },
                    { 39, 0, "d008e0d0-858c-4f40-acb6-9aa1d49b8ac5", "manolyalebens@example.com", false, "Manolya", "Lebens", false, null, "Manolya Lebens", null, null, "AQAAAAEAACcQAAAAEEYkUFxv9hvdXixIzCnEtvsE9rfjLF9e4qdQ82XfgBVvpKHUZ+P2S2j7oEaTsJ6/Wg==", null, false, null, null, false, "manolyalebens@example.com" },
                    { 40, 0, "394350e4-d61f-4a32-9aa8-f34a805ded3a", "mateuszmachielsen@example.com", false, "Mateusz", "Machielsen", false, null, "Mateusz Machielsen", null, null, "AQAAAAEAACcQAAAAEI6VWEIAeEgToauUOaRYX/ltPD4UyxD3EKfhJemJiH/XR1eFjdqLGpWK4oLWMnPbHQ==", null, false, null, null, false, "mateuszmachielsen@example.com" },
                    { 41, 0, "7442b259-1bea-4b95-a16b-ad56de397a82", "douaavandepavert@example.com", false, "Douaa", "Van de Pavert", false, null, "Douaa Van de Pavert", null, null, "AQAAAAEAACcQAAAAEBQryB4QYnkjlJdud5Lnb1pnYzJyyhpFkPwdAiZxDNIoMPGVbqMD5PgXjHOLwntQ4g==", null, false, null, null, false, "douaavandepavert@example.com" },
                    { 42, 0, "58779afc-c1c2-4cc9-91ce-7299b0a9528d", "kishanhoogkamp@example.com", false, "Kishan", "Hoogkamp", false, null, "Kishan Hoogkamp", null, null, "AQAAAAEAACcQAAAAEPId9lVi0Jy4RSqi8k6IAUwr4XA0G8mFh/u17vm9NxLVG/2lYiKRoWMcacmDdJDhMA==", null, false, null, null, false, "kishanhoogkamp@example.com" },
                    { 43, 0, "b756cf89-5574-4792-b961-edd49bc7457b", "harmjanversendaal@example.com", false, "Harmjan", "Versendaal", false, null, "Harmjan Versendaal", null, null, "AQAAAAEAACcQAAAAEC4WlbVowtewJIaeELaYkRd92K3rWkRdDVT2M5aV6D7sLU8Q2cL8Gl+lWp9DYI/Veg==", null, false, null, null, false, "harmjanversendaal@example.com" }
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
                values: new object[] { 1, true, true, "Computer Science", "This is a note", true, true, 1 });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RolesId", "UsersId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 2, 12 },
                    { 2, 13 },
                    { 2, 14 },
                    { 2, 15 },
                    { 2, 16 },
                    { 2, 17 },
                    { 2, 18 },
                    { 2, 19 },
                    { 2, 20 },
                    { 2, 21 },
                    { 2, 22 },
                    { 2, 23 },
                    { 2, 24 },
                    { 2, 25 },
                    { 2, 26 },
                    { 2, 27 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RolesId", "UsersId" },
                values: new object[,]
                {
                    { 2, 28 },
                    { 2, 29 },
                    { 2, 30 },
                    { 2, 31 },
                    { 2, 32 },
                    { 2, 33 },
                    { 2, 34 },
                    { 2, 35 },
                    { 2, 36 },
                    { 2, 37 },
                    { 2, 38 },
                    { 2, 39 },
                    { 2, 40 },
                    { 2, 41 },
                    { 2, 42 },
                    { 2, 43 },
                    { 3, 2 },
                    { 3, 3 },
                    { 4, 2 },
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
                name: "IX_Cohorts_UserId",
                table: "Cohorts",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

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
                name: "Cohorts");

            migrationBuilder.DropTable(
                name: "StudyRoutes");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "SemesterItems");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
